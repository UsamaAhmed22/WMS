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

namespace WMS
{
    public partial class ProductCompanyForm : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public ProductCompanyForm()
        {
            InitializeComponent();
        }

        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            _ = new WMS_Manager
            {
                Visible = true
            };
            this.Close();
        }

        private void Btn_comp_view_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string companyID = txt_comp_ID.Text;

                    string query = "SELECT Name, ContactPersonName, Email, Phone1, Phone2, Postalcode, Address FROM ShipmentINFO.Company WHERE CompanyID = @CompanyID";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@CompanyID", companyID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        txt_Comp_Name.Text = reader["Name"].ToString();
                        txt_comp_person.Text = reader["ContactPersonName"].ToString();
                        txt_comp_Email.Text = reader["Email"].ToString();
                        txt_comp_phone1.Text = reader["Phone1"].ToString();
                        txt_comp_phone2.Text = reader["Phone2"].ToString();
                        txt_comp_postal.Text = reader["Postalcode"].ToString();
                        txt_comp_address.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Company not Registered.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Btn_comp_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string companyID = txt_comp_ID.Text;
                    string name = txt_Comp_Name.Text;
                    string person = txt_comp_person.Text;
                    string email = txt_comp_Email.Text;
                    string phone1 = txt_comp_phone1.Text;
                    string phone2 = txt_comp_phone2.Text;
                    string postal = txt_comp_postal.Text;
                    string address = txt_comp_address.Text;

                    string query = "UPDATE ShipmentINFO.Company SET Name = @Name, ContactPersonName = @Person, Email = @Email, Phone1 = @Phone1, Phone2 = @Phone2, Postalcode = @Postal, Address = @Address WHERE CompanyID = @CompanyID";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Person", person);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone1", phone1);
                    cmd.Parameters.AddWithValue("@Phone2", phone2);
                    cmd.Parameters.AddWithValue("@Postal", postal);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@CompanyID", companyID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Company Records Updated Successfully...");
                        // Clear text boxes after update
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Company Records Not Found or Update Failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Helper method to clear text boxes
        private void ClearTextBoxes()
        {
            txt_Comp_Name.Text = "";
            txt_comp_person.Text = "";
            txt_comp_Email.Text = "";
            txt_comp_phone1.Text = "";
            txt_comp_phone2.Text = "";
            txt_comp_postal.Text = "";
            txt_comp_address.Text = "";
        }

        private void Btn_comp_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string name = txt_Comp_Name.Text;
                    string person = txt_comp_person.Text;
                    string email = txt_comp_Email.Text;
                    string phone1 = txt_comp_phone1.Text;
                    string phone2 = txt_comp_phone2.Text;
                    string postal = txt_comp_postal.Text;
                    string address = txt_comp_address.Text;

                    string query = "INSERT INTO ShipmentINFO.Company (Name, ContactPersonName, Email, Phone1, Phone2, Postalcode, Address) " +
                                   "VALUES (@Name, @Person, @Email, @Phone1, @Phone2, @Postal, @Address)";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Person", person);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone1", phone1);
                    cmd.Parameters.AddWithValue("@Phone2", phone2);
                    cmd.Parameters.AddWithValue("@Postal", postal);
                    cmd.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Company Registered successfully...");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Company Registration Failed...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void Btn_comp_delete_Click(object sender, EventArgs e)
        {
            string CompanyID = txt_comp_ID.Text;

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();
                    string query = "DELETE FROM ShipmentINFO.Company WHERE CompanyID = @CompanyID";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@CompanyID", Convert.ToInt32(CompanyID));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Company deleted successfully.");

                        // Clear text boxes after deletion
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Company not found or deletion failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

       
    }
}
