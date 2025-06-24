using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        private string connectionString = "server='127.0.0.1';database=smile_sunshine_toys;uid=root;pwd='';";
        private System.Windows.Forms.Label lblUsernamePlaceholder;
        private System.Windows.Forms.Label lblPasswordPlaceholder;

        public Form8()
        {
            InitializeComponent();
            SetupPlaceholderBehavior();
        }

        private void SetupPlaceholderBehavior()
        {
            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;

            lblUsernamePlaceholder.Click += Placeholder_Click;
            lblPasswordPlaceholder.Click += Placeholder_Click;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender == txtUsername) lblUsernamePlaceholder.Visible = false;
            if (sender == txtPassword) lblPasswordPlaceholder.Visible = false;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender == txtUsername) lblUsernamePlaceholder.Visible = string.IsNullOrEmpty(txtUsername.Text);
            if (sender == txtPassword) lblPasswordPlaceholder.Visible = string.IsNullOrEmpty(txtPassword.Text);
        }

        private void Placeholder_Click(object sender, EventArgs e)
        {
            if (sender == lblUsernamePlaceholder) txtUsername.Focus();
            if (sender == lblPasswordPlaceholder) txtPassword.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
            registrationForm.FormClosed += (s, args) => this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT UserID, Password, Role, DepartmentID 
                                   FROM users 
                                   WHERE Username = @username";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Username not found", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            reader.Read();
                            string storedPassword = reader["Password"].ToString();

                            // In production, you should use password hashing:
                            // if (!VerifyPassword(password, storedPassword))
                            if (storedPassword != password)
                            {
                                MessageBox.Show("Incorrect password", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Store user session information
                            UserSession.CurrentUser = new UserInfo
                            {
                                UserID = reader["UserID"].ToString(),
                                Username = username,
                                Role = reader["Role"].ToString(),
                                DepartmentID = reader["DepartmentID"] != DBNull.Value ?
                                    Convert.ToInt32(reader["DepartmentID"]) : 0
                            };

                            // Open appropriate dashboard
                            OpenDashboard();
                            this.Hide();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboard()
        {
            Form dashboard = null;

            switch (UserSession.CurrentUser.Role)
            {
                case "Admin":
                    dashboard = new Form31();
                    break;
                case "Manager":
                    dashboard = new Form32();
                    break;
                case "Staff":
                    dashboard = new Form33();
                    break;
                case "Customer":
                    dashboard = new Form34();
                    break;
                default:
                    dashboard = new Form30();
                    break;
            }

            if (dashboard != null)
            {
                dashboard.Show();
                dashboard.FormClosed += (s, args) => this.Close();
            }
        }

        // Password hashing method (for production use)
        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            // Implement proper password hashing verification
            // Example using BCrypt:
            // return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
            return inputPassword == storedHash; // Remove this in production
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void panelFormContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            RegistrationForm R1 = new RegistrationForm();
            R1.Show();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }

    public static class UserSession
    {
        public static UserInfo CurrentUser { get; set; }
    }

    public class UserInfo
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public int DepartmentID { get; set; }
    }
}

