namespace WindowsFormsApp1
{
    partial class Form10
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProductsGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMSRP = new System.Windows.Forms.TextBox();
            this.lblMSRP = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.txtProductScale = new System.Windows.Forms.TextBox();
            this.lblProductScale = new System.Windows.Forms.Label();
            this.txtProductLine = new System.Windows.Forms.TextBox();
            this.lblProductLine = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelProductsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumPurple;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1625, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(32, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Title";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1300, 30);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(148, 31);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "[DateTime]";
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Location = new System.Drawing.Point(32, 120);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1559, 74);
            this.panelSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(229, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(485, 38);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for:";
            // 
            // panelProductsGrid
            // 
            this.panelProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductsGrid.Controls.Add(this.dgvProducts);
            this.panelProductsGrid.Location = new System.Drawing.Point(32, 226);
            this.panelProductsGrid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelProductsGrid.Name = "panelProductsGrid";
            this.panelProductsGrid.Size = new System.Drawing.Size(974, 599);
            this.panelProductsGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(972, 597);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.txtDescription);
            this.panelDetails.Controls.Add(this.label11);
            this.panelDetails.Controls.Add(this.txtMSRP);
            this.panelDetails.Controls.Add(this.lblMSRP);
            this.panelDetails.Controls.Add(this.txtBuyPrice);
            this.panelDetails.Controls.Add(this.lblBuyPrice);
            this.panelDetails.Controls.Add(this.txtQuantity);
            this.panelDetails.Controls.Add(this.lblQuantity);
            this.panelDetails.Controls.Add(this.txtVendor);
            this.panelDetails.Controls.Add(this.lblVendor);
            this.panelDetails.Controls.Add(this.txtProductScale);
            this.panelDetails.Controls.Add(this.lblProductScale);
            this.panelDetails.Controls.Add(this.txtProductLine);
            this.panelDetails.Controls.Add(this.lblProductLine);
            this.panelDetails.Controls.Add(this.txtProductName);
            this.panelDetails.Controls.Add(this.lblProductName);
            this.panelDetails.Controls.Add(this.txtProductCode);
            this.panelDetails.Controls.Add(this.lblProductCode);
            this.panelDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDetails.Location = new System.Drawing.Point(1040, 226);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(551, 734);
            this.panelDetails.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(37, 597);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(485, 118);
            this.txtDescription.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 531);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 45);
            this.label11.TabIndex = 16;
            this.label11.Text = "Description:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtMSRP
            // 
            this.txtMSRP.Location = new System.Drawing.Point(316, 467);
            this.txtMSRP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMSRP.Name = "txtMSRP";
            this.txtMSRP.ReadOnly = true;
            this.txtMSRP.Size = new System.Drawing.Size(192, 50);
            this.txtMSRP.TabIndex = 15;
            // 
            // lblMSRP
            // 
            this.lblMSRP.AutoSize = true;
            this.lblMSRP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSRP.Location = new System.Drawing.Point(317, 417);
            this.lblMSRP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMSRP.Name = "lblMSRP";
            this.lblMSRP.Size = new System.Drawing.Size(110, 45);
            this.lblMSRP.TabIndex = 14;
            this.lblMSRP.Text = "MSRP:";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(37, 467);
            this.txtBuyPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.ReadOnly = true;
            this.txtBuyPrice.Size = new System.Drawing.Size(192, 50);
            this.txtBuyPrice.TabIndex = 13;
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.Location = new System.Drawing.Point(35, 417);
            this.lblBuyPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(156, 45);
            this.lblBuyPrice.TabIndex = 12;
            this.lblBuyPrice.Text = "Buy Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(316, 347);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(192, 50);
            this.txtQuantity.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(317, 297);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(219, 45);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "In Stock (Qty):";
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(32, 338);
            this.txtVendor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.ReadOnly = true;
            this.txtVendor.Size = new System.Drawing.Size(192, 50);
            this.txtVendor.TabIndex = 9;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(35, 288);
            this.lblVendor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(129, 45);
            this.lblVendor.TabIndex = 8;
            this.lblVendor.Text = "Vendor:";
            // 
            // txtProductScale
            // 
            this.txtProductScale.Location = new System.Drawing.Point(316, 233);
            this.txtProductScale.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductScale.Name = "txtProductScale";
            this.txtProductScale.ReadOnly = true;
            this.txtProductScale.Size = new System.Drawing.Size(192, 50);
            this.txtProductScale.TabIndex = 7;
            // 
            // lblProductScale
            // 
            this.lblProductScale.AutoSize = true;
            this.lblProductScale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductScale.Location = new System.Drawing.Point(308, 183);
            this.lblProductScale.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductScale.Name = "lblProductScale";
            this.lblProductScale.Size = new System.Drawing.Size(220, 45);
            this.lblProductScale.TabIndex = 6;
            this.lblProductScale.Text = "Product Scale:";
            // 
            // txtProductLine
            // 
            this.txtProductLine.Location = new System.Drawing.Point(32, 233);
            this.txtProductLine.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductLine.Name = "txtProductLine";
            this.txtProductLine.ReadOnly = true;
            this.txtProductLine.Size = new System.Drawing.Size(192, 50);
            this.txtProductLine.TabIndex = 5;
            // 
            // lblProductLine
            // 
            this.lblProductLine.AutoSize = true;
            this.lblProductLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLine.Location = new System.Drawing.Point(29, 183);
            this.lblProductLine.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductLine.Name = "lblProductLine";
            this.lblProductLine.Size = new System.Drawing.Size(205, 45);
            this.lblProductLine.TabIndex = 4;
            this.lblProductLine.Text = "Product Line:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(32, 128);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(485, 50);
            this.txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(32, 75);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(232, 45);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(256, 19);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(192, 50);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(24, 19);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(222, 45);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code:";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.btnRefresh);
            this.panelNavigation.Controls.Add(this.btnLast);
            this.panelNavigation.Controls.Add(this.btnNext);
            this.panelNavigation.Controls.Add(this.btnPrevious);
            this.panelNavigation.Controls.Add(this.btnFirst);
            this.panelNavigation.Controls.Add(this.lblPosition);
            this.panelNavigation.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNavigation.Location = new System.Drawing.Point(32, 854);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(974, 88);
            this.panelNavigation.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.Location = new System.Drawing.Point(731, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(195, 45);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLast.Location = new System.Drawing.Point(536, 22);
            this.btnLast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(122, 45);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Location = new System.Drawing.Point(390, 22);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrevious.Location = new System.Drawing.Point(244, 22);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(122, 45);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFirst.Location = new System.Drawing.Point(98, 22);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(122, 45);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(16, 30);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 40);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Pos:";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1625, 1021);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelProductsGrid);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Browser";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelProductsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProductsGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductLine;
        private System.Windows.Forms.Label lblProductLine;
        private System.Windows.Forms.TextBox txtProductScale;
        private System.Windows.Forms.Label lblProductScale;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.TextBox txtMSRP;
        private System.Windows.Forms.Label lblMSRP;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblPosition;
    }
}
