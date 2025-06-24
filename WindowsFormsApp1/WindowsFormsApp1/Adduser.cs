using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class AddUserForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }
        public int DepartmentId { get; private set; }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private NumericUpDown numDeptId;
        private Button btnSubmit;
        private Button btnCancel;

        public AddUserForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Add New User";
            this.Size = new System.Drawing.Size(400, 350);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Username
            var lblUsername = new Label
            {
                Text = "Username:",
                Location = new Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(lblUsername);

            txtUsername = new TextBox
            {
                Location = new Point(120, 20),
                Size = new Size(250, 25)
            };
            this.Controls.Add(txtUsername);

            // Password
            var lblPassword = new Label
            {
                Text = "Password:",
                Location = new Point(20, 60),
                AutoSize = true
            };
            this.Controls.Add(lblPassword);

            txtPassword = new TextBox
            {
                Location = new Point(120, 60),
                Size = new Size(250, 25),
                PasswordChar = '*'
            };
            this.Controls.Add(txtPassword);

            // Email
            var lblEmail = new Label
            {
                Text = "Email:",
                Location = new Point(20, 100),
                AutoSize = true
            };
            this.Controls.Add(lblEmail);

            txtEmail = new TextBox
            {
                Location = new Point(120, 100),
                Size = new Size(250, 25)
            };
            this.Controls.Add(txtEmail);

            // Role
            var lblRole = new Label
            {
                Text = "Role:",
                Location = new Point(20, 140),
                AutoSize = true
            };
            this.Controls.Add(lblRole);

            cmbRole = new ComboBox
            {
                Location = new Point(120, 140),
                Size = new Size(250, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRole.Items.AddRange(new object[] { "Admin", "Manager", "Staff", "Customer" });
            cmbRole.SelectedIndex = 0;
            this.Controls.Add(cmbRole);

            // Department ID
            var lblDeptId = new Label
            {
                Text = "Dept ID:",
                Location = new Point(20, 180),
                AutoSize = true
            };
            this.Controls.Add(lblDeptId);

            numDeptId = new NumericUpDown
            {
                Location = new Point(120, 180),
                Size = new Size(100, 25),
                Minimum = 1,
                Maximum = 100
            };
            this.Controls.Add(numDeptId);

            // Buttons
            btnSubmit = new Button
            {
                Text = "Submit",
                DialogResult = DialogResult.OK,
                Location = new Point(120, 230),
                Size = new Size(100, 30)
            };
            btnSubmit.Click += (s, e) =>
            {
                if (ValidateInput())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };
            this.Controls.Add(btnSubmit);

            btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(230, 230),
                Size = new Size(100, 30)
            };
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnSubmit;
            this.CancelButton = btnCancel;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Valid email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Set properties if validation passes
            Username = txtUsername.Text.Trim();
            Password = txtPassword.Text;
            Email = txtEmail.Text.Trim();
            Role = cmbRole.SelectedItem.ToString();
            DepartmentId = (int)numDeptId.Value;

            return true;
        }
    }
}