using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WMS
{
    public partial class login : Form
    {
        private string role;
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public login()
        {
            InitializeComponent();
        }

        public string Role { get => role; set => role = value; }
        public string Setrole()
        {
            if (rd_wms.Checked == true)
                Role = "WMSManager";
            else if (rd_O.Checked == true)
                Role = "O&PManager";
            else if (rd_D.Checked == true)
                Role = "DockManager";
            else if (rd_R.Checked == true)
                Role = "R&PManager";
            else if (rd_S.Checked == true)
                Role = "SecurityManager";
            else
                Role = " ";
            return Role;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectTo_WMS_DB))
            {
                sqlcon.Open();

                string username = txt_name.Text;
                string password = txt_password.Text;
                string role = Setrole();

                string query = "SELECT UserRole FROM UserINFO.Login WHERE UserName = @Username AND UserPassword = @Password AND UserRole = @Role";

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    switch (role)
                    {
                        case "WMSManager":
                            _ = new WMS_Manager
                            {
                                Visible = true
                            };
                            this.Hide();
                            break;
                        case "O&PManager":
                            _ = new O_P_Manager
                            {
                                Visible = true
                            };
                            this.Hide();
                            break;
                        case "DockManager":
                            _ = new Dock_Manager
                            {
                                Visible = true
                            };
                            this.Hide();
                            break;
                        case  "R&PManager":
                            _ = new R_P_Manager
                            {
                                Visible = true
                            };
                            this.Hide();
                            break;
                        case "SecurityManager":
                            _ = new Security_Manager
                            {
                                Visible = true
                            };
                            this.Hide();
                            break;
                        
                        default:
                            MessageBox.Show("Invalid role.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login. Please check username/password/role.");
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            // Clear the text in username and password fields
            txt_name.Text = "";
            txt_password.Text = "";

            // Uncheck all radio buttons for roles
            rd_wms.Checked = false;
            rd_O.Checked = false;
            rd_D.Checked = false;
            rd_R.Checked = false;
            rd_S.Checked = false;

        }
    }


}
