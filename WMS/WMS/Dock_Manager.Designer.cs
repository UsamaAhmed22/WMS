namespace WMS
{
    partial class Dock_Manager
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
            System.Windows.Forms.TabPage tab_arrival;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dock_Manager));
            this.grid_View_all_Shipments_arrival = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.stay_here_arrival = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dock_No = new System.Windows.Forms.TextBox();
            this.txt_Warehouse_No = new System.Windows.Forms.TextBox();
            this.txt_dock_sta = new System.Windows.Forms.TextBox();
            this.txt_Vehciel_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_send_to_dock_arrival = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_View_arrival = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.load_shipments = new System.Windows.Forms.TabPage();
            this.btn_stay_here = new System.Windows.Forms.Button();
            this.txt_dock_ID = new System.Windows.Forms.TextBox();
            this.txt_warehouse_ID = new System.Windows.Forms.TextBox();
            this.txt_Dock_status = new System.Windows.Forms.TextBox();
            this.txt_registration_no = new System.Windows.Forms.TextBox();
            this.txt_Order_ID = new System.Windows.Forms.TextBox();
            this.grid_View_All_Shipments_Order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SendToDock_Departure = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_View_Order_shipments = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_shipment_No = new System.Windows.Forms.TextBox();
            tab_arrival = new System.Windows.Forms.TabPage();
            tab_arrival.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_all_Shipments_arrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.load_shipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_All_Shipments_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_arrival
            // 
            tab_arrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            tab_arrival.Controls.Add(this.label3);
            tab_arrival.Controls.Add(this.txt_shipment_No);
            tab_arrival.Controls.Add(this.grid_View_all_Shipments_arrival);
            tab_arrival.Controls.Add(this.label17);
            tab_arrival.Controls.Add(this.label12);
            tab_arrival.Controls.Add(this.label13);
            tab_arrival.Controls.Add(this.label14);
            tab_arrival.Controls.Add(this.label16);
            tab_arrival.Controls.Add(this.stay_here_arrival);
            tab_arrival.Controls.Add(this.pictureBox1);
            tab_arrival.Controls.Add(this.label9);
            tab_arrival.Controls.Add(this.txt_dock_No);
            tab_arrival.Controls.Add(this.txt_Warehouse_No);
            tab_arrival.Controls.Add(this.txt_dock_sta);
            tab_arrival.Controls.Add(this.txt_Vehciel_ID);
            tab_arrival.Controls.Add(this.label7);
            tab_arrival.Controls.Add(this.label8);
            tab_arrival.Controls.Add(this.label6);
            tab_arrival.Controls.Add(this.btn_send_to_dock_arrival);
            tab_arrival.Controls.Add(this.label2);
            tab_arrival.Controls.Add(this.btn_View_arrival);
            tab_arrival.ForeColor = System.Drawing.Color.IndianRed;
            tab_arrival.Location = new System.Drawing.Point(4, 24);
            tab_arrival.Name = "tab_arrival";
            tab_arrival.Padding = new System.Windows.Forms.Padding(3);
            tab_arrival.Size = new System.Drawing.Size(917, 432);
            tab_arrival.TabIndex = 0;
            tab_arrival.Text = "Unload Shipments";
            tab_arrival.Click += new System.EventHandler(this.Tab_arrival_Click);
            // 
            // grid_View_all_Shipments_arrival
            // 
            this.grid_View_all_Shipments_arrival.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_all_Shipments_arrival.ColumnHeadersHeight = 40;
            this.grid_View_all_Shipments_arrival.Location = new System.Drawing.Point(6, 73);
            this.grid_View_all_Shipments_arrival.Name = "grid_View_all_Shipments_arrival";
            this.grid_View_all_Shipments_arrival.Size = new System.Drawing.Size(554, 353);
            this.grid_View_all_Shipments_arrival.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(134, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(294, 29);
            this.label17.TabIndex = 78;
            this.label17.Text = "All Shipments for Unloading";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(617, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 23);
            this.label12.TabIndex = 77;
            this.label12.Text = "Dock Number: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(566, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 23);
            this.label13.TabIndex = 76;
            this.label13.Text = "Warehouse Number: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(632, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 23);
            this.label14.TabIndex = 75;
            this.label14.Text = "Dock Status: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(598, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 23);
            this.label16.TabIndex = 73;
            this.label16.Text = "Registration No:";
            // 
            // stay_here_arrival
            // 
            this.stay_here_arrival.BackColor = System.Drawing.Color.Yellow;
            this.stay_here_arrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stay_here_arrival.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stay_here_arrival.FlatAppearance.BorderSize = 3;
            this.stay_here_arrival.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stay_here_arrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stay_here_arrival.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stay_here_arrival.ForeColor = System.Drawing.Color.Black;
            this.stay_here_arrival.Location = new System.Drawing.Point(602, 361);
            this.stay_here_arrival.Name = "stay_here_arrival";
            this.stay_here_arrival.Size = new System.Drawing.Size(107, 41);
            this.stay_here_arrival.TabIndex = 61;
            this.stay_here_arrival.Text = "Stay Here";
            this.stay_here_arrival.UseVisualStyleBackColor = false;
            this.stay_here_arrival.Click += new System.EventHandler(this.Stay_here_arrival_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(128, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 35;
            // 
            // txt_dock_No
            // 
            this.txt_dock_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_dock_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dock_No.Location = new System.Drawing.Point(742, 177);
            this.txt_dock_No.Name = "txt_dock_No";
            this.txt_dock_No.Size = new System.Drawing.Size(135, 20);
            this.txt_dock_No.TabIndex = 34;
            // 
            // txt_Warehouse_No
            // 
            this.txt_Warehouse_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Warehouse_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Warehouse_No.Location = new System.Drawing.Point(742, 144);
            this.txt_Warehouse_No.Name = "txt_Warehouse_No";
            this.txt_Warehouse_No.Size = new System.Drawing.Size(135, 20);
            this.txt_Warehouse_No.TabIndex = 31;
            // 
            // txt_dock_sta
            // 
            this.txt_dock_sta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_dock_sta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dock_sta.Location = new System.Drawing.Point(742, 210);
            this.txt_dock_sta.Name = "txt_dock_sta";
            this.txt_dock_sta.Size = new System.Drawing.Size(135, 20);
            this.txt_dock_sta.TabIndex = 27;
            // 
            // txt_Vehciel_ID
            // 
            this.txt_Vehciel_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Vehciel_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Vehciel_ID.Location = new System.Drawing.Point(742, 112);
            this.txt_Vehciel_ID.Name = "txt_Vehciel_ID";
            this.txt_Vehciel_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_Vehciel_ID.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(590, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(765, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 23);
            this.label8.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(633, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 28;
            // 
            // btn_send_to_dock_arrival
            // 
            this.btn_send_to_dock_arrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send_to_dock_arrival.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_send_to_dock_arrival.FlatAppearance.BorderSize = 3;
            this.btn_send_to_dock_arrival.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_send_to_dock_arrival.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_send_to_dock_arrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send_to_dock_arrival.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_to_dock_arrival.ForeColor = System.Drawing.Color.White;
            this.btn_send_to_dock_arrival.Location = new System.Drawing.Point(723, 354);
            this.btn_send_to_dock_arrival.Name = "btn_send_to_dock_arrival";
            this.btn_send_to_dock_arrival.Size = new System.Drawing.Size(182, 54);
            this.btn_send_to_dock_arrival.TabIndex = 25;
            this.btn_send_to_dock_arrival.Text = "Send to Dock";
            this.btn_send_to_dock_arrival.UseVisualStyleBackColor = true;
            this.btn_send_to_dock_arrival.Click += new System.EventHandler(this.Btn_send_to_dock_arrival_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(636, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 20;
            // 
            // btn_View_arrival
            // 
            this.btn_View_arrival.BackColor = System.Drawing.Color.Yellow;
            this.btn_View_arrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_arrival.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_View_arrival.FlatAppearance.BorderSize = 3;
            this.btn_View_arrival.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_View_arrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_arrival.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_arrival.ForeColor = System.Drawing.Color.Black;
            this.btn_View_arrival.Location = new System.Drawing.Point(816, 27);
            this.btn_View_arrival.Name = "btn_View_arrival";
            this.btn_View_arrival.Size = new System.Drawing.Size(89, 41);
            this.btn_View_arrival.TabIndex = 19;
            this.btn_View_arrival.Text = "View";
            this.btn_View_arrival.UseVisualStyleBackColor = false;
            this.btn_View_arrival.Click += new System.EventHandler(this.Btn_View_arrival_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(386, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(242, 45);
            this.label20.TabIndex = 16;
            this.label20.Text = "Dock Manager";
            // 
            // load_shipments
            // 
            this.load_shipments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.load_shipments.Controls.Add(this.btn_stay_here);
            this.load_shipments.Controls.Add(this.txt_dock_ID);
            this.load_shipments.Controls.Add(this.txt_warehouse_ID);
            this.load_shipments.Controls.Add(this.txt_Dock_status);
            this.load_shipments.Controls.Add(this.txt_registration_no);
            this.load_shipments.Controls.Add(this.txt_Order_ID);
            this.load_shipments.Controls.Add(this.grid_View_All_Shipments_Order);
            this.load_shipments.Controls.Add(this.label1);
            this.load_shipments.Controls.Add(this.label4);
            this.load_shipments.Controls.Add(this.label5);
            this.load_shipments.Controls.Add(this.btn_SendToDock_Departure);
            this.load_shipments.Controls.Add(this.label10);
            this.load_shipments.Controls.Add(this.label11);
            this.load_shipments.Controls.Add(this.btn_View_Order_shipments);
            this.load_shipments.Controls.Add(this.pictureBox2);
            this.load_shipments.Controls.Add(this.label19);
            this.load_shipments.Location = new System.Drawing.Point(4, 24);
            this.load_shipments.Name = "load_shipments";
            this.load_shipments.Padding = new System.Windows.Forms.Padding(3);
            this.load_shipments.Size = new System.Drawing.Size(917, 432);
            this.load_shipments.TabIndex = 1;
            this.load_shipments.Text = "Load Shipments";
            this.load_shipments.Click += new System.EventHandler(this.Load_shipments_Click);
            // 
            // btn_stay_here
            // 
            this.btn_stay_here.BackColor = System.Drawing.Color.Yellow;
            this.btn_stay_here.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stay_here.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_stay_here.FlatAppearance.BorderSize = 3;
            this.btn_stay_here.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stay_here.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stay_here.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stay_here.ForeColor = System.Drawing.Color.Black;
            this.btn_stay_here.Location = new System.Drawing.Point(590, 372);
            this.btn_stay_here.Name = "btn_stay_here";
            this.btn_stay_here.Size = new System.Drawing.Size(107, 41);
            this.btn_stay_here.TabIndex = 74;
            this.btn_stay_here.Text = "Stay Here";
            this.btn_stay_here.UseVisualStyleBackColor = false;
            this.btn_stay_here.Click += new System.EventHandler(this.Btn_stay_here_Click);
            // 
            // txt_dock_ID
            // 
            this.txt_dock_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_dock_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dock_ID.Location = new System.Drawing.Point(732, 172);
            this.txt_dock_ID.Name = "txt_dock_ID";
            this.txt_dock_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_dock_ID.TabIndex = 73;
            // 
            // txt_warehouse_ID
            // 
            this.txt_warehouse_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_warehouse_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_warehouse_ID.Location = new System.Drawing.Point(732, 139);
            this.txt_warehouse_ID.Name = "txt_warehouse_ID";
            this.txt_warehouse_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_warehouse_ID.TabIndex = 70;
            // 
            // txt_Dock_status
            // 
            this.txt_Dock_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Dock_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dock_status.Location = new System.Drawing.Point(732, 205);
            this.txt_Dock_status.Name = "txt_Dock_status";
            this.txt_Dock_status.Size = new System.Drawing.Size(135, 20);
            this.txt_Dock_status.TabIndex = 68;
            // 
            // txt_registration_no
            // 
            this.txt_registration_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_registration_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_registration_no.Location = new System.Drawing.Point(732, 106);
            this.txt_registration_no.Name = "txt_registration_no";
            this.txt_registration_no.Size = new System.Drawing.Size(135, 20);
            this.txt_registration_no.TabIndex = 66;
            // 
            // txt_Order_ID
            // 
            this.txt_Order_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Order_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Order_ID.Location = new System.Drawing.Point(665, 42);
            this.txt_Order_ID.Name = "txt_Order_ID";
            this.txt_Order_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_Order_ID.TabIndex = 62;
            // 
            // grid_View_All_Shipments_Order
            // 
            this.grid_View_All_Shipments_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_All_Shipments_Order.ColumnHeadersHeight = 40;
            this.grid_View_All_Shipments_Order.Location = new System.Drawing.Point(16, 66);
            this.grid_View_All_Shipments_Order.Name = "grid_View_All_Shipments_Order";
            this.grid_View_All_Shipments_Order.Size = new System.Drawing.Size(535, 353);
            this.grid_View_All_Shipments_Order.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(608, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Dock Number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(557, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "Warehouse Number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(623, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Dock Status: ";
            // 
            // btn_SendToDock_Departure
            // 
            this.btn_SendToDock_Departure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SendToDock_Departure.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SendToDock_Departure.FlatAppearance.BorderSize = 3;
            this.btn_SendToDock_Departure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_SendToDock_Departure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_SendToDock_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendToDock_Departure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendToDock_Departure.ForeColor = System.Drawing.Color.White;
            this.btn_SendToDock_Departure.Location = new System.Drawing.Point(711, 365);
            this.btn_SendToDock_Departure.Name = "btn_SendToDock_Departure";
            this.btn_SendToDock_Departure.Size = new System.Drawing.Size(182, 54);
            this.btn_SendToDock_Departure.TabIndex = 67;
            this.btn_SendToDock_Departure.Text = "Send to Dock";
            this.btn_SendToDock_Departure.UseVisualStyleBackColor = true;
            this.btn_SendToDock_Departure.Click += new System.EventHandler(this.Btn_SendToDock_Departure_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(586, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "Registration No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(576, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 64;
            this.label11.Text = "Order ID:";
            // 
            // btn_View_Order_shipments
            // 
            this.btn_View_Order_shipments.BackColor = System.Drawing.Color.Yellow;
            this.btn_View_Order_shipments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Order_shipments.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_View_Order_shipments.FlatAppearance.BorderSize = 3;
            this.btn_View_Order_shipments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_View_Order_shipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_Order_shipments.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Order_shipments.ForeColor = System.Drawing.Color.Black;
            this.btn_View_Order_shipments.Location = new System.Drawing.Point(806, 30);
            this.btn_View_Order_shipments.Name = "btn_View_Order_shipments";
            this.btn_View_Order_shipments.Size = new System.Drawing.Size(87, 41);
            this.btn_View_Order_shipments.TabIndex = 63;
            this.btn_View_Order_shipments.Text = "View";
            this.btn_View_Order_shipments.UseVisualStyleBackColor = false;
            this.btn_View_Order_shipments.Click += new System.EventHandler(this.Btn_View_Order_shipments_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(148, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(269, 29);
            this.label19.TabIndex = 58;
            this.label19.Text = "All Shipments for Loading";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tab_arrival);
            this.tabControl1.Controls.Add(this.load_shipments);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 20);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(166, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 460);
            this.tabControl1.TabIndex = 13;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company Name";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Driver Name";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Arriving Date";
            this.Column1.Name = "Column1";
            // 
            // TruckNo
            // 
            this.TruckNo.HeaderText = "Truck No";
            this.TruckNo.Name = "TruckNo";
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.BorderSize = 3;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(843, 13);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 45);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(550, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 81;
            this.label3.Text = "Shipment No: ";
            // 
            // txt_shipment_No
            // 
            this.txt_shipment_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_shipment_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_shipment_No.Location = new System.Drawing.Point(675, 42);
            this.txt_shipment_No.Name = "txt_shipment_No";
            this.txt_shipment_No.Size = new System.Drawing.Size(135, 20);
            this.txt_shipment_No.TabIndex = 80;
            // 
            // Dock_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(966, 579);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dock_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dock_Manager";
            this.Load += new System.EventHandler(this.Dock_Manager_Load);
            tab_arrival.ResumeLayout(false);
            tab_arrival.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_all_Shipments_arrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.load_shipments.ResumeLayout(false);
            this.load_shipments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_All_Shipments_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage load_shipments;
        private System.Windows.Forms.Button btn_stay_here;
        private System.Windows.Forms.TextBox txt_dock_ID;
        private System.Windows.Forms.TextBox txt_warehouse_ID;
        private System.Windows.Forms.TextBox txt_Dock_status;
        private System.Windows.Forms.TextBox txt_registration_no;
        private System.Windows.Forms.TextBox txt_Order_ID;
        private System.Windows.Forms.DataGridView grid_View_All_Shipments_Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SendToDock_Departure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_View_Order_shipments;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView grid_View_all_Shipments_arrival;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button stay_here_arrival;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dock_No;
        private System.Windows.Forms.TextBox txt_Warehouse_No;
        private System.Windows.Forms.TextBox txt_dock_sta;
        private System.Windows.Forms.TextBox txt_Vehciel_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_send_to_dock_arrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_View_arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckNo;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_shipment_No;
    }
}