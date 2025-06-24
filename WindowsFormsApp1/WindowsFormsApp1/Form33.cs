using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form33 : Form
    {
        // Database Connection
        private string connectionString = "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd='';";
        private MySqlConnection connection;

        // UI Components
        private DataGridView dgvTasks;
        private Button btnRefresh;
        private Button btnMarkComplete;
        private ToolStripStatusLabel lblStatus;
        private ComboBox cmbTaskFilter;

        public Form33()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeStaffComponents();
            LoadTaskData();
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

        private void InitializeStaffComponents()
        {
            // Form Settings
            this.Text = "Staff Dashboard";
            this.ClientSize = new Size(1000, 650);
            this.BackColor = Color.Lavender;

            // Add Header
            AddHeader("STAFF DASHBOARD");

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
            dgvTasks = new DataGridView
            {
                Name = "dgvTasks",
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
            cmbTaskFilter = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(150, 30),
                Location = new Point(20, 15)
            };
            cmbTaskFilter.Items.AddRange(new object[] { "All Tasks", "Pending", "In Progress", "Completed" });
            cmbTaskFilter.SelectedIndex = 0;
            cmbTaskFilter.SelectedIndexChanged += CmbTaskFilter_SelectedIndexChanged;

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

            btnMarkComplete = new Button
            {
                Text = "Mark Complete",
                BackColor = Color.SeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 40),
                Location = new Point(330, 10)
            };
            btnMarkComplete.Click += BtnMarkComplete_Click;

            // Add controls
            controlPanel.Controls.Add(cmbTaskFilter);
            controlPanel.Controls.Add(btnRefresh);
            controlPanel.Controls.Add(btnMarkComplete);
            mainPanel.Controls.Add(dgvTasks);
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

        private void LoadTaskData()
        {
            try
            {
                string filter = cmbTaskFilter.SelectedItem.ToString();
                string query = @"SELECT 
                    task_id AS 'Task ID',
                    task_description AS 'Description',
                    assigned_date AS 'Assigned Date',
                    deadline AS 'Deadline',
                    status AS 'Status',
                    priority AS 'Priority'
                FROM tasks
                WHERE assigned_to = @userId" +
                (filter != "All Tasks" ? " AND status = @status" : "") +
                " ORDER BY deadline ASC";

                var parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@userId", UserSession.CurrentUser.UserID)
                };

                if (filter != "All Tasks")
                {
                    parameters.Add(new MySqlParameter("@status", filter));
                }

                DataTable tasksTable = ExecuteQuery(query, parameters.ToArray());
                dgvTasks.DataSource = tasksTable;

                if (dgvTasks.Columns.Contains("Assigned Date"))
                {
                    dgvTasks.Columns["Assigned Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }

                if (dgvTasks.Columns.Contains("Deadline"))
                {
                    dgvTasks.Columns["Deadline"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }

                lblStatus.Text = $"Loaded {tasksTable.Rows.Count} tasks at {DateTime.Now.ToString("HH:mm:ss")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}", "Error",
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

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadTaskData();

        private void CmbTaskFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaskData();
        }

        private void BtnMarkComplete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to mark as complete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var taskId = dgvTasks.SelectedRows[0].Cells["Task ID"].Value.ToString();
            if (MessageBox.Show($"Mark task {taskId} as complete?", "Confirm Completion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE tasks SET status = 'Completed', completed_date = NOW() WHERE task_id = @taskId";
                    var parameter = new MySqlParameter("@taskId", taskId);

                    int rowsAffected = ExecuteNonQuery(query, parameter);
                    if (rowsAffected > 0)
                    {
                        LoadTaskData();
                        lblStatus.Text = $"Task {taskId} marked complete at {DateTime.Now.ToString("HH:mm:ss")}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating task: {ex.Message}", "Error",
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