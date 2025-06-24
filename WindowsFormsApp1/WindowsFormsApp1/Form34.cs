using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form34 : Form
    {
        // Database Connection
        private string connectionString = "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd='';";
        private MySqlConnection connection;

        // UI Components
        private DataGridView dgvOrders;
        private Button btnRefresh;
        private Button btnNewOrder;
        private Button btnViewDetails;
        private ToolStripStatusLabel lblStatus;
        private ComboBox cmbOrderFilter;

        public Form34()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeCustomerComponents();
            LoadOrderData();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeCustomerComponents()
        {
            // Form Settings
            this.Text = "Customer Dashboard";
            this.ClientSize = new Size(1000, 650);
            this.BackColor = Color.Lavender;

            // Add Header
            AddHeader("CUSTOMER DASHBOARD");

            // Status Bar
            var statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            statusStrip.Items.Add(lblStatus);
            this.Controls.Add(statusStrip);
            statusStrip.Dock = DockStyle.Bottom;

            // Main Panel
            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                BackColor = Color.White
            };

            // DataGridView
            dgvOrders = new DataGridView
            {
                Name = "dgvOrders",
                Dock = DockStyle.Fill,
                ReadOnly = true,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Control Panel
            var controlPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.Lavender
            };

            // Filter ComboBox
            cmbOrderFilter = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(150, 30),
                Location = new Point(20, 15)
            };
            cmbOrderFilter.Items.AddRange(new object[] { "All Orders", "Pending", "Processing", "Shipped", "Delivered" });
            cmbOrderFilter.SelectedIndex = 0;
            cmbOrderFilter.SelectedIndexChanged += CmbOrderFilter_SelectedIndexChanged;

            // Buttons
            btnRefresh = new Button
            {
                Text = "Refresh",
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(190, 10)
            };
            btnRefresh.Click += BtnRefresh_Click;

            btnNewOrder = new Button
            {
                Text = "New Order",
                BackColor = Color.SeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(330, 10)
            };
            btnNewOrder.Click += BtnNewOrder_Click;

            btnViewDetails = new Button
            {
                Text = "View Details",
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(470, 10)
            };
            btnViewDetails.Click += BtnViewDetails_Click;

            // Add controls
            controlPanel.Controls.Add(cmbOrderFilter);
            controlPanel.Controls.Add(btnRefresh);
            controlPanel.Controls.Add(btnNewOrder);
            controlPanel.Controls.Add(btnViewDetails);
            mainPanel.Controls.Add(dgvOrders);
            this.Controls.Add(mainPanel);
            this.Controls.Add(controlPanel);
        }

        private void AddHeader(string title)
        {
            var headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.MediumPurple
            };

            var titleLabel = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            headerPanel.Controls.Add(titleLabel);
            this.Controls.Add(headerPanel);
            headerPanel.BringToFront();
        }

        private void LoadOrderData()
        {
            try
            {
                string filter = cmbOrderFilter.SelectedItem.ToString();
                string query = @"SELECT 
                    order_id AS 'Order ID',
                    order_date AS 'Order Date',
                    total_amount AS 'Amount',
                    status AS 'Status',
                    shipping_address AS 'Shipping Address'
                FROM orders
                WHERE customer_id = @customerId" +
                (filter != "All Orders" ? " AND status = @status" : "") +
                " ORDER BY order_date DESC";

                var parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@customerId", UserSession.CurrentUser.UserID)
                };

                if (filter != "All Orders")
                {
                    parameters.Add(new MySqlParameter("@status", filter));
                }

                DataTable ordersTable = ExecuteQuery(query, parameters.ToArray());
                dgvOrders.DataSource = ordersTable;

                if (dgvOrders.Columns.Contains("Order Date"))
                {
                    dgvOrders.Columns["Order Date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }

                if (dgvOrders.Columns.Contains("Amount"))
                {
                    dgvOrders.Columns["Amount"].DefaultCellStyle.Format = "C2";
                }

                lblStatus.Text = $"Loaded {ordersTable.Rows.Count} orders at {DateTime.Now.ToString("HH:mm:ss")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Query failed: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        private int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Operation failed: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadOrderData();

        private void CmbOrderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            using (var orderForm = new Form40())
            {
                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrderData();
                }
            }
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to view details", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orderId = dgvOrders.SelectedRows[0].Cells["Order ID"].Value.ToString();
            using (var detailForm = new Form6())
            {
                detailForm.ShowDialog();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}