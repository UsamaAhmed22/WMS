namespace WMS
{
    partial class login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rd_wms = new System.Windows.Forms.RadioButton();
            this.rd_S = new System.Windows.Forms.RadioButton();
            this.rd_O = new System.Windows.Forms.RadioButton();
            this.rd_D = new System.Windows.Forms.RadioButton();
            this.rd_R = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(482, 368);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(88, 41);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "WareHouse Management System";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_name.Location = new System.Drawing.Point(259, 127);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(121, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password: ";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_password.Location = new System.Drawing.Point(259, 175);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(121, 20);
            this.txt_password.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.BorderSize = 3;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(374, 368);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 41);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // rd_wms
            // 
            this.rd_wms.AutoSize = true;
            this.rd_wms.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_wms.ForeColor = System.Drawing.Color.Yellow;
            this.rd_wms.Location = new System.Drawing.Point(44, 266);
            this.rd_wms.Name = "rd_wms";
            this.rd_wms.Size = new System.Drawing.Size(146, 27);
            this.rd_wms.TabIndex = 9;
            this.rd_wms.TabStop = true;
            this.rd_wms.Text = "WMS Manager";
            this.rd_wms.UseVisualStyleBackColor = true;
            // 
            // rd_S
            // 
            this.rd_S.AutoSize = true;
            this.rd_S.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_S.ForeColor = System.Drawing.Color.Yellow;
            this.rd_S.Location = new System.Drawing.Point(206, 266);
            this.rd_S.Name = "rd_S";
            this.rd_S.Size = new System.Drawing.Size(168, 27);
            this.rd_S.TabIndex = 10;
            this.rd_S.TabStop = true;
            this.rd_S.Text = "Security Manager";
            this.rd_S.UseVisualStyleBackColor = true;
            // 
            // rd_O
            // 
            this.rd_O.AutoSize = true;
            this.rd_O.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_O.ForeColor = System.Drawing.Color.Yellow;
            this.rd_O.Location = new System.Drawing.Point(300, 308);
            this.rd_O.Name = "rd_O";
            this.rd_O.Size = new System.Drawing.Size(150, 27);
            this.rd_O.TabIndex = 12;
            this.rd_O.TabStop = true;
            this.rd_O.Text = "Order Manager";
            this.rd_O.UseVisualStyleBackColor = true;
            // 
            // rd_D
            // 
            this.rd_D.AutoSize = true;
            this.rd_D.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_D.ForeColor = System.Drawing.Color.Yellow;
            this.rd_D.Location = new System.Drawing.Point(119, 308);
            this.rd_D.Name = "rd_D";
            this.rd_D.Size = new System.Drawing.Size(142, 27);
            this.rd_D.TabIndex = 11;
            this.rd_D.TabStop = true;
            this.rd_D.Text = "Dock Manager";
            this.rd_D.UseVisualStyleBackColor = true;
            // 
            // rd_R
            // 
            this.rd_R.AutoSize = true;
            this.rd_R.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_R.ForeColor = System.Drawing.Color.Yellow;
            this.rd_R.Location = new System.Drawing.Point(390, 266);
            this.rd_R.Name = "rd_R";
            this.rd_R.Size = new System.Drawing.Size(180, 27);
            this.rd_R.TabIndex = 13;
            this.rd_R.TabStop = true;
            this.rd_R.Text = "Recieving Manager";
            this.rd_R.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 3;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(44, 368);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 41);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(610, 479);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.rd_R);
            this.Controls.Add(this.rd_O);
            this.Controls.Add(this.rd_D);
            this.Controls.Add(this.rd_S);
            this.Controls.Add(this.rd_wms);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rd_wms;
        private System.Windows.Forms.RadioButton rd_S;
        private System.Windows.Forms.RadioButton rd_O;
        private System.Windows.Forms.RadioButton rd_D;
        private System.Windows.Forms.RadioButton rd_R;
        private System.Windows.Forms.Button btn_close;
    }
}

