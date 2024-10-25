namespace WMS
{
    partial class ASNForm
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
            this.label31 = new System.Windows.Forms.Label();
            this.date_ASN_arrival = new System.Windows.Forms.DateTimePicker();
            this.label93 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_vehicle_ID = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_dock_ID = new System.Windows.Forms.ComboBox();
            this.cb_warehouse_ID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_comp_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Btn_Asn_Updte = new System.Windows.Forms.Button();
            this.txt_ASN_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_GoBack = new System.Windows.Forms.Button();
            this.Btn_Asn_Add = new System.Windows.Forms.Button();
            this.Btn_Asn_Delete = new System.Windows.Forms.Button();
            this.Btn_Asn_View = new System.Windows.Forms.Button();
            this.cb_asn_status = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_storage_days = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_generateBillID = new System.Windows.Forms.Button();
            this.txt_billID = new System.Windows.Forms.TextBox();
            this.cb_product_ID = new System.Windows.Forms.ComboBox();
            this.Btn_product_Update = new System.Windows.Forms.Button();
            this.Btn_product_DELETE = new System.Windows.Forms.Button();
            this.Btn_product_ADD = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.grid_product_bill = new System.Windows.Forms.DataGridView();
            this.txt_product_Bill_Extra_Charges = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.Btn_product_VIEW = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.txt_product_quantity = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPrintInvoice = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(336, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 23);
            this.label31.TabIndex = 181;
            this.label31.Text = "ASN Status:";
            // 
            // date_ASN_arrival
            // 
            this.date_ASN_arrival.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ASN_arrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ASN_arrival.Location = new System.Drawing.Point(151, 71);
            this.date_ASN_arrival.Name = "date_ASN_arrival";
            this.date_ASN_arrival.Size = new System.Drawing.Size(126, 27);
            this.date_ASN_arrival.TabIndex = 180;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ForeColor = System.Drawing.Color.White;
            this.label93.Location = new System.Drawing.Point(30, 70);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(115, 23);
            this.label93.TabIndex = 179;
            this.label93.Text = "Arrival Date: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_vehicle_ID);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(222, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 87);
            this.groupBox4.TabIndex = 178;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehicle Details: ";
            // 
            // cb_vehicle_ID
            // 
            this.cb_vehicle_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_vehicle_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_vehicle_ID.FormattingEnabled = true;
            this.cb_vehicle_ID.Location = new System.Drawing.Point(24, 50);
            this.cb_vehicle_ID.Name = "cb_vehicle_ID";
            this.cb_vehicle_ID.Size = new System.Drawing.Size(124, 27);
            this.cb_vehicle_ID.TabIndex = 221;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(20, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 23);
            this.label14.TabIndex = 146;
            this.label14.Text = "Vehicle Name: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_dock_ID);
            this.groupBox5.Controls.Add(this.cb_warehouse_ID);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(421, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 87);
            this.groupBox5.TabIndex = 177;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "WareHouse Details: ";
            // 
            // cb_dock_ID
            // 
            this.cb_dock_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_dock_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dock_ID.FormattingEnabled = true;
            this.cb_dock_ID.Location = new System.Drawing.Point(209, 50);
            this.cb_dock_ID.Name = "cb_dock_ID";
            this.cb_dock_ID.Size = new System.Drawing.Size(109, 27);
            this.cb_dock_ID.TabIndex = 223;
            // 
            // cb_warehouse_ID
            // 
            this.cb_warehouse_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_warehouse_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_warehouse_ID.FormattingEnabled = true;
            this.cb_warehouse_ID.Location = new System.Drawing.Point(24, 50);
            this.cb_warehouse_ID.Name = "cb_warehouse_ID";
            this.cb_warehouse_ID.Size = new System.Drawing.Size(156, 27);
            this.cb_warehouse_ID.TabIndex = 222;
            this.cb_warehouse_ID.SelectedIndexChanged += new System.EventHandler(this.Cb_warehouse_ID_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(205, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 23);
            this.label12.TabIndex = 139;
            this.label12.Text = "Dock Name: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(20, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 23);
            this.label21.TabIndex = 138;
            this.label21.Text = "Warehouse Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_comp_ID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 87);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Details: ";
            // 
            // cb_comp_ID
            // 
            this.cb_comp_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_comp_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_comp_ID.FormattingEnabled = true;
            this.cb_comp_ID.Location = new System.Drawing.Point(24, 50);
            this.cb_comp_ID.Name = "cb_comp_ID";
            this.cb_comp_ID.Size = new System.Drawing.Size(139, 27);
            this.cb_comp_ID.TabIndex = 220;
            this.cb_comp_ID.SelectedIndexChanged += new System.EventHandler(this.Cb_comp_ID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 138;
            this.label2.Text = "Company Name: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(598, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 173;
            this.label18.Text = "ASN No: ";
            // 
            // Btn_Asn_Updte
            // 
            this.Btn_Asn_Updte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Asn_Updte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asn_Updte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_Updte.FlatAppearance.BorderSize = 3;
            this.Btn_Asn_Updte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Asn_Updte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Asn_Updte.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asn_Updte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_Updte.Location = new System.Drawing.Point(801, 113);
            this.Btn_Asn_Updte.Name = "Btn_Asn_Updte";
            this.Btn_Asn_Updte.Size = new System.Drawing.Size(128, 60);
            this.Btn_Asn_Updte.TabIndex = 171;
            this.Btn_Asn_Updte.Text = "Update ASN";
            this.Btn_Asn_Updte.UseVisualStyleBackColor = false;
            this.Btn_Asn_Updte.Click += new System.EventHandler(this.Btn_Asn_Updte_Click);
            // 
            // txt_ASN_No
            // 
            this.txt_ASN_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ASN_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ASN_No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ASN_No.Location = new System.Drawing.Point(684, 74);
            this.txt_ASN_No.Name = "txt_ASN_No";
            this.txt_ASN_No.Size = new System.Drawing.Size(72, 20);
            this.txt_ASN_No.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(343, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 45);
            this.label3.TabIndex = 182;
            this.label3.Text = "Advanced Shipping Note";
            // 
            // Btn_GoBack
            // 
            this.Btn_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_GoBack.FlatAppearance.BorderSize = 3;
            this.Btn_GoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GoBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GoBack.ForeColor = System.Drawing.Color.White;
            this.Btn_GoBack.Location = new System.Drawing.Point(8, 6);
            this.Btn_GoBack.Name = "Btn_GoBack";
            this.Btn_GoBack.Size = new System.Drawing.Size(94, 45);
            this.Btn_GoBack.TabIndex = 216;
            this.Btn_GoBack.Text = "Go Back";
            this.Btn_GoBack.UseVisualStyleBackColor = true;
            this.Btn_GoBack.Click += new System.EventHandler(this.Btn_GoBack_Click);
            // 
            // Btn_Asn_Add
            // 
            this.Btn_Asn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Asn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_Add.FlatAppearance.BorderSize = 3;
            this.Btn_Asn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Asn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Asn_Add.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_Add.Location = new System.Drawing.Point(944, 41);
            this.Btn_Asn_Add.Name = "Btn_Asn_Add";
            this.Btn_Asn_Add.Size = new System.Drawing.Size(125, 60);
            this.Btn_Asn_Add.TabIndex = 217;
            this.Btn_Asn_Add.Text = "Add ASN";
            this.Btn_Asn_Add.UseVisualStyleBackColor = false;
            this.Btn_Asn_Add.Click += new System.EventHandler(this.Btn_Asn_Add_Click);
            // 
            // Btn_Asn_Delete
            // 
            this.Btn_Asn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Asn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_Delete.FlatAppearance.BorderSize = 3;
            this.Btn_Asn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Asn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Asn_Delete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_Delete.Location = new System.Drawing.Point(944, 113);
            this.Btn_Asn_Delete.Name = "Btn_Asn_Delete";
            this.Btn_Asn_Delete.Size = new System.Drawing.Size(125, 60);
            this.Btn_Asn_Delete.TabIndex = 219;
            this.Btn_Asn_Delete.Text = "Delete ASN";
            this.Btn_Asn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Asn_Delete.Click += new System.EventHandler(this.Btn_Asn_Delete_Click);
            // 
            // Btn_Asn_View
            // 
            this.Btn_Asn_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Asn_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asn_View.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_View.FlatAppearance.BorderSize = 3;
            this.Btn_Asn_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Asn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Asn_View.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asn_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Asn_View.Location = new System.Drawing.Point(801, 41);
            this.Btn_Asn_View.Name = "Btn_Asn_View";
            this.Btn_Asn_View.Size = new System.Drawing.Size(128, 60);
            this.Btn_Asn_View.TabIndex = 218;
            this.Btn_Asn_View.Text = "View ASN";
            this.Btn_Asn_View.UseVisualStyleBackColor = false;
            this.Btn_Asn_View.Click += new System.EventHandler(this.Btn_Asn_View_Click);
            // 
            // cb_asn_status
            // 
            this.cb_asn_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_asn_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_asn_status.FormattingEnabled = true;
            this.cb_asn_status.Location = new System.Drawing.Point(445, 71);
            this.cb_asn_status.Name = "cb_asn_status";
            this.cb_asn_status.Size = new System.Drawing.Size(109, 27);
            this.cb_asn_status.TabIndex = 223;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_storage_days);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Btn_generateBillID);
            this.groupBox3.Controls.Add(this.txt_billID);
            this.groupBox3.Controls.Add(this.cb_product_ID);
            this.groupBox3.Controls.Add(this.Btn_product_Update);
            this.groupBox3.Controls.Add(this.Btn_product_DELETE);
            this.groupBox3.Controls.Add(this.Btn_product_ADD);
            this.groupBox3.Controls.Add(this.label69);
            this.groupBox3.Controls.Add(this.grid_product_bill);
            this.groupBox3.Controls.Add(this.txt_product_Bill_Extra_Charges);
            this.groupBox3.Controls.Add(this.label62);
            this.groupBox3.Controls.Add(this.Btn_product_VIEW);
            this.groupBox3.Controls.Add(this.label51);
            this.groupBox3.Controls.Add(this.txt_product_quantity);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Location = new System.Drawing.Point(21, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1048, 382);
            this.groupBox3.TabIndex = 229;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Details: ";
            // 
            // txt_storage_days
            // 
            this.txt_storage_days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_storage_days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_storage_days.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storage_days.Location = new System.Drawing.Point(35, 298);
            this.txt_storage_days.Name = "txt_storage_days";
            this.txt_storage_days.Size = new System.Drawing.Size(167, 20);
            this.txt_storage_days.TabIndex = 232;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 231;
            this.label1.Text = "Total Storage Days:";
            // 
            // Btn_generateBillID
            // 
            this.Btn_generateBillID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_generateBillID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_generateBillID.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Btn_generateBillID.FlatAppearance.BorderSize = 3;
            this.Btn_generateBillID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_generateBillID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generateBillID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generateBillID.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_generateBillID.Location = new System.Drawing.Point(762, 19);
            this.Btn_generateBillID.Name = "Btn_generateBillID";
            this.Btn_generateBillID.Size = new System.Drawing.Size(166, 37);
            this.Btn_generateBillID.TabIndex = 230;
            this.Btn_generateBillID.Text = "Generate Bill ID";
            this.Btn_generateBillID.UseVisualStyleBackColor = false;
            this.Btn_generateBillID.Click += new System.EventHandler(this.Btn_generateBillID_Click);
            // 
            // txt_billID
            // 
            this.txt_billID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_billID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_billID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billID.Location = new System.Drawing.Point(934, 29);
            this.txt_billID.Name = "txt_billID";
            this.txt_billID.ReadOnly = true;
            this.txt_billID.Size = new System.Drawing.Size(79, 20);
            this.txt_billID.TabIndex = 230;
            // 
            // cb_product_ID
            // 
            this.cb_product_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_product_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_product_ID.FormattingEnabled = true;
            this.cb_product_ID.Location = new System.Drawing.Point(35, 97);
            this.cb_product_ID.Name = "cb_product_ID";
            this.cb_product_ID.Size = new System.Drawing.Size(167, 27);
            this.cb_product_ID.TabIndex = 223;
            // 
            // Btn_product_Update
            // 
            this.Btn_product_Update.BackColor = System.Drawing.Color.Yellow;
            this.Btn_product_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_product_Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_product_Update.FlatAppearance.BorderSize = 3;
            this.Btn_product_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_product_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_product_Update.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_product_Update.ForeColor = System.Drawing.Color.Black;
            this.Btn_product_Update.Location = new System.Drawing.Point(888, 214);
            this.Btn_product_Update.Name = "Btn_product_Update";
            this.Btn_product_Update.Size = new System.Drawing.Size(125, 42);
            this.Btn_product_Update.TabIndex = 169;
            this.Btn_product_Update.Text = "Update";
            this.Btn_product_Update.UseVisualStyleBackColor = false;
            this.Btn_product_Update.Click += new System.EventHandler(this.Btn_product_Update_Click);
            // 
            // Btn_product_DELETE
            // 
            this.Btn_product_DELETE.BackColor = System.Drawing.Color.Yellow;
            this.Btn_product_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_product_DELETE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_product_DELETE.FlatAppearance.BorderSize = 3;
            this.Btn_product_DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_product_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_product_DELETE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_product_DELETE.ForeColor = System.Drawing.Color.Black;
            this.Btn_product_DELETE.Location = new System.Drawing.Point(888, 262);
            this.Btn_product_DELETE.Name = "Btn_product_DELETE";
            this.Btn_product_DELETE.Size = new System.Drawing.Size(125, 42);
            this.Btn_product_DELETE.TabIndex = 168;
            this.Btn_product_DELETE.Text = "Delete";
            this.Btn_product_DELETE.UseVisualStyleBackColor = false;
            this.Btn_product_DELETE.Click += new System.EventHandler(this.Btn_product_DELETE_Click);
            // 
            // Btn_product_ADD
            // 
            this.Btn_product_ADD.BackColor = System.Drawing.Color.Yellow;
            this.Btn_product_ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_product_ADD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_product_ADD.FlatAppearance.BorderSize = 3;
            this.Btn_product_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_product_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_product_ADD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_product_ADD.ForeColor = System.Drawing.Color.Black;
            this.Btn_product_ADD.Location = new System.Drawing.Point(888, 118);
            this.Btn_product_ADD.Name = "Btn_product_ADD";
            this.Btn_product_ADD.Size = new System.Drawing.Size(125, 42);
            this.Btn_product_ADD.TabIndex = 167;
            this.Btn_product_ADD.Text = "Add";
            this.Btn_product_ADD.UseVisualStyleBackColor = false;
            this.Btn_product_ADD.Click += new System.EventHandler(this.Btn_product_ADD_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(436, 33);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(198, 23);
            this.label69.TabIndex = 166;
            this.label69.Text = "Arrival Products Details";
            // 
            // grid_product_bill
            // 
            this.grid_product_bill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grid_product_bill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_product_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_product_bill.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grid_product_bill.Location = new System.Drawing.Point(222, 78);
            this.grid_product_bill.Name = "grid_product_bill";
            this.grid_product_bill.Size = new System.Drawing.Size(609, 268);
            this.grid_product_bill.TabIndex = 165;
            // 
            // txt_product_Bill_Extra_Charges
            // 
            this.txt_product_Bill_Extra_Charges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_product_Bill_Extra_Charges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_Bill_Extra_Charges.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_Bill_Extra_Charges.Location = new System.Drawing.Point(35, 234);
            this.txt_product_Bill_Extra_Charges.Name = "txt_product_Bill_Extra_Charges";
            this.txt_product_Bill_Extra_Charges.Size = new System.Drawing.Size(167, 20);
            this.txt_product_Bill_Extra_Charges.TabIndex = 148;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(31, 208);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(118, 23);
            this.label62.TabIndex = 147;
            this.label62.Text = "Extra Charges";
            // 
            // Btn_product_VIEW
            // 
            this.Btn_product_VIEW.BackColor = System.Drawing.Color.Yellow;
            this.Btn_product_VIEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_product_VIEW.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_product_VIEW.FlatAppearance.BorderSize = 3;
            this.Btn_product_VIEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_product_VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_product_VIEW.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_product_VIEW.ForeColor = System.Drawing.Color.Black;
            this.Btn_product_VIEW.Location = new System.Drawing.Point(888, 166);
            this.Btn_product_VIEW.Name = "Btn_product_VIEW";
            this.Btn_product_VIEW.Size = new System.Drawing.Size(125, 42);
            this.Btn_product_VIEW.TabIndex = 111;
            this.Btn_product_VIEW.Text = "View";
            this.Btn_product_VIEW.UseVisualStyleBackColor = false;
            this.Btn_product_VIEW.Click += new System.EventHandler(this.Btn_product_VIEW_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(31, 143);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(88, 23);
            this.label51.TabIndex = 144;
            this.label51.Text = "Quantity: ";
            // 
            // txt_product_quantity
            // 
            this.txt_product_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_product_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_quantity.Location = new System.Drawing.Point(35, 169);
            this.txt_product_quantity.Name = "txt_product_quantity";
            this.txt_product_quantity.Size = new System.Drawing.Size(167, 20);
            this.txt_product_quantity.TabIndex = 143;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(31, 65);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(132, 23);
            this.label44.TabIndex = 146;
            this.label44.Text = "Product Name: ";
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
            this.button1.Location = new System.Drawing.Point(341, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 10);
            this.button1.TabIndex = 230;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnPrintInvoice
            // 
            this.BtnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnPrintInvoice.FlatAppearance.BorderSize = 3;
            this.BtnPrintInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintInvoice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnPrintInvoice.Location = new System.Drawing.Point(801, 179);
            this.BtnPrintInvoice.Name = "BtnPrintInvoice";
            this.BtnPrintInvoice.Size = new System.Drawing.Size(268, 42);
            this.BtnPrintInvoice.TabIndex = 231;
            this.BtnPrintInvoice.Text = "Print Invoice";
            this.BtnPrintInvoice.UseVisualStyleBackColor = false;
            this.BtnPrintInvoice.Click += new System.EventHandler(this.BtnPrintInvoice_Click);
            // 
            // ASNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1094, 629);
            this.Controls.Add(this.BtnPrintInvoice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_asn_status);
            this.Controls.Add(this.Btn_Asn_Delete);
            this.Controls.Add(this.Btn_Asn_View);
            this.Controls.Add(this.Btn_Asn_Add);
            this.Controls.Add(this.Btn_GoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.date_ASN_arrival);
            this.Controls.Add(this.label93);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_ASN_No);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Btn_Asn_Updte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASNForm";
            this.Load += new System.EventHandler(this.ASNForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker date_ASN_arrival;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Btn_Asn_Updte;
        private System.Windows.Forms.TextBox txt_ASN_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_GoBack;
        private System.Windows.Forms.Button Btn_Asn_Add;
        private System.Windows.Forms.Button Btn_Asn_Delete;
        private System.Windows.Forms.Button Btn_Asn_View;
        private System.Windows.Forms.ComboBox cb_vehicle_ID;
        private System.Windows.Forms.ComboBox cb_dock_ID;
        private System.Windows.Forms.ComboBox cb_warehouse_ID;
        private System.Windows.Forms.ComboBox cb_comp_ID;
        private System.Windows.Forms.ComboBox cb_asn_status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_product_ID;
        private System.Windows.Forms.Button Btn_product_Update;
        private System.Windows.Forms.Button Btn_product_DELETE;
        private System.Windows.Forms.Button Btn_product_ADD;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.DataGridView grid_product_bill;
        private System.Windows.Forms.TextBox txt_product_Bill_Extra_Charges;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button Btn_product_VIEW;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txt_product_quantity;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button Btn_generateBillID;
        private System.Windows.Forms.TextBox txt_billID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_storage_days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPrintInvoice;
    }
}