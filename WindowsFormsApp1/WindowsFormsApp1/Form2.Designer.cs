
using System;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Menu2 = new System.Windows.Forms.GroupBox();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Support = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Overview = new System.Windows.Forms.ToolStripButton();
            this.Product = new System.Windows.Forms.ToolStripButton();
            this.Orders = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.Menu2.SuspendLayout();
            this.Menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Support.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu2
            // 
            this.Menu2.BackColor = System.Drawing.Color.Lavender;
            this.Menu2.Controls.Add(this.Menu);
            this.Menu2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu2.Location = new System.Drawing.Point(1, 147);
            this.Menu2.Margin = new System.Windows.Forms.Padding(2);
            this.Menu2.Name = "Menu2";
            this.Menu2.Padding = new System.Windows.Forms.Padding(2);
            this.Menu2.Size = new System.Drawing.Size(226, 553);
            this.Menu2.TabIndex = 0;
            this.Menu2.TabStop = false;
            this.Menu2.Text = "Menu";
            this.Menu2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Lavender;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Overview,
            this.Product,
            this.Orders,
            this.Reports,
            this.Settings,
            this.LogOut});
            this.Menu.Location = new System.Drawing.Point(2, 61);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0);
            this.Menu.Size = new System.Drawing.Size(150, 490);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(263, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 507);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 32;
            this.listBox3.Items.AddRange(new object[] {
            "Phone ",
            "Laptop"});
            this.listBox3.Location = new System.Drawing.Point(33, 316);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(145, 36);
            this.listBox3.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Items.AddRange(new object[] {
            "Last 7 Days",
            "Last 30 Days"});
            this.listBox2.Location = new System.Drawing.Point(33, 222);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 36);
            this.listBox2.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Completed"});
            this.listBox1.Location = new System.Drawing.Point(15, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 36);
            this.listBox1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(102, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "Done";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filter : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(494, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 507);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Resolved Actions: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Action Result :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Welcome to customer Service !";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(881, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 507);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.MediumPurple;
            this.button6.Location = new System.Drawing.Point(37, 421);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 47);
            this.button6.TabIndex = 10;
            this.button6.Text = "Complete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.MediumPurple;
            this.button11.Location = new System.Drawing.Point(37, 363);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 47);
            this.button11.TabIndex = 9;
            this.button11.Text = "Complaint";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.MediumPurple;
            this.button10.Location = new System.Drawing.Point(37, 301);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 47);
            this.button10.TabIndex = 8;
            this.button10.Text = "Pending";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.MediumPurple;
            this.button9.Location = new System.Drawing.Point(37, 242);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 47);
            this.button9.TabIndex = 7;
            this.button9.Text = "Repair";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.MediumPurple;
            this.button8.Location = new System.Drawing.Point(37, 180);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 47);
            this.button8.TabIndex = 6;
            this.button8.Text = "Return";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.MediumPurple;
            this.button7.Location = new System.Drawing.Point(37, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 47);
            this.button7.TabIndex = 5;
            this.button7.Text = "Refund";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(69, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 32);
            this.label21.TabIndex = 0;
            this.label21.Text = "Action Panel ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "After-Service Management";
            // 
            // Support
            // 
            this.Support.Controls.Add(this.button3);
            this.Support.Controls.Add(this.button2);
            this.Support.Controls.Add(this.button1);
            this.Support.Controls.Add(this.label2);
            this.Support.Location = new System.Drawing.Point(269, 657);
            this.Support.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Support.Name = "Support";
            this.Support.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Support.Size = new System.Drawing.Size(906, 62);
            this.Support.TabIndex = 8;
            this.Support.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(568, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Light/ Dark Mode";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(351, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Feedback";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Support";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Version 1.0.2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox2.Location = new System.Drawing.Point(1007, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 42);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Overview
            // 
            this.Overview.BackColor = System.Drawing.Color.MediumPurple;
            this.Overview.ForeColor = System.Drawing.Color.White;
            this.Overview.Image = ((System.Drawing.Image)(resources.GetObject("Overview.Image")));
            this.Overview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(149, 36);
            this.Overview.Text = "Overview";
            this.Overview.Click += new System.EventHandler(this.Overview_Click);
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.MediumPurple;
            this.Product.ForeColor = System.Drawing.Color.White;
            this.Product.Image = ((System.Drawing.Image)(resources.GetObject("Product.Image")));
            this.Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(149, 36);
            this.Product.Text = "Products";
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.MediumPurple;
            this.Orders.ForeColor = System.Drawing.Color.White;
            this.Orders.Image = ((System.Drawing.Image)(resources.GetObject("Orders.Image")));
            this.Orders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(149, 36);
            this.Orders.Text = "Orders";
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.MediumPurple;
            this.Reports.ForeColor = System.Drawing.Color.White;
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(149, 36);
            this.Reports.Text = "Reports";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.MediumPurple;
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(149, 36);
            this.Settings.Text = "Settings";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.MediumPurple;
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(149, 36);
            this.LogOut.Text = "LogOut";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1241, 729);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Menu2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Support.ResumeLayout(false);
            this.Support.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox Menu2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label21;
        private new System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton Overview;
        private System.Windows.Forms.ToolStripButton Product;
        private System.Windows.Forms.ToolStripButton Orders;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox Support;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}