namespace WMS
{
    partial class OPNForm
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
            this.Date_OPN = new System.Windows.Forms.DateTimePicker();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cb_vehicle_ID = new System.Windows.Forms.ComboBox();
            this.label76 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btn_generateOrder_ID = new System.Windows.Forms.Button();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.cb_product_ID = new System.Windows.Forms.ComboBox();
            this.btn_Update_order = new System.Windows.Forms.Button();
            this.btn_Delete_order = new System.Windows.Forms.Button();
            this.btn_add_order = new System.Windows.Forms.Button();
            this.label83 = new System.Windows.Forms.Label();
            this.grid_View_OPN_Order = new System.Windows.Forms.DataGridView();
            this.txt_extraCharges = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.btn_View_order = new System.Windows.Forms.Button();
            this.label86 = new System.Windows.Forms.Label();
            this.txt_product_quantity = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.cb_dock_ID = new System.Windows.Forms.ComboBox();
            this.cb_warehouse_ID = new System.Windows.Forms.ComboBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cb_company_ID = new System.Windows.Forms.ComboBox();
            this.label90 = new System.Windows.Forms.Label();
            this.txt_OPN_ID = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_OPN_Delete = new System.Windows.Forms.Button();
            this.btn_OPN_View = new System.Windows.Forms.Button();
            this.btn_OPN_Add = new System.Windows.Forms.Button();
            this.btn_OPN_Updte = new System.Windows.Forms.Button();
            this.cb_OPN_Status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_OPN_Order)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date_OPN
            // 
            this.Date_OPN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_OPN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_OPN.Location = new System.Drawing.Point(157, 73);
            this.Date_OPN.Name = "Date_OPN";
            this.Date_OPN.Size = new System.Drawing.Size(121, 27);
            this.Date_OPN.TabIndex = 188;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(20, 77);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(143, 23);
            this.label79.TabIndex = 187;
            this.label79.Text = "Departure Date: ";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(317, 77);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(105, 23);
            this.label78.TabIndex = 186;
            this.label78.Text = "OPN Status:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cb_vehicle_ID);
            this.groupBox13.Controls.Add(this.label76);
            this.groupBox13.Location = new System.Drawing.Point(246, 117);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(161, 87);
            this.groupBox13.TabIndex = 184;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Vehicle Details: ";
            // 
            // cb_vehicle_ID
            // 
            this.cb_vehicle_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_vehicle_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_vehicle_ID.FormattingEnabled = true;
            this.cb_vehicle_ID.Location = new System.Drawing.Point(19, 49);
            this.cb_vehicle_ID.Name = "cb_vehicle_ID";
            this.cb_vehicle_ID.Size = new System.Drawing.Size(124, 27);
            this.cb_vehicle_ID.TabIndex = 235;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(15, 23);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(128, 23);
            this.label76.TabIndex = 146;
            this.label76.Text = "Vehicle Name: ";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btn_generateOrder_ID);
            this.groupBox14.Controls.Add(this.txt_OrderID);
            this.groupBox14.Controls.Add(this.cb_product_ID);
            this.groupBox14.Controls.Add(this.btn_Update_order);
            this.groupBox14.Controls.Add(this.btn_Delete_order);
            this.groupBox14.Controls.Add(this.btn_add_order);
            this.groupBox14.Controls.Add(this.label83);
            this.groupBox14.Controls.Add(this.grid_View_OPN_Order);
            this.groupBox14.Controls.Add(this.txt_extraCharges);
            this.groupBox14.Controls.Add(this.label84);
            this.groupBox14.Controls.Add(this.btn_View_order);
            this.groupBox14.Controls.Add(this.label86);
            this.groupBox14.Controls.Add(this.txt_product_quantity);
            this.groupBox14.Controls.Add(this.label87);
            this.groupBox14.Location = new System.Drawing.Point(24, 226);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1046, 379);
            this.groupBox14.TabIndex = 182;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Product Details: ";
            // 
            // btn_generateOrder_ID
            // 
            this.btn_generateOrder_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_generateOrder_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generateOrder_ID.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_generateOrder_ID.FlatAppearance.BorderSize = 3;
            this.btn_generateOrder_ID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_generateOrder_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateOrder_ID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateOrder_ID.ForeColor = System.Drawing.Color.Yellow;
            this.btn_generateOrder_ID.Location = new System.Drawing.Point(738, 19);
            this.btn_generateOrder_ID.Name = "btn_generateOrder_ID";
            this.btn_generateOrder_ID.Size = new System.Drawing.Size(171, 37);
            this.btn_generateOrder_ID.TabIndex = 231;
            this.btn_generateOrder_ID.Text = "Generate Order ID";
            this.btn_generateOrder_ID.UseVisualStyleBackColor = false;
            this.btn_generateOrder_ID.Click += new System.EventHandler(this.Btn_generateOrder_ID_Click);
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_OrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OrderID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OrderID.Location = new System.Drawing.Point(915, 31);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(72, 20);
            this.txt_OrderID.TabIndex = 232;
            // 
            // cb_product_ID
            // 
            this.cb_product_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_product_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_product_ID.FormattingEnabled = true;
            this.cb_product_ID.Location = new System.Drawing.Point(49, 87);
            this.cb_product_ID.Name = "cb_product_ID";
            this.cb_product_ID.Size = new System.Drawing.Size(109, 27);
            this.cb_product_ID.TabIndex = 224;
            // 
            // btn_Update_order
            // 
            this.btn_Update_order.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Update_order.FlatAppearance.BorderSize = 3;
            this.btn_Update_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_order.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_order.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_order.Location = new System.Drawing.Point(889, 206);
            this.btn_Update_order.Name = "btn_Update_order";
            this.btn_Update_order.Size = new System.Drawing.Size(122, 42);
            this.btn_Update_order.TabIndex = 169;
            this.btn_Update_order.Text = "Update";
            this.btn_Update_order.UseVisualStyleBackColor = false;
            this.btn_Update_order.Click += new System.EventHandler(this.Btn_Update_order_Click);
            // 
            // btn_Delete_order
            // 
            this.btn_Delete_order.BackColor = System.Drawing.Color.Yellow;
            this.btn_Delete_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_order.FlatAppearance.BorderSize = 3;
            this.btn_Delete_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_order.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_order.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete_order.Location = new System.Drawing.Point(889, 254);
            this.btn_Delete_order.Name = "btn_Delete_order";
            this.btn_Delete_order.Size = new System.Drawing.Size(122, 42);
            this.btn_Delete_order.TabIndex = 168;
            this.btn_Delete_order.Text = "Delete";
            this.btn_Delete_order.UseVisualStyleBackColor = false;
            this.btn_Delete_order.Click += new System.EventHandler(this.Btn_Delete_order_Click);
            // 
            // btn_add_order
            // 
            this.btn_add_order.BackColor = System.Drawing.Color.Yellow;
            this.btn_add_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add_order.FlatAppearance.BorderSize = 3;
            this.btn_add_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_order.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_order.ForeColor = System.Drawing.Color.Black;
            this.btn_add_order.Location = new System.Drawing.Point(889, 109);
            this.btn_add_order.Name = "btn_add_order";
            this.btn_add_order.Size = new System.Drawing.Size(122, 42);
            this.btn_add_order.TabIndex = 167;
            this.btn_add_order.Text = "Add";
            this.btn_add_order.UseVisualStyleBackColor = false;
            this.btn_add_order.Click += new System.EventHandler(this.Btn_add_order_Click);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.Color.White;
            this.label83.Location = new System.Drawing.Point(455, 33);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(203, 23);
            this.label83.TabIndex = 166;
            this.label83.Text = "Ordered Product Details";
            // 
            // grid_View_OPN_Order
            // 
            this.grid_View_OPN_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grid_View_OPN_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_OPN_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_View_OPN_Order.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grid_View_OPN_Order.Location = new System.Drawing.Point(222, 80);
            this.grid_View_OPN_Order.Name = "grid_View_OPN_Order";
            this.grid_View_OPN_Order.Size = new System.Drawing.Size(621, 260);
            this.grid_View_OPN_Order.TabIndex = 165;
            // 
            // txt_extraCharges
            // 
            this.txt_extraCharges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_extraCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_extraCharges.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_extraCharges.Location = new System.Drawing.Point(49, 214);
            this.txt_extraCharges.Name = "txt_extraCharges";
            this.txt_extraCharges.Size = new System.Drawing.Size(109, 20);
            this.txt_extraCharges.TabIndex = 148;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(45, 188);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(127, 23);
            this.label84.TabIndex = 147;
            this.label84.Text = "Extra Charges: ";
            // 
            // btn_View_order
            // 
            this.btn_View_order.BackColor = System.Drawing.Color.Yellow;
            this.btn_View_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_View_order.FlatAppearance.BorderSize = 3;
            this.btn_View_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_order.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_order.ForeColor = System.Drawing.Color.Black;
            this.btn_View_order.Location = new System.Drawing.Point(889, 158);
            this.btn_View_order.Name = "btn_View_order";
            this.btn_View_order.Size = new System.Drawing.Size(122, 42);
            this.btn_View_order.TabIndex = 111;
            this.btn_View_order.Text = "View";
            this.btn_View_order.UseVisualStyleBackColor = false;
            this.btn_View_order.Click += new System.EventHandler(this.Btn_View_order_Click);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(45, 123);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(88, 23);
            this.label86.TabIndex = 144;
            this.label86.Text = "Quantity: ";
            // 
            // txt_product_quantity
            // 
            this.txt_product_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_product_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_quantity.Location = new System.Drawing.Point(49, 149);
            this.txt_product_quantity.Name = "txt_product_quantity";
            this.txt_product_quantity.Size = new System.Drawing.Size(109, 20);
            this.txt_product_quantity.TabIndex = 143;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.Color.White;
            this.label87.Location = new System.Drawing.Point(45, 61);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(132, 23);
            this.label87.TabIndex = 146;
            this.label87.Text = "Product Name: ";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.cb_dock_ID);
            this.groupBox16.Controls.Add(this.cb_warehouse_ID);
            this.groupBox16.Controls.Add(this.label88);
            this.groupBox16.Controls.Add(this.label89);
            this.groupBox16.Location = new System.Drawing.Point(438, 117);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(339, 87);
            this.groupBox16.TabIndex = 183;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "WareHouse Details: ";
            // 
            // cb_dock_ID
            // 
            this.cb_dock_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_dock_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dock_ID.FormattingEnabled = true;
            this.cb_dock_ID.Location = new System.Drawing.Point(213, 49);
            this.cb_dock_ID.Name = "cb_dock_ID";
            this.cb_dock_ID.Size = new System.Drawing.Size(109, 27);
            this.cb_dock_ID.TabIndex = 237;
            // 
            // cb_warehouse_ID
            // 
            this.cb_warehouse_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_warehouse_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_warehouse_ID.FormattingEnabled = true;
            this.cb_warehouse_ID.Location = new System.Drawing.Point(16, 49);
            this.cb_warehouse_ID.Name = "cb_warehouse_ID";
            this.cb_warehouse_ID.Size = new System.Drawing.Size(156, 27);
            this.cb_warehouse_ID.TabIndex = 236;
            this.cb_warehouse_ID.SelectedIndexChanged += new System.EventHandler(this.Cb_warehouse_ID_SelectedIndexChanged_1);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Location = new System.Drawing.Point(209, 23);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(109, 23);
            this.label88.TabIndex = 139;
            this.label88.Text = "Dock Name: ";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(12, 23);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(160, 23);
            this.label89.TabIndex = 138;
            this.label89.Text = "Warehouse Name: ";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.cb_company_ID);
            this.groupBox17.Controls.Add(this.label90);
            this.groupBox17.Location = new System.Drawing.Point(24, 117);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(172, 87);
            this.groupBox17.TabIndex = 181;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Company Details: ";
            // 
            // cb_company_ID
            // 
            this.cb_company_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_company_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_company_ID.FormattingEnabled = true;
            this.cb_company_ID.Location = new System.Drawing.Point(22, 49);
            this.cb_company_ID.Name = "cb_company_ID";
            this.cb_company_ID.Size = new System.Drawing.Size(136, 27);
            this.cb_company_ID.TabIndex = 234;
            this.cb_company_ID.SelectedIndexChanged += new System.EventHandler(this.Cb_company_ID_SelectedIndexChanged);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.White;
            this.label90.Location = new System.Drawing.Point(18, 23);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(143, 23);
            this.label90.TabIndex = 138;
            this.label90.Text = "Company Name: ";
            // 
            // txt_OPN_ID
            // 
            this.txt_OPN_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_OPN_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OPN_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OPN_ID.Location = new System.Drawing.Point(678, 76);
            this.txt_OPN_ID.Name = "txt_OPN_ID";
            this.txt_OPN_ID.Size = new System.Drawing.Size(99, 20);
            this.txt_OPN_ID.TabIndex = 179;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.Color.White;
            this.label91.Location = new System.Drawing.Point(590, 76);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(82, 23);
            this.label91.TabIndex = 180;
            this.label91.Text = "OPN No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(348, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 45);
            this.label3.TabIndex = 189;
            this.label3.Text = "Order Processing Note";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_GoBack.FlatAppearance.BorderSize = 3;
            this.btn_GoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.White;
            this.btn_GoBack.Location = new System.Drawing.Point(12, 6);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(94, 45);
            this.btn_GoBack.TabIndex = 216;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.Btn_GoBack_Click);
            // 
            // btn_OPN_Delete
            // 
            this.btn_OPN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_OPN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OPN_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_Delete.FlatAppearance.BorderSize = 3;
            this.btn_OPN_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OPN_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_OPN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OPN_Delete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OPN_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_Delete.Location = new System.Drawing.Point(939, 108);
            this.btn_OPN_Delete.Name = "btn_OPN_Delete";
            this.btn_OPN_Delete.Size = new System.Drawing.Size(124, 60);
            this.btn_OPN_Delete.TabIndex = 223;
            this.btn_OPN_Delete.Text = "Delete OPN";
            this.btn_OPN_Delete.UseVisualStyleBackColor = false;
            this.btn_OPN_Delete.Click += new System.EventHandler(this.Btn_OPN_Delete_Click);
            // 
            // btn_OPN_View
            // 
            this.btn_OPN_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_OPN_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OPN_View.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_View.FlatAppearance.BorderSize = 3;
            this.btn_OPN_View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OPN_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_OPN_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OPN_View.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OPN_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_View.Location = new System.Drawing.Point(803, 36);
            this.btn_OPN_View.Name = "btn_OPN_View";
            this.btn_OPN_View.Size = new System.Drawing.Size(124, 60);
            this.btn_OPN_View.TabIndex = 222;
            this.btn_OPN_View.Text = "View OPN";
            this.btn_OPN_View.UseVisualStyleBackColor = false;
            this.btn_OPN_View.Click += new System.EventHandler(this.Btn_OPN_View_Click);
            // 
            // btn_OPN_Add
            // 
            this.btn_OPN_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_OPN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OPN_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_Add.FlatAppearance.BorderSize = 3;
            this.btn_OPN_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OPN_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_OPN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OPN_Add.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OPN_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_Add.Location = new System.Drawing.Point(939, 36);
            this.btn_OPN_Add.Name = "btn_OPN_Add";
            this.btn_OPN_Add.Size = new System.Drawing.Size(124, 60);
            this.btn_OPN_Add.TabIndex = 221;
            this.btn_OPN_Add.Text = "Add OPN";
            this.btn_OPN_Add.UseVisualStyleBackColor = false;
            this.btn_OPN_Add.Click += new System.EventHandler(this.Btn_OPN_Add_Click);
            // 
            // btn_OPN_Updte
            // 
            this.btn_OPN_Updte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_OPN_Updte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OPN_Updte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_Updte.FlatAppearance.BorderSize = 3;
            this.btn_OPN_Updte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OPN_Updte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_OPN_Updte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OPN_Updte.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OPN_Updte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OPN_Updte.Location = new System.Drawing.Point(803, 108);
            this.btn_OPN_Updte.Name = "btn_OPN_Updte";
            this.btn_OPN_Updte.Size = new System.Drawing.Size(124, 60);
            this.btn_OPN_Updte.TabIndex = 220;
            this.btn_OPN_Updte.Text = "Update OPN";
            this.btn_OPN_Updte.UseVisualStyleBackColor = false;
            this.btn_OPN_Updte.Click += new System.EventHandler(this.Btn_OPN_Updte_Click);
            // 
            // cb_OPN_Status
            // 
            this.cb_OPN_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_OPN_Status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_OPN_Status.FormattingEnabled = true;
            this.cb_OPN_Status.Location = new System.Drawing.Point(428, 73);
            this.cb_OPN_Status.Name = "cb_OPN_Status";
            this.cb_OPN_Status.Size = new System.Drawing.Size(109, 27);
            this.cb_OPN_Status.TabIndex = 233;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(333, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 10);
            this.button1.TabIndex = 234;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrintInvoice.FlatAppearance.BorderSize = 3;
            this.btnPrintInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrintInvoice.Location = new System.Drawing.Point(802, 178);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(261, 42);
            this.btnPrintInvoice.TabIndex = 235;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.BtnPrintInvoice_Click_1);
            // 
            // OPNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1094, 626);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_OPN_Status);
            this.Controls.Add(this.btn_OPN_Delete);
            this.Controls.Add(this.btn_OPN_View);
            this.Controls.Add(this.btn_OPN_Add);
            this.Controls.Add(this.btn_OPN_Updte);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date_OPN);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.txt_OPN_ID);
            this.Controls.Add(this.label91);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OPNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPNForm";
            this.Load += new System.EventHandler(this.OPNForm_Load);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_OPN_Order)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date_OPN;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button btn_Update_order;
        private System.Windows.Forms.Button btn_Delete_order;
        private System.Windows.Forms.Button btn_add_order;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.DataGridView grid_View_OPN_Order;
        private System.Windows.Forms.TextBox txt_extraCharges;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button btn_View_order;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox txt_product_quantity;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox txt_OPN_ID;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_OPN_Delete;
        private System.Windows.Forms.Button btn_OPN_View;
        private System.Windows.Forms.Button btn_OPN_Add;
        private System.Windows.Forms.Button btn_OPN_Updte;
        private System.Windows.Forms.ComboBox cb_product_ID;
        private System.Windows.Forms.Button btn_generateOrder_ID;
        private System.Windows.Forms.TextBox txt_OrderID;
        private System.Windows.Forms.ComboBox cb_OPN_Status;
        private System.Windows.Forms.ComboBox cb_vehicle_ID;
        private System.Windows.Forms.ComboBox cb_dock_ID;
        private System.Windows.Forms.ComboBox cb_warehouse_ID;
        private System.Windows.Forms.ComboBox cb_company_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrintInvoice;
    }
}