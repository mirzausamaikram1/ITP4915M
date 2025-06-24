using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form40 : Form
    {
        private string connectionString = "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd='';";
        private DataTable productsTable;
        private List<OrderItem> orderItems = new List<OrderItem>();

        public class OrderItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal Total => Price * Quantity;
        }

        public Form40()
        {
            InitializeComponent();
            InitializeFormComponents();
            LoadProducts();
        }

        private void InitializeFormComponents()
        {
            // Form Settings
            this.Text = "New Order";
            this.ClientSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Main Table Layout
            var mainTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 4,
                Padding = new Padding(10)
            };
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));

            // Products DataGridView
            dgvProducts = new DataGridView
            {
                Name = "dgvProducts",
                Dock = DockStyle.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            mainTable.Controls.Add(dgvProducts, 0, 0);
            mainTable.SetRowSpan(dgvProducts, 3);

            // Order Items ListBox
            lstOrderItems = new ListBox
            {
                Name = "lstOrderItems",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F)
            };
            mainTable.Controls.Add(lstOrderItems, 1, 0);
            mainTable.SetRowSpan(lstOrderItems, 2);

            // Quantity NumericUpDown
            numQuantity = new NumericUpDown
            {
                Name = "numQuantity",
                Minimum = 1,
                Maximum = 100,
                Value = 1,
                Width = 100
            };
            var quantityPanel = new Panel { Dock = DockStyle.Fill };
            quantityPanel.Controls.Add(numQuantity);
            quantityPanel.Controls.Add(new Label
            {
                Text = "Quantity:",
                AutoSize = true,
                Location = new Point(0, 3)
            });
            numQuantity.Location = new Point(70, 0);
            mainTable.Controls.Add(quantityPanel, 1, 2);

            // Buttons Panel
            var buttonPanel = new Panel { Dock = DockStyle.Fill };
            btnAddItem = new Button
            {
                Text = "Add to Order",
                Size = new Size(120, 40),
                Location = new Point(10, 0)
            };
            btnAddItem.Click += BtnAddItem_Click;

            btnRemoveItem = new Button
            {
                Text = "Remove Item",
                Size = new Size(120, 40),
                Location = new Point(140, 0)
            };
            btnRemoveItem.Click += BtnRemoveItem_Click;

            btnSubmitOrder = new Button
            {
                Text = "Submit Order",
                Size = new Size(120, 40),
                Location = new Point(270, 0),
                BackColor = Color.SeaGreen,
                ForeColor = Color.White
            };
            btnSubmitOrder.Click += BtnSubmitOrder_Click;

            buttonPanel.Controls.Add(btnAddItem);
            buttonPanel.Controls.Add(btnRemoveItem);
            buttonPanel.Controls.Add(btnSubmitOrder);
            mainTable.Controls.Add(buttonPanel, 0, 3);
            mainTable.SetColumnSpan(buttonPanel, 2);

            this.Controls.Add(mainTable);
        }

        private void LoadProducts()
        {
            try
            {
                string query = @"SELECT product_id, product_name, price 
                               FROM products 
                               WHERE quantity_in_stock > 0
                               ORDER BY product_name";
                productsTable = new DataTable();
                using (var connection = new MySqlConnection(connectionString))
                {
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(productsTable);
                    }
                }

                dgvProducts.DataSource = productsTable;
                dgvProducts.Columns["product_id"].HeaderText = "ID";
                dgvProducts.Columns["product_name"].HeaderText = "Product Name";
                dgvProducts.Columns["price"].HeaderText = "Price";
                dgvProducts.Columns["price"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvProducts.SelectedRows[0];
            var item = new OrderItem
            {
                ProductId = Convert.ToInt32(selectedRow.Cells["product_id"].Value),
                ProductName = selectedRow.Cells["product_name"].Value.ToString(),
                Price = Convert.ToDecimal(selectedRow.Cells["price"].Value),
                Quantity = (int)numQuantity.Value
            };

            orderItems.Add(item);
            UpdateOrderItemsList();
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrderItems.SelectedIndex >= 0)
            {
                orderItems.RemoveAt(lstOrderItems.SelectedIndex);
                UpdateOrderItemsList();
            }
        }

        private void UpdateOrderItemsList()
        {
            lstOrderItems.Items.Clear();
            decimal total = 0;

            foreach (var item in orderItems)
            {
                lstOrderItems.Items.Add($"{item.Quantity}x {item.ProductName} @ {item.Price:C} = {item.Total:C}");
                total += item.Total;
            }

            lstOrderItems.Items.Add($"----------------------------");
            lstOrderItems.Items.Add($"TOTAL: {total:C}");
        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Please add items to the order first", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start transaction
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insert order header
                            string orderQuery = @"INSERT INTO orders 
                                (customer_id, order_date, total_amount, status, shipping_address)
                                VALUES (@customerId, NOW(), @total, 'Pending', @address);
                                SELECT LAST_INSERT_ID();";

                            decimal total = orderItems.Sum(item => item.Total);
                            var orderParams = new[]
                            {
                                new MySqlParameter("@customerId", UserSession.CurrentUser.UserID),
                                new MySqlParameter("@total", total),
                                new MySqlParameter("@address", "123 Main St") // Replace with actual address
                            };

                            int orderId = Convert.ToInt32(new MySqlCommand(orderQuery, connection, transaction)
                                .ExecuteScalar());

                            // Insert order items
                            foreach (var item in orderItems)
                            {
                                string itemQuery = @"INSERT INTO order_items 
                                    (order_id, product_id, quantity, unit_price)
                                    VALUES (@orderId, @productId, @quantity, @price)";

                                var itemParams = new[]
                                {
                                    new MySqlParameter("@orderId", orderId),
                                    new MySqlParameter("@productId", item.ProductId),
                                    new MySqlParameter("@quantity", item.Quantity),
                                    new MySqlParameter("@price", item.Price)
                                };

                                new MySqlCommand(itemQuery, connection, transaction)
                                    .ExecuteNonQuery();

                                // Update product stock
                                string updateQuery = @"UPDATE products 
                                                    SET quantity_in_stock = quantity_in_stock - @qty
                                                    WHERE product_id = @productId";

                                var updateParams = new[]
                                {
                                    new MySqlParameter("@qty", item.Quantity),
                                    new MySqlParameter("@productId", item.ProductId)
                                };

                                new MySqlCommand(updateQuery, connection, transaction)
                                    .ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show($"Order #{orderId} created successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error creating order: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Declare controls that need class-level access
        private DataGridView dgvProducts;
        private ListBox lstOrderItems;
        private NumericUpDown numQuantity;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Button btnSubmitOrder;
    }
}