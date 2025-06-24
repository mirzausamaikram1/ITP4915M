using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class ProductManagement : Form
    {
        private string connectionString;

        public ProductManagement()
        {
            InitializeComponent();
            LoadAppSettings();
            ConfigureErrorProvider();
            LoadCategories();
            LoadSuppliers();
        }

        private void LoadAppSettings()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}",
                    "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ConfigureErrorProvider()
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
        }

        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();

                    cmbCategory.BeginUpdate();
                    cmbCategory.Items.Clear();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCategory.Items.Add(new
                            {
                                ID = reader["CategoryID"],
                                Name = reader["CategoryName"].ToString()
                            });
                        }
                    }

                    cmbCategory.EndUpdate();
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT SupplierID, CompanyName FROM Suppliers ORDER BY CompanyName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();

                    cmbSupplier.BeginUpdate();
                    cmbSupplier.Items.Clear();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbSupplier.Items.Add(new
                            {
                                ID = reader["SupplierID"],
                                Name = reader["CompanyName"].ToString()
                            });
                        }
                    }

                    cmbSupplier.EndUpdate();
                    cmbSupplier.DisplayMember = "Name";
                    cmbSupplier.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Products 
                                    (ProductID, ProductName, SupplierID, CategoryID, 
                                     QuantityPerUnit, UnitPrice, UnitsInStock, 
                                     UnitsOnOrder, ReorderLevel) 
                                    VALUES 
                                    (@ProductID, @ProductName, @SupplierID, @CategoryID, 
                                     @QuantityPerUnit, @UnitPrice, @UnitsInStock, 
                                     @UnitsOnOrder, @ReorderLevel)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    AddParametersToCommand(command);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product saved successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                errorProvider.SetError(txtProductID, "Product ID already exists");
                txtProductID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validate Product ID
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                errorProvider.SetError(txtProductID, "Product ID is required");
                isValid = false;
            }

            // Validate Product Name
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(txtProductName, "Product name is required");
                isValid = false;
            }

            // Validate Supplier
            if (cmbSupplier.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbSupplier, "Please select a supplier");
                isValid = false;
            }

            // Validate Category
            if (cmbCategory.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCategory, "Please select a category");
                isValid = false;
            }

            // Validate Unit Price
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                errorProvider.SetError(txtUnitPrice, "Please enter a valid price");
                isValid = false;
            }

            // Validate Units In Stock
            if (!short.TryParse(txtUnitsInStock.Text, out short unitsInStock) || unitsInStock < 0)
            {
                errorProvider.SetError(txtUnitsInStock, "Please enter a valid quantity");
                isValid = false;
            }

            // Validate Units On Order
            if (!short.TryParse(txtUnitsOnOrder.Text, out short unitsOnOrder) || unitsOnOrder < 0)
            {
                errorProvider.SetError(txtUnitsOnOrder, "Please enter a valid quantity");
                isValid = false;
            }

            // Validate Reorder Level
            if (!short.TryParse(txtReorderLevel.Text, out short reorderLevel) || reorderLevel < 0)
            {
                errorProvider.SetError(txtReorderLevel, "Please enter a valid quantity");
                isValid = false;
            }

            return isValid;
        }

        private void AddParametersToCommand(MySqlCommand command)
        {
            command.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
            command.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            command.Parameters.AddWithValue("@SupplierID", ((dynamic)cmbSupplier.SelectedItem).ID);
            command.Parameters.AddWithValue("@CategoryID", ((dynamic)cmbCategory.SelectedItem).ID);
            command.Parameters.AddWithValue("@QuantityPerUnit", txtQuantityPerUnit.Text.Trim());
            command.Parameters.AddWithValue("@UnitPrice", decimal.Parse(txtUnitPrice.Text));
            command.Parameters.AddWithValue("@UnitsInStock", short.Parse(txtUnitsInStock.Text));
            command.Parameters.AddWithValue("@UnitsOnOrder", short.Parse(txtUnitsOnOrder.Text));
            command.Parameters.AddWithValue("@ReorderLevel", short.Parse(txtReorderLevel.Text));
        }

        private void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }
            errorProvider.Clear();
            txtProductID.Focus();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || ((TextBox)sender).Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
