namespace WMS
{
    partial class O_P_Manager
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
            System.Windows.Forms.TabPage tab_overall;
            this.label9 = new System.Windows.Forms.Label();
            this.grid_View_orders = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_particular_order = new System.Windows.Forms.TabPage();
            this.grid_View_OPN_Mnager = new System.Windows.Forms.DataGridView();
            this.txt_OPN_date = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Dock_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_company_ID = new System.Windows.Forms.TextBox();
            this.txt_Company_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Vehicle_ID = new System.Windows.Forms.TextBox();
            this.btn_Successfully_Load = new System.Windows.Forms.Button();
            this.txt_warehouse_ID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_OPN_ID = new System.Windows.Forms.TextBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            tab_overall = new System.Windows.Forms.TabPage();
            tab_overall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_orders)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_particular_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_OPN_Mnager)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_overall
            // 
            tab_overall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            tab_overall.Controls.Add(this.label9);
            tab_overall.Controls.Add(this.grid_View_orders);
            tab_overall.ForeColor = System.Drawing.Color.IndianRed;
            tab_overall.Location = new System.Drawing.Point(4, 24);
            tab_overall.Name = "tab_overall";
            tab_overall.Padding = new System.Windows.Forms.Padding(3);
            tab_overall.Size = new System.Drawing.Size(951, 476);
            tab_overall.TabIndex = 0;
            tab_overall.Text = "Overall Orders Report";
            tab_overall.Click += new System.EventHandler(this.Tab_overall_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(380, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "All Departure Shipments";
            // 
            // grid_View_orders
            // 
            this.grid_View_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_View_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column5,
            this.TruckNo,
            this.Column1,
            this.Column3});
            this.grid_View_orders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grid_View_orders.Location = new System.Drawing.Point(169, 62);
            this.grid_View_orders.Name = "grid_View_orders";
            this.grid_View_orders.Size = new System.Drawing.Size(643, 353);
            this.grid_View_orders.TabIndex = 26;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "OPN No";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Warehouse No";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dock No";
            this.Column5.Name = "Column5";
            // 
            // TruckNo
            // 
            this.TruckNo.HeaderText = "Truck No";
            this.TruckNo.Name = "TruckNo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Departure Date";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company Name";
            this.Column3.Name = "Column3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(353, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(251, 45);
            this.label20.TabIndex = 17;
            this.label20.Text = "O N P Manager";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tab_overall);
            this.tabControl1.Controls.Add(this.tab_particular_order);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 20);
            this.tabControl1.Location = new System.Drawing.Point(12, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(147, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 504);
            this.tabControl1.TabIndex = 16;
            // 
            // tab_particular_order
            // 
            this.tab_particular_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.tab_particular_order.Controls.Add(this.grid_View_OPN_Mnager);
            this.tab_particular_order.Controls.Add(this.txt_OPN_date);
            this.tab_particular_order.Controls.Add(this.label11);
            this.tab_particular_order.Controls.Add(this.txt_Dock_ID);
            this.tab_particular_order.Controls.Add(this.label12);
            this.tab_particular_order.Controls.Add(this.label13);
            this.tab_particular_order.Controls.Add(this.txt_company_ID);
            this.tab_particular_order.Controls.Add(this.txt_Company_name);
            this.tab_particular_order.Controls.Add(this.label14);
            this.tab_particular_order.Controls.Add(this.label15);
            this.tab_particular_order.Controls.Add(this.txt_Vehicle_ID);
            this.tab_particular_order.Controls.Add(this.btn_Successfully_Load);
            this.tab_particular_order.Controls.Add(this.txt_warehouse_ID);
            this.tab_particular_order.Controls.Add(this.label17);
            this.tab_particular_order.Controls.Add(this.label18);
            this.tab_particular_order.Controls.Add(this.txt_OPN_ID);
            this.tab_particular_order.Controls.Add(this.btn_View);
            this.tab_particular_order.Location = new System.Drawing.Point(4, 24);
            this.tab_particular_order.Name = "tab_particular_order";
            this.tab_particular_order.Padding = new System.Windows.Forms.Padding(3);
            this.tab_particular_order.Size = new System.Drawing.Size(951, 476);
            this.tab_particular_order.TabIndex = 1;
            this.tab_particular_order.Text = "Particular Order Departure Details";
            this.tab_particular_order.Click += new System.EventHandler(this.Tab_particular_order_Click);
            // 
            // grid_View_OPN_Mnager
            // 
            this.grid_View_OPN_Mnager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_View_OPN_Mnager.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_OPN_Mnager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_View_OPN_Mnager.EnableHeadersVisualStyles = false;
            this.grid_View_OPN_Mnager.Location = new System.Drawing.Point(17, 59);
            this.grid_View_OPN_Mnager.Name = "grid_View_OPN_Mnager";
            this.grid_View_OPN_Mnager.Size = new System.Drawing.Size(919, 245);
            this.grid_View_OPN_Mnager.TabIndex = 57;
            // 
            // txt_OPN_date
            // 
            this.txt_OPN_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_OPN_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OPN_date.Location = new System.Drawing.Point(735, 367);
            this.txt_OPN_date.Name = "txt_OPN_date";
            this.txt_OPN_date.Size = new System.Drawing.Size(135, 20);
            this.txt_OPN_date.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(597, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "Departure Date: ";
            // 
            // txt_Dock_ID
            // 
            this.txt_Dock_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Dock_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dock_ID.Location = new System.Drawing.Point(447, 334);
            this.txt_Dock_ID.Name = "txt_Dock_ID";
            this.txt_Dock_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_Dock_ID.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(356, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "Dock No: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(332, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Company ID:";
            // 
            // txt_company_ID
            // 
            this.txt_company_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_company_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_company_ID.Location = new System.Drawing.Point(447, 367);
            this.txt_company_ID.Name = "txt_company_ID";
            this.txt_company_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_company_ID.TabIndex = 50;
            // 
            // txt_Company_name
            // 
            this.txt_Company_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Company_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Company_name.Location = new System.Drawing.Point(735, 331);
            this.txt_Company_name.Name = "txt_Company_name";
            this.txt_Company_name.Size = new System.Drawing.Size(135, 20);
            this.txt_Company_name.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(597, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 23);
            this.label14.TabIndex = 48;
            this.label14.Text = "Company Name: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(79, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "Vehicle No: ";
            // 
            // txt_Vehicle_ID
            // 
            this.txt_Vehicle_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Vehicle_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Vehicle_ID.Location = new System.Drawing.Point(189, 367);
            this.txt_Vehicle_ID.Name = "txt_Vehicle_ID";
            this.txt_Vehicle_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_Vehicle_ID.TabIndex = 46;
            // 
            // btn_Successfully_Load
            // 
            this.btn_Successfully_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Successfully_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Successfully_Load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Successfully_Load.FlatAppearance.BorderSize = 3;
            this.btn_Successfully_Load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Successfully_Load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Successfully_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Successfully_Load.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Successfully_Load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Successfully_Load.Location = new System.Drawing.Point(754, 405);
            this.btn_Successfully_Load.Name = "btn_Successfully_Load";
            this.btn_Successfully_Load.Size = new System.Drawing.Size(182, 54);
            this.btn_Successfully_Load.TabIndex = 45;
            this.btn_Successfully_Load.Text = "Successfully Load\r\n";
            this.btn_Successfully_Load.UseVisualStyleBackColor = false;
            this.btn_Successfully_Load.Click += new System.EventHandler(this.Btn_Successfully_Load_Click);
            // 
            // txt_warehouse_ID
            // 
            this.txt_warehouse_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_warehouse_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_warehouse_ID.Location = new System.Drawing.Point(189, 337);
            this.txt_warehouse_ID.Name = "txt_warehouse_ID";
            this.txt_warehouse_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_warehouse_ID.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(58, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 23);
            this.label17.TabIndex = 42;
            this.label17.Text = "Warehouse No: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(624, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 23);
            this.label18.TabIndex = 41;
            this.label18.Text = "OPN No: ";
            // 
            // txt_OPN_ID
            // 
            this.txt_OPN_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_OPN_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OPN_ID.Location = new System.Drawing.Point(704, 24);
            this.txt_OPN_ID.Name = "txt_OPN_ID";
            this.txt_OPN_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_OPN_ID.TabIndex = 39;
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.Yellow;
            this.btn_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_View.FlatAppearance.BorderSize = 3;
            this.btn_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(845, 12);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(91, 41);
            this.btn_View.TabIndex = 40;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.BorderSize = 3;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(847, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 45);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // O_P_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(989, 579);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "O_P_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O_P_Manager";
            this.Load += new System.EventHandler(this.O_P_Manager_Load);
            tab_overall.ResumeLayout(false);
            tab_overall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_orders)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_particular_order.ResumeLayout(false);
            this.tab_particular_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_OPN_Mnager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grid_View_orders;
        private System.Windows.Forms.TabPage tab_particular_order;
        private System.Windows.Forms.DataGridView grid_View_OPN_Mnager;
        private System.Windows.Forms.TextBox txt_OPN_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Dock_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_company_ID;
        private System.Windows.Forms.TextBox txt_Company_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Vehicle_ID;
        private System.Windows.Forms.Button btn_Successfully_Load;
        private System.Windows.Forms.TextBox txt_warehouse_ID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_OPN_ID;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_logout;
    }
}