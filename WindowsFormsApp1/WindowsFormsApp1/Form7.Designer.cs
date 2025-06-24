namespace WindowsFormsApp1
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelEmployeeInfo = new System.Windows.Forms.Panel();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOfficeCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelRecentOrders = new System.Windows.Forms.Panel();
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelEmployeeInfo.SuspendLayout();
            this.panelRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumPurple;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1791, 120);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(32, 30);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(318, 44);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [User]";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateTime.Location = new System.Drawing.Point(36, 75);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(148, 31);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "[DateTime]";
            // 
            // panelEmployeeInfo
            // 
            this.panelEmployeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeInfo.Controls.Add(this.lblEmployeeInfo);
            this.panelEmployeeInfo.Controls.Add(this.lblJobTitle);
            this.panelEmployeeInfo.Controls.Add(this.label2);
            this.panelEmployeeInfo.Controls.Add(this.lblOfficeCode);
            this.panelEmployeeInfo.Controls.Add(this.label4);
            this.panelEmployeeInfo.Controls.Add(this.lblReportsTo);
            this.panelEmployeeInfo.Controls.Add(this.label6);
            this.panelEmployeeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEmployeeInfo.Location = new System.Drawing.Point(55, 150);
            this.panelEmployeeInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelEmployeeInfo.Name = "panelEmployeeInfo";
            this.panelEmployeeInfo.Size = new System.Drawing.Size(583, 418);
            this.panelEmployeeInfo.TabIndex = 1;
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("Segoe UI", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfo.Location = new System.Drawing.Point(16, 14);
            this.lblEmployeeInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(284, 50);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee Info:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(231, 99);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(150, 45);
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "[JobTitle]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Title:";
            // 
            // lblOfficeCode
            // 
            this.lblOfficeCode.AutoSize = true;
            this.lblOfficeCode.Location = new System.Drawing.Point(231, 144);
            this.lblOfficeCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOfficeCode.Name = "lblOfficeCode";
            this.lblOfficeCode.Size = new System.Drawing.Size(199, 45);
            this.lblOfficeCode.TabIndex = 4;
            this.lblOfficeCode.Text = "[OfficeCode]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office Code:";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(231, 189);
            this.lblReportsTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(182, 45);
            this.lblReportsTo.TabIndex = 6;
            this.lblReportsTo.Text = "[ReportsTo]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reports To:";
            // 
            // panelRecentOrders
            // 
            this.panelRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecentOrders.Controls.Add(this.lblRecentOrders);
            this.panelRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.panelRecentOrders.Location = new System.Drawing.Point(681, 150);
            this.panelRecentOrders.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelRecentOrders.Name = "panelRecentOrders";
            this.panelRecentOrders.Size = new System.Drawing.Size(1073, 665);
            this.panelRecentOrders.TabIndex = 2;
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.Location = new System.Drawing.Point(19, 14);
            this.lblRecentOrders.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(234, 45);
            this.lblRecentOrders.TabIndex = 1;
            this.lblRecentOrders.Text = "Recent Orders:";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.Location = new System.Drawing.Point(25, 75);
            this.dgvRecentOrders.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersWidth = 51;
            this.dgvRecentOrders.RowTemplate.Height = 24;
            this.dgvRecentOrders.Size = new System.Drawing.Size(1028, 576);
            this.dgvRecentOrders.TabIndex = 0;
            this.dgvRecentOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentOrders_CellContentClick);
            // 
            // panelActions
            // 
            this.panelActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActions.Controls.Add(this.btnLogout);
            this.panelActions.Controls.Add(this.btnUpdateProfile);
            this.panelActions.Controls.Add(this.btnViewOrders);
            this.panelActions.Controls.Add(this.btnViewCustomers);
            this.panelActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelActions.Location = new System.Drawing.Point(55, 615);
            this.panelActions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(583, 217);
            this.panelActions.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(280, 103);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(218, 65);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateProfile.Location = new System.Drawing.Point(56, 103);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(203, 65);
            this.btnUpdateProfile.TabIndex = 2;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewOrders.Location = new System.Drawing.Point(280, 25);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(218, 68);
            this.btnViewOrders.TabIndex = 1;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewCustomers.Location = new System.Drawing.Point(53, 25);
            this.btnViewCustomers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(206, 63);
            this.btnViewCustomers.TabIndex = 0;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // EmployeePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1791, 870);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelRecentOrders);
            this.Controls.Add(this.panelEmployeeInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "EmployeePortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeePortal_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelEmployeeInfo.ResumeLayout(false);
            this.panelEmployeeInfo.PerformLayout();
            this.panelRecentOrders.ResumeLayout(false);
            this.panelRecentOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panelEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOfficeCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Timer timerDateTime;
    }
}
