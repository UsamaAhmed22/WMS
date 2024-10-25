namespace WMS
{
    partial class R_P_Manager
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
            this.grid_View_Overall = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Detail = new System.Windows.Forms.TabPage();
            this.txt_company_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_View_Recieve_manager = new System.Windows.Forms.DataGridView();
            this.txt_arrival_date = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dock_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_comp_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_registration_No = new System.Windows.Forms.TextBox();
            this.btn_Successful_placement = new System.Windows.Forms.Button();
            this.txt_warehouse_ID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_ASN_ID = new System.Windows.Forms.TextBox();
            this.btn_View_ASN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            tab_overall = new System.Windows.Forms.TabPage();
            tab_overall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_Overall)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_Recieve_manager)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_overall
            // 
            tab_overall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            tab_overall.Controls.Add(this.label9);
            tab_overall.Controls.Add(this.grid_View_Overall);
            tab_overall.ForeColor = System.Drawing.Color.IndianRed;
            tab_overall.Location = new System.Drawing.Point(4, 24);
            tab_overall.Name = "tab_overall";
            tab_overall.Padding = new System.Windows.Forms.Padding(3);
            tab_overall.Size = new System.Drawing.Size(975, 472);
            tab_overall.TabIndex = 0;
            tab_overall.Text = "Overall Arrival Shipments Report";
            tab_overall.Click += new System.EventHandler(this.Tab_overall_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(356, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "All Arrival Shipments";
            // 
            // grid_View_Overall
            // 
            this.grid_View_Overall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_Overall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_View_Overall.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grid_View_Overall.Location = new System.Drawing.Point(116, 87);
            this.grid_View_Overall.Name = "grid_View_Overall";
            this.grid_View_Overall.Size = new System.Drawing.Size(727, 353);
            this.grid_View_Overall.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tab_overall);
            this.tabControl1.Controls.Add(this.tab_Detail);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 20);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(136, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 500);
            this.tabControl1.TabIndex = 14;
            // 
            // tab_Detail
            // 
            this.tab_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.tab_Detail.Controls.Add(this.txt_company_ID);
            this.tab_Detail.Controls.Add(this.label2);
            this.tab_Detail.Controls.Add(this.grid_View_Recieve_manager);
            this.tab_Detail.Controls.Add(this.txt_arrival_date);
            this.tab_Detail.Controls.Add(this.label11);
            this.tab_Detail.Controls.Add(this.txt_dock_ID);
            this.tab_Detail.Controls.Add(this.label12);
            this.tab_Detail.Controls.Add(this.txt_comp_name);
            this.tab_Detail.Controls.Add(this.label14);
            this.tab_Detail.Controls.Add(this.label15);
            this.tab_Detail.Controls.Add(this.txt_registration_No);
            this.tab_Detail.Controls.Add(this.btn_Successful_placement);
            this.tab_Detail.Controls.Add(this.txt_warehouse_ID);
            this.tab_Detail.Controls.Add(this.label17);
            this.tab_Detail.Controls.Add(this.label18);
            this.tab_Detail.Controls.Add(this.txt_ASN_ID);
            this.tab_Detail.Controls.Add(this.btn_View_ASN);
            this.tab_Detail.Location = new System.Drawing.Point(4, 24);
            this.tab_Detail.Name = "tab_Detail";
            this.tab_Detail.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Detail.Size = new System.Drawing.Size(975, 472);
            this.tab_Detail.TabIndex = 1;
            this.tab_Detail.Text = "Particular Shipment Arrival Details";
            // 
            // txt_company_ID
            // 
            this.txt_company_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_company_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_company_ID.Location = new System.Drawing.Point(450, 343);
            this.txt_company_ID.Name = "txt_company_ID";
            this.txt_company_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_company_ID.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Company ID:";
            // 
            // grid_View_Recieve_manager
            // 
            this.grid_View_Recieve_manager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_View_Recieve_manager.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_View_Recieve_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_View_Recieve_manager.EnableHeadersVisualStyles = false;
            this.grid_View_Recieve_manager.Location = new System.Drawing.Point(6, 64);
            this.grid_View_Recieve_manager.Name = "grid_View_Recieve_manager";
            this.grid_View_Recieve_manager.Size = new System.Drawing.Size(939, 260);
            this.grid_View_Recieve_manager.TabIndex = 57;
            // 
            // txt_arrival_date
            // 
            this.txt_arrival_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_arrival_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_arrival_date.Location = new System.Drawing.Point(738, 376);
            this.txt_arrival_date.Name = "txt_arrival_date";
            this.txt_arrival_date.Size = new System.Drawing.Size(135, 20);
            this.txt_arrival_date.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(617, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "Arrival Date: ";
            // 
            // txt_dock_ID
            // 
            this.txt_dock_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_dock_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dock_ID.Location = new System.Drawing.Point(192, 379);
            this.txt_dock_ID.Name = "txt_dock_ID";
            this.txt_dock_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_dock_ID.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(101, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "Dock No: ";
            // 
            // txt_comp_name
            // 
            this.txt_comp_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_comp_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_comp_name.Location = new System.Drawing.Point(738, 340);
            this.txt_comp_name.Name = "txt_comp_name";
            this.txt_comp_name.Size = new System.Drawing.Size(135, 20);
            this.txt_comp_name.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(600, 337);
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
            this.label15.Location = new System.Drawing.Point(340, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "Vehicle No: ";
            // 
            // txt_registration_No
            // 
            this.txt_registration_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_registration_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_registration_No.Location = new System.Drawing.Point(450, 376);
            this.txt_registration_No.Name = "txt_registration_No";
            this.txt_registration_No.Size = new System.Drawing.Size(135, 20);
            this.txt_registration_No.TabIndex = 46;
            // 
            // btn_Successful_placement
            // 
            this.btn_Successful_placement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Successful_placement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Successful_placement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Successful_placement.FlatAppearance.BorderSize = 3;
            this.btn_Successful_placement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Successful_placement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Successful_placement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Successful_placement.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Successful_placement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Successful_placement.Location = new System.Drawing.Point(775, 402);
            this.btn_Successful_placement.Name = "btn_Successful_placement";
            this.btn_Successful_placement.Size = new System.Drawing.Size(182, 54);
            this.btn_Successful_placement.TabIndex = 45;
            this.btn_Successful_placement.Text = "Successfully Placed";
            this.btn_Successful_placement.UseVisualStyleBackColor = false;
            this.btn_Successful_placement.Click += new System.EventHandler(this.Btn_Successful_placement_Click);
            // 
            // txt_warehouse_ID
            // 
            this.txt_warehouse_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_warehouse_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_warehouse_ID.Location = new System.Drawing.Point(192, 346);
            this.txt_warehouse_ID.Name = "txt_warehouse_ID";
            this.txt_warehouse_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_warehouse_ID.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(61, 343);
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
            this.label18.Location = new System.Drawing.Point(623, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 41;
            this.label18.Text = "ASN No: ";
            // 
            // txt_ASN_ID
            // 
            this.txt_ASN_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ASN_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ASN_ID.Location = new System.Drawing.Point(703, 17);
            this.txt_ASN_ID.Name = "txt_ASN_ID";
            this.txt_ASN_ID.Size = new System.Drawing.Size(135, 20);
            this.txt_ASN_ID.TabIndex = 39;
            // 
            // btn_View_ASN
            // 
            this.btn_View_ASN.BackColor = System.Drawing.Color.Yellow;
            this.btn_View_ASN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_ASN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_View_ASN.FlatAppearance.BorderSize = 3;
            this.btn_View_ASN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_ASN.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_ASN.ForeColor = System.Drawing.Color.Black;
            this.btn_View_ASN.Location = new System.Drawing.Point(844, 9);
            this.btn_View_ASN.Name = "btn_View_ASN";
            this.btn_View_ASN.Size = new System.Drawing.Size(101, 41);
            this.btn_View_ASN.TabIndex = 40;
            this.btn_View_ASN.Text = "View";
            this.btn_View_ASN.UseVisualStyleBackColor = false;
            this.btn_View_ASN.Click += new System.EventHandler(this.Btn_View_ASN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-40, -37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Security Manager";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(369, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 45);
            this.label20.TabIndex = 15;
            this.label20.Text = "R N P Manager";
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.BorderSize = 3;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(879, 7);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 45);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // R_P_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1007, 582);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "R_P_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R_P_Manager";
            this.Load += new System.EventHandler(this.R_P_Manager_Load);
            tab_overall.ResumeLayout(false);
            tab_overall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_Overall)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_Detail.ResumeLayout(false);
            this.tab_Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_View_Recieve_manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grid_View_Overall;
        private System.Windows.Forms.TabPage tab_Detail;
        private System.Windows.Forms.TextBox txt_arrival_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dock_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_comp_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_registration_No;
        private System.Windows.Forms.Button btn_Successful_placement;
        private System.Windows.Forms.TextBox txt_warehouse_ID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_ASN_ID;
        private System.Windows.Forms.Button btn_View_ASN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView grid_View_Recieve_manager;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TextBox txt_company_ID;
        private System.Windows.Forms.Label label2;
    }
}