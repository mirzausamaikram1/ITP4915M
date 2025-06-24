using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string connectionString = "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd=yourpassword";

        public Form2()
        {
            InitializeComponent();
            button7.Click += UploadButton_Click;
            button6.Click += SubmitButton_Click;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "PDF|*.pdf|Images|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ServiceRequests (Item, Details, Status) VALUES (@Item, @Details, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Replace these with your actual control names:
                        command.Parameters.AddWithValue("@Item", "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd=yourpassword");
                        command.Parameters.AddWithValue("@Details", "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd=yourpassword");
                        command.Parameters.AddWithValue("@Status", "server=127.0.0.1;database=smile_sunshine_toys;uid=root;pwd=yourpassword");

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Request submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Overview_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form22 f22 = new Form22();
            f22.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form23 f23 = new Form23();
            f23.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form25 f25 = new Form25();
            f25.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}