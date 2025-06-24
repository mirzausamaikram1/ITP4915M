using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        private string connectionString = "server='127.0.0.1';database=smile_sunshine_toys;uid=root;pwd='';";
        private DataTable productsTable;
        private int currentPosition = 0;
        private Timer refreshTimer;

        public Form10()
        {
            InitializeComponent();
            InitializeUI();
            LoadProductData();
            InitializeTimer();
        }

        private void InitializeUI()
        {
            lblTitle.Text = "Product Browser";
            lblStatus.Text = "Ready";
            lblPosition.Text = "Record 0 of 0";
            btnRefresh.Text = "Refresh Data";
        }

        private void InitializeTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 1000; // 1 second
            refreshTimer.Tick += (sender, e) => lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm tt");
            refreshTimer.Start();
        }

        private void LoadProductData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"SELECT p.productCode, p.productName, p.productLine, 
                                   p.productScale, p.productVendor, p.quantityInStock, 
                                   p.buyPrice, p.MSRP, pl.textDescription AS productLineDescription
                                   FROM products p
                                   JOIN productlines pl ON p.productLine = pl.productLine
                                   ORDER BY p.productName";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    productsTable = new DataTable();
                    adapter.Fill(productsTable);

                    lblStatus.Text = $"Loaded {productsTable.Rows.Count} products";
                    dgvProducts.DataSource = productsTable;
                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message,
                              "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error loading data";
            }
        }

        private void ConfigureDataGridView()
        {
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Format columns
            if (dgvProducts.Columns.Contains("buyPrice"))
                dgvProducts.Columns["buyPrice"].DefaultCellStyle.Format = "C2";

            if (dgvProducts.Columns.Contains("MSRP"))
                dgvProducts.Columns["MSRP"].DefaultCellStyle.Format = "C2";

            if (dgvProducts.Columns.Contains("quantityInStock"))
                dgvProducts.Columns["quantityInStock"].HeaderText = "In Stock";
        }

        private void DisplayCurrentProduct()
        {
            if (productsTable == null || productsTable.Rows.Count == 0 || dgvProducts.SelectedRows.Count == 0)
            {
                ClearDetailFields();
                return;
            }

            DataRow row = productsTable.Rows[currentPosition];

            txtProductCode.Text = row["productCode"].ToString();
            txtProductName.Text = row["productName"].ToString();
            txtProductLine.Text = row["productLine"].ToString();
            txtProductScale.Text = row["productScale"].ToString();
            txtVendor.Text = row["productVendor"].ToString();
            txtQuantity.Text = row["quantityInStock"].ToString();
            txtBuyPrice.Text = string.Format("{0:C}", row["buyPrice"]);
            txtMSRP.Text = string.Format("{0:C}", row["MSRP"]);
            txtDescription.Text = row["productLineDescription"].ToString();

            lblPosition.Text = $"Record {currentPosition + 1} of {productsTable.Rows.Count}";
            UpdateNavigationButtons();
        }

        private void ClearDetailFields()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtProductLine.Clear();
            txtProductScale.Clear();
            txtVendor.Clear();
            txtQuantity.Clear();
            txtBuyPrice.Clear();
            txtMSRP.Clear();
            txtDescription.Clear();
        }

        private void UpdateNavigationButtons()
        {
            btnFirst.Enabled = currentPosition > 0;
            btnPrevious.Enabled = currentPosition > 0;
            btnNext.Enabled = currentPosition < productsTable.Rows.Count - 1;
            btnLast.Enabled = currentPosition < productsTable.Rows.Count - 1;
        }

        private void NavigateToRecord(int position)
        {
            if (productsTable != null && position >= 0 && position < productsTable.Rows.Count)
            {
                currentPosition = position;
                dgvProducts.ClearSelection();
                dgvProducts.Rows[currentPosition].Selected = true;
                dgvProducts.FirstDisplayedScrollingRowIndex = currentPosition;
                DisplayCurrentProduct();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e) => NavigateToRecord(0);
        private void btnPrevious_Click(object sender, EventArgs e) => NavigateToRecord(currentPosition - 1);
        private void btnNext_Click(object sender, EventArgs e) => NavigateToRecord(currentPosition + 1);
        private void btnLast_Click(object sender, EventArgs e) => NavigateToRecord(productsTable.Rows.Count - 1);

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductData();
            NavigateToRecord(0);
            lblStatus.Text = "Data refreshed at " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                currentPosition = dgvProducts.SelectedRows[0].Index;
                DisplayCurrentProduct();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (productsTable != null)
            {
                string filter = $"productName LIKE '%{txtSearch.Text}%' OR productCode LIKE '%{txtSearch.Text}%'";
                productsTable.DefaultView.RowFilter = filter;
                lblStatus.Text = $"Showing {productsTable.DefaultView.Count} matching products";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            refreshTimer?.Stop();
            refreshTimer?.Dispose();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
