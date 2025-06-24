using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form31 : Form
    {
        // Database Connection
        private string connectionString = "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd='';";
        private MySqlConnection connection;

        // UI Components
        private DataGridView dgvUsers;
        private Button btnRefresh;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private ToolStripStatusLabel lblStatus;

        public Form31()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeAdminComponents();
            LoadUserData();
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

        private void InitializeAdminComponents()
        {
            // Form Settings
            this.Text = "Admin Dashboard";
            this.ClientSize = new Size(1000, 650);
            this.BackColor = Color.Lavender;

            // Add Header
            AddHeader("ADMINISTRATOR DASHBOARD");

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
            dgvUsers = new DataGridView
            {
                Name = "dgvUsers",
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

            btnAddUser = new Button
            {
                Text = "Add User",
                BackColor = Color.SeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(160, 10)
            };
            btnAddUser.Click += BtnAddUser_Click;

            btnDeleteUser = new Button
            {
                Text = "Delete User",
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(300, 10)
            };
            btnDeleteUser.Click += BtnDeleteUser_Click;

            // Add controls
            controlPanel.Controls.Add(btnRefresh);
            controlPanel.Controls.Add(btnAddUser);
            controlPanel.Controls.Add(btnDeleteUser);
            mainPanel.Controls.Add(dgvUsers);
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

        private void LoadUserData()
        {
            try
            {
                string query = @"SELECT 
                    user_id AS 'ID',
                    username AS 'Username',
                    email AS 'Email',
                    role AS 'Role',
                    department_id AS 'Department',
                    created_at AS 'Created On'
                FROM users
                ORDER BY created_at DESC";

                DataTable usersTable = ExecuteQuery(query);
                dgvUsers.DataSource = usersTable;

                if (dgvUsers.Columns.Contains("Created On"))
                {
                    dgvUsers.Columns["Created On"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }

                lblStatus.Text = $"Loaded {usersTable.Rows.Count} users at {DateTime.Now.ToString("HH:mm:ss")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadUserData();

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddUserForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string query = @"INSERT INTO users 
                            (username, password, email, role, department_id)
                            VALUES (@username, @password, @email, @role, @deptId)";

                        var parameters = new[]
                        {
                            new MySqlParameter("@username", addForm.Username),
                            new MySqlParameter("@password", BCrypt.Net.BCrypt.HashPassword(addForm.Password)),
                            new MySqlParameter("@email", addForm.Email),
                            new MySqlParameter("@role", addForm.Role),
                            new MySqlParameter("@deptId", addForm.DepartmentId)
                        };

                        int rowsAffected = ExecuteNonQuery(query, parameters);
                        if (rowsAffected > 0)
                        {
                            LoadUserData();
                            lblStatus.Text = $"User {addForm.Username} added at {DateTime.Now.ToString("HH:mm:ss")}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding user: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userId = dgvUsers.SelectedRows[0].Cells["ID"].Value.ToString();
            if (MessageBox.Show($"Delete user {userId}?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM users WHERE user_id = @userId";
                    var parameter = new MySqlParameter("@userId", userId);

                    int rowsAffected = ExecuteNonQuery(query, parameter);
                    if (rowsAffected > 0)
                    {
                        LoadUserData();
                        lblStatus.Text = $"User {userId} deleted at {DateTime.Now.ToString("HH:mm:ss")}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
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