using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "server=localhost;database=smile_sunshine_toys;uid=root;pwd=yourpassword;";

        public RegistrationForm()
        {
            InitializeComponent();
            // Add your initialization code here
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
        
            // Add your registration logic here
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if username exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE Username = @username";
                    using (var checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@username", username);
                        int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = @"INSERT INTO users 
                                          (Username, Password, Email, Role) 
                                          VALUES (@username, @password, @email, 'Customer')";

                    using (var insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@password", password); // In production, hash this
                        insertCommand.Parameters.AddWithValue("@email", email);

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

