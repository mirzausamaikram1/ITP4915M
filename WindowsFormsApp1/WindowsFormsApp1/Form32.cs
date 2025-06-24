using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form32 : Form
    {
        // Database Connection
        private string connectionString = "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd='';";
        private MySqlConnection connection;

        // UI Components
        private DataGridView dgvOrders;
        private Button btnRefresh;
        private Button btnProcessOrder;
        private ToolStripStatusLabel lblStatus;

        public Form32()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeManagerComponents();
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

        private void InitializeManagerComponents()
        {
            // Form Settings
            this.Text = "Manager Dashboard";
            this.ClientSize = new Size(1000, 650);
            this.BackColor = Color.Lavender;

            // Add Header
            AddHeader("MANAGER DASHBOARD");

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

            // Buttons
            btnRefresh = new Button
            {
                Text = "Refresh",
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(20, 10)
            };
            btnRefresh.Click += BtnRefresh_Click;

            btnProcessOrder = new Button
            {
                Text = "Process Order",
                BackColor = Color.SeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 40),
                Location = new Point(160, 10)
            };
            btnProcessOrder.Click += BtnProcessOrder_Click;

            // Add controls
            controlPanel.Controls.Add(btnRefresh);
            controlPanel.Controls.Add(btnProcessOrder);
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

        private void LoadOrderData()
        {
            try
            {
                string query = @"SELECT 
                    order_id AS 'Order ID',
                    customer_name AS 'Customer',
                    order_date AS 'Order Date',
                    total_amount AS 'Amount',
                    status AS 'Status'
                FROM orders
                WHERE status IN ('Pending', 'Processing')
                ORDER BY order_date DESC";

                DataTable ordersTable = ExecuteQuery(query);
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

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadOrderData();

        private void BtnProcessOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to process", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orderId = dgvOrders.SelectedRows[0].Cells["Order ID"].Value.ToString();
            if (MessageBox.Show($"Process order {orderId}?", "Confirm Processing",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE orders SET status = 'Processing' WHERE order_id = @orderId";
                    var parameter = new MySqlParameter("@orderId", orderId);

                    int rowsAffected = ExecuteNonQuery(query, parameter);
                    if (rowsAffected > 0)
                    {
                        LoadOrderData();
                        lblStatus.Text = $"Order {orderId} processed at {DateTime.Now.ToString("HH:mm:ss")}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing order: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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