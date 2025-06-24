using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        private string connectionString = "server=localhost;database=smile_sunshine_toys;uid=root;pwd=yourpassword;";
        private string employeeName;
        private int employeeNumber;

        public Form7(int employeeNumber, string employeeName)
        {
            InitializeComponent();
            this.employeeNumber = employeeNumber;
            this.employeeName = employeeName;
            InitializeEmployeeDashboard();
            LoadEmployeeData();
            LoadRecentOrders();
        }

        private void InitializeEmployeeDashboard()
        {
            lblWelcome.Text = $"Welcome, {employeeName} (#{employeeNumber})";
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm tt");
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT jobTitle, officeCode, reportsTo FROM employees WHERE employeeNumber = @empNum";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@empNum", employeeNumber);

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblJobTitle.Text = reader["jobTitle"].ToString();
                        lblOfficeCode.Text = reader["officeCode"].ToString();
                        lblReportsTo.Text = reader["reportsTo"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentOrders()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"SELECT o.orderNumber, o.orderDate, o.status, 
                                   c.customerName, SUM(od.priceEach * od.quantityOrdered) AS totalValue
                                   FROM orders o
                                   JOIN customers c ON o.customerNumber = c.customerNumber
                                   JOIN orderdetails od ON o.orderNumber = od.orderNumber
                                   GROUP BY o.orderNumber
                                   ORDER BY o.orderDate DESC
                                   LIMIT 10";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable ordersTable = new DataTable();
                    adapter.Fill(ordersTable);

                    dgvRecentOrders.DataSource = ordersTable;
                    dgvRecentOrders.Columns["orderNumber"].HeaderText = "Order #";
                    dgvRecentOrders.Columns["orderDate"].HeaderText = "Date";
                    dgvRecentOrders.Columns["customerName"].HeaderText = "Customer";
                    dgvRecentOrders.Columns["totalValue"].HeaderText = "Total Value";
                    dgvRecentOrders.Columns["status"].HeaderText = "Status";

                    dgvRecentOrders.Columns["totalValue"].DefaultCellStyle.Format = "C2";
                    dgvRecentOrders.Columns["orderDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent orders: " + ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            // Implement customer view functionality
            MessageBox.Show("Customer view functionality would open here", "View Customers",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            // Implement order view functionality
            MessageBox.Show("Order view functionality would open here", "View Orders",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            // Implement profile update functionality
            MessageBox.Show("Profile update functionality would open here", "Update Profile",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm tt");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeePortal_Load(object sender, EventArgs e)
        {

        }

        private void dgvRecentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

