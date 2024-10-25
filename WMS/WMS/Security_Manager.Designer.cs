namespace WMS
{
    partial class Security_Manager
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
            System.Windows.Forms.TabPage tabPage_Security_arrival;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Security_Manager));
            this.btn_clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_shipmentID = new System.Windows.Forms.TextBox();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_VehicleType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DriverCNIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ArrivingDate = new System.Windows.Forms.TextBox();
            this.grid_view_arrival_shipments = new System.Windows.Forms.DataGridView();
            this.btn_genertate_Gate_Pass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DriverName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vehicleNo = new System.Windows.Forms.TextBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Security_departure = new System.Windows.Forms.TabPage();
            this.btn_clear_order = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.grid_view_departure = new System.Windows.Forms.DataGridView();
            this.txt_company_name = new System.Windows.Forms.TextBox();
            this.txt_Vehcile_type = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_driver_CNIC = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_departure_Date = new System.Windows.Forms.TextBox();
            this.btn_generate_gate_pass_departure = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_driver_name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Vehicle_ID = new System.Windows.Forms.TextBox();
            this.btn_ORder_View = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            tabPage_Security_arrival = new System.Windows.Forms.TabPage();
            tabPage_Security_arrival.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_arrival_shipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Security_departure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_departure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_Security_arrival
            // 
            tabPage_Security_arrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            tabPage_Security_arrival.Controls.Add(this.btn_clear);
            tabPage_Security_arrival.Controls.Add(this.label10);
            tabPage_Security_arrival.Controls.Add(this.txt_shipmentID);
            tabPage_Security_arrival.Controls.Add(this.txt_Company);
            tabPage_Security_arrival.Controls.Add(this.label9);
            tabPage_Security_arrival.Controls.Add(this.txt_VehicleType);
            tabPage_Security_arrival.Controls.Add(this.label7);
            tabPage_Security_arrival.Controls.Add(this.label8);
            tabPage_Security_arrival.Controls.Add(this.txt_DriverCNIC);
            tabPage_Security_arrival.Controls.Add(this.label6);
            tabPage_Security_arrival.Controls.Add(this.txt_ArrivingDate);
            tabPage_Security_arrival.Controls.Add(this.grid_view_arrival_shipments);
            tabPage_Security_arrival.Controls.Add(this.btn_genertate_Gate_Pass);
            tabPage_Security_arrival.Controls.Add(this.label4);
            tabPage_Security_arrival.Controls.Add(this.txt_DriverName);
            tabPage_Security_arrival.Controls.Add(this.label3);
            tabPage_Security_arrival.Controls.Add(this.label2);
            tabPage_Security_arrival.Controls.Add(this.txt_vehicleNo);
            tabPage_Security_arrival.Controls.Add(this.btn_View);
            tabPage_Security_arrival.Controls.Add(this.pictureBox1);
            tabPage_Security_arrival.ForeColor = System.Drawing.Color.IndianRed;
            tabPage_Security_arrival.Location = new System.Drawing.Point(4, 24);
            tabPage_Security_arrival.Name = "tabPage_Security_arrival";
            tabPage_Security_arrival.Padding = new System.Windows.Forms.Padding(3);
            tabPage_Security_arrival.Size = new System.Drawing.Size(940, 530);
            tabPage_Security_arrival.TabIndex = 0;
            tabPage_Security_arrival.Text = "Arrival Shipments";
            tabPage_Security_arrival.Click += new System.EventHandler(this.TabPage_Security_arrival_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.BorderSize = 3;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(593, 354);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 41);
            this.btn_clear.TabIndex = 42;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(534, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "Shipment No: ";
            // 
            // txt_shipmentID
            // 
            this.txt_shipmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_shipmentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_shipmentID.Location = new System.Drawing.Point(662, 33);
            this.txt_shipmentID.Name = "txt_shipmentID";
            this.txt_shipmentID.Size = new System.Drawing.Size(135, 20);
            this.txt_shipmentID.TabIndex = 40;
            // 
            // txt_Company
            // 
            this.txt_Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Company.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Company.Location = new System.Drawing.Point(720, 250);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(135, 20);
            this.txt_Company.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(163, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "All Arrival Shipments";
            // 
            // txt_VehicleType
            // 
            this.txt_VehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_VehicleType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_VehicleType.Location = new System.Drawing.Point(720, 182);
            this.txt_VehicleType.Name = "txt_VehicleType";
            this.txt_VehicleType.Size = new System.Drawing.Size(135, 20);
            this.txt_VehicleType.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Vehicle Type: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(603, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Driver CNIC: ";
            // 
            // txt_DriverCNIC
            // 
            this.txt_DriverCNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_DriverCNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DriverCNIC.Location = new System.Drawing.Point(720, 149);
            this.txt_DriverCNIC.Name = "txt_DriverCNIC";
            this.txt_DriverCNIC.Size = new System.Drawing.Size(135, 20);
            this.txt_DriverCNIC.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(589, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Arriving Date: ";
            // 
            // txt_ArrivingDate
            // 
            this.txt_ArrivingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ArrivingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ArrivingDate.Location = new System.Drawing.Point(720, 215);
            this.txt_ArrivingDate.Name = "txt_ArrivingDate";
            this.txt_ArrivingDate.Size = new System.Drawing.Size(135, 20);
            this.txt_ArrivingDate.TabIndex = 27;
            // 
            // grid_view_arrival_shipments
            // 
            this.grid_view_arrival_shipments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.grid_view_arrival_shipments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_view_arrival_shipments.ColumnHeadersHeight = 40;
            this.grid_view_arrival_shipments.Location = new System.Drawing.Point(20, 75);
            this.grid_view_arrival_shipments.Name = "grid_view_arrival_shipments";
            this.grid_view_arrival_shipments.Size = new System.Drawing.Size(545, 421);
            this.grid_view_arrival_shipments.TabIndex = 26;
            // 
            // btn_genertate_Gate_Pass
            // 
            this.btn_genertate_Gate_Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_genertate_Gate_Pass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_genertate_Gate_Pass.FlatAppearance.BorderSize = 3;
            this.btn_genertate_Gate_Pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_genertate_Gate_Pass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_genertate_Gate_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genertate_Gate_Pass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genertate_Gate_Pass.ForeColor = System.Drawing.Color.White;
            this.btn_genertate_Gate_Pass.Location = new System.Drawing.Point(703, 347);
            this.btn_genertate_Gate_Pass.Name = "btn_genertate_Gate_Pass";
            this.btn_genertate_Gate_Pass.Size = new System.Drawing.Size(182, 54);
            this.btn_genertate_Gate_Pass.TabIndex = 25;
            this.btn_genertate_Gate_Pass.Text = "Generate Gate Pass";
            this.btn_genertate_Gate_Pass.UseVisualStyleBackColor = true;
            this.btn_genertate_Gate_Pass.Click += new System.EventHandler(this.Btn_genertate_Gate_Pass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(571, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Company Name: ";
            // 
            // txt_DriverName
            // 
            this.txt_DriverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_DriverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DriverName.Location = new System.Drawing.Point(720, 116);
            this.txt_DriverName.Name = "txt_DriverName";
            this.txt_DriverName.Size = new System.Drawing.Size(135, 20);
            this.txt_DriverName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(596, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Driver Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(610, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vehicle No: ";
            // 
            // txt_vehicleNo
            // 
            this.txt_vehicleNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_vehicleNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicleNo.Location = new System.Drawing.Point(720, 88);
            this.txt_vehicleNo.Name = "txt_vehicleNo";
            this.txt_vehicleNo.Size = new System.Drawing.Size(135, 20);
            this.txt_vehicleNo.TabIndex = 18;
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
            this.btn_View.Location = new System.Drawing.Point(820, 21);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(90, 41);
            this.btn_View.TabIndex = 19;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(691, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Security Manager";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage_Security_arrival);
            this.tabControl1.Controls.Add(this.tabPage_Security_departure);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 20);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(174, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 558);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage_Security_departure
            // 
            this.tabPage_Security_departure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.tabPage_Security_departure.Controls.Add(this.btn_clear_order);
            this.tabPage_Security_departure.Controls.Add(this.label5);
            this.tabPage_Security_departure.Controls.Add(this.txt_orderID);
            this.tabPage_Security_departure.Controls.Add(this.label19);
            this.tabPage_Security_departure.Controls.Add(this.grid_view_departure);
            this.tabPage_Security_departure.Controls.Add(this.txt_company_name);
            this.tabPage_Security_departure.Controls.Add(this.txt_Vehcile_type);
            this.tabPage_Security_departure.Controls.Add(this.label12);
            this.tabPage_Security_departure.Controls.Add(this.label13);
            this.tabPage_Security_departure.Controls.Add(this.txt_driver_CNIC);
            this.tabPage_Security_departure.Controls.Add(this.label15);
            this.tabPage_Security_departure.Controls.Add(this.txt_departure_Date);
            this.tabPage_Security_departure.Controls.Add(this.btn_generate_gate_pass_departure);
            this.tabPage_Security_departure.Controls.Add(this.label16);
            this.tabPage_Security_departure.Controls.Add(this.txt_driver_name);
            this.tabPage_Security_departure.Controls.Add(this.label17);
            this.tabPage_Security_departure.Controls.Add(this.label18);
            this.tabPage_Security_departure.Controls.Add(this.txt_Vehicle_ID);
            this.tabPage_Security_departure.Controls.Add(this.btn_ORder_View);
            this.tabPage_Security_departure.Controls.Add(this.pictureBox2);
            this.tabPage_Security_departure.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Security_departure.Name = "tabPage_Security_departure";
            this.tabPage_Security_departure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Security_departure.Size = new System.Drawing.Size(940, 530);
            this.tabPage_Security_departure.TabIndex = 1;
            this.tabPage_Security_departure.Text = "Departure Shipments";
            this.tabPage_Security_departure.Click += new System.EventHandler(this.TabPage_Security_departure_Click);
            // 
            // btn_clear_order
            // 
            this.btn_clear_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear_order.FlatAppearance.BorderSize = 3;
            this.btn_clear_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_clear_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_order.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_order.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_order.Location = new System.Drawing.Point(588, 350);
            this.btn_clear_order.Name = "btn_clear_order";
            this.btn_clear_order.Size = new System.Drawing.Size(86, 41);
            this.btn_clear_order.TabIndex = 62;
            this.btn_clear_order.Text = "Clear";
            this.btn_clear_order.UseVisualStyleBackColor = false;
            this.btn_clear_order.Click += new System.EventHandler(this.Btn_clear_order_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(523, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "Order No: ";
            // 
            // txt_orderID
            // 
            this.txt_orderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_orderID.Location = new System.Drawing.Point(633, 37);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(135, 20);
            this.txt_orderID.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(137, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(259, 29);
            this.label19.TabIndex = 58;
            this.label19.Text = "All Departure Shipments";
            // 
            // grid_view_departure
            // 
            this.grid_view_departure.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.grid_view_departure.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_view_departure.ColumnHeadersHeight = 40;
            this.grid_view_departure.Location = new System.Drawing.Point(28, 84);
            this.grid_view_departure.Name = "grid_view_departure";
            this.grid_view_departure.Size = new System.Drawing.Size(548, 429);
            this.grid_view_departure.TabIndex = 57;
            // 
            // txt_company_name
            // 
            this.txt_company_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_company_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_company_name.Location = new System.Drawing.Point(731, 267);
            this.txt_company_name.Name = "txt_company_name";
            this.txt_company_name.Size = new System.Drawing.Size(135, 20);
            this.txt_company_name.TabIndex = 54;
            // 
            // txt_Vehcile_type
            // 
            this.txt_Vehcile_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Vehcile_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Vehcile_type.Location = new System.Drawing.Point(731, 201);
            this.txt_Vehcile_type.Name = "txt_Vehcile_type";
            this.txt_Vehcile_type.Size = new System.Drawing.Size(135, 20);
            this.txt_Vehcile_type.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(607, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "Vehicle Type: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(614, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Driver CNIC: ";
            // 
            // txt_driver_CNIC
            // 
            this.txt_driver_CNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_driver_CNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_driver_CNIC.Location = new System.Drawing.Point(731, 168);
            this.txt_driver_CNIC.Name = "txt_driver_CNIC";
            this.txt_driver_CNIC.Size = new System.Drawing.Size(135, 20);
            this.txt_driver_CNIC.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(584, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "Departure Date: ";
            // 
            // txt_departure_Date
            // 
            this.txt_departure_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_departure_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_departure_Date.Location = new System.Drawing.Point(731, 233);
            this.txt_departure_Date.Name = "txt_departure_Date";
            this.txt_departure_Date.Size = new System.Drawing.Size(135, 20);
            this.txt_departure_Date.TabIndex = 46;
            // 
            // btn_generate_gate_pass_departure
            // 
            this.btn_generate_gate_pass_departure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate_gate_pass_departure.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_generate_gate_pass_departure.FlatAppearance.BorderSize = 3;
            this.btn_generate_gate_pass_departure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_generate_gate_pass_departure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_generate_gate_pass_departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate_gate_pass_departure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_gate_pass_departure.ForeColor = System.Drawing.Color.White;
            this.btn_generate_gate_pass_departure.Location = new System.Drawing.Point(698, 350);
            this.btn_generate_gate_pass_departure.Name = "btn_generate_gate_pass_departure";
            this.btn_generate_gate_pass_departure.Size = new System.Drawing.Size(182, 54);
            this.btn_generate_gate_pass_departure.TabIndex = 45;
            this.btn_generate_gate_pass_departure.Text = "Generate Gate Pass";
            this.btn_generate_gate_pass_departure.UseVisualStyleBackColor = true;
            this.btn_generate_gate_pass_departure.Click += new System.EventHandler(this.Btn_generate_gate_pass_departure_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(582, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 23);
            this.label16.TabIndex = 44;
            this.label16.Text = "Company Name: ";
            // 
            // txt_driver_name
            // 
            this.txt_driver_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_driver_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_driver_name.Location = new System.Drawing.Point(731, 135);
            this.txt_driver_name.Name = "txt_driver_name";
            this.txt_driver_name.Size = new System.Drawing.Size(135, 20);
            this.txt_driver_name.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(607, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 23);
            this.label17.TabIndex = 42;
            this.label17.Text = "Driver Name: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(625, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 23);
            this.label18.TabIndex = 41;
            this.label18.Text = "Vehicle No: ";
            // 
            // txt_Vehicle_ID
            // 
            this.txt_Vehicle_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Vehicle_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Vehicle_ID.Location = new System.Drawing.Point(731, 100);
            this.txt_Vehicle_ID.Name = "txt_Vehicle_ID";
            this.txt_Vehicle_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_Vehicle_ID.TabIndex = 39;
            // 
            // btn_ORder_View
            // 
            this.btn_ORder_View.BackColor = System.Drawing.Color.Yellow;
            this.btn_ORder_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ORder_View.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ORder_View.FlatAppearance.BorderSize = 3;
            this.btn_ORder_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ORder_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ORder_View.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ORder_View.ForeColor = System.Drawing.Color.Black;
            this.btn_ORder_View.Location = new System.Drawing.Point(784, 25);
            this.btn_ORder_View.Name = "btn_ORder_View";
            this.btn_ORder_View.Size = new System.Drawing.Size(86, 41);
            this.btn_ORder_View.TabIndex = 40;
            this.btn_ORder_View.Text = "View";
            this.btn_ORder_View.UseVisualStyleBackColor = false;
            this.btn_ORder_View.Click += new System.EventHandler(this.Btn_ORder_View_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(698, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
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
            this.btn_logout.Location = new System.Drawing.Point(843, 22);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 45);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // Security_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(978, 648);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Security_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Security_Manager_Load);
            tabPage_Security_arrival.ResumeLayout(false);
            tabPage_Security_arrival.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_arrival_shipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Security_departure.ResumeLayout(false);
            this.tabPage_Security_departure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_departure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_genertate_Gate_Pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DriverName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vehicleNo;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.TabPage tabPage_Security_departure;
        private System.Windows.Forms.DataGridView grid_view_arrival_shipments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ArrivingDate;
        private System.Windows.Forms.TextBox txt_VehicleType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DriverCNIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView grid_view_departure;
        private System.Windows.Forms.TextBox txt_company_name;
        private System.Windows.Forms.TextBox txt_Vehcile_type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_driver_CNIC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_departure_Date;
        private System.Windows.Forms.Button btn_generate_gate_pass_departure;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_driver_name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Vehicle_ID;
        private System.Windows.Forms.Button btn_ORder_View;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_shipmentID;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Button btn_clear_order;
    }
}