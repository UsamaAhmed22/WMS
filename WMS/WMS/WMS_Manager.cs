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
    public partial class WMS_Manager : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public WMS_Manager()
        {
            InitializeComponent();
        }

        private void WMS_Manager_Load(object sender, EventArgs e)
        {
            PopulateASNGridView();
            PopulateOPNGridView();
            DisplayTotalIncome();

            cb_emp_role.Items.Add("Normal");
            cb_emp_role.Items.Add("O&PManager");
            cb_emp_role.Items.Add("R&PManager");
            cb_emp_role.Items.Add("SecurityManager");
            cb_emp_role.Items.Add("DockManager");
            cb_emp_role.Items.Add("WMSManager");
        }
        private void Tab_page_Ship_info_Click(object sender, EventArgs e)
        {
            PopulateASNGridView();
            PopulateOPNGridView();
        }



        //<--------------------------  Logut Screen Button   -------------------------->
        //
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            _ = new login
            {
                Visible = true
            };
            this.Close();
        }

        //<--------------------------  Create ASN Button   -------------------------->  

        private void BtnCreateASN_Click(object sender, EventArgs e)
        {
            _ = new ASNForm
            {
                Visible = true
            };
            this.Close();
        }

        //<--------------------------  Create OPN Button   -------------------------->  

        private void Btn_createOPN_Click(object sender, EventArgs e)
        {
            _ = new OPNForm
            {
                Visible = true
            };
            this.Close();
        }

        //<--------------------------  Company of products Button   -------------------------->  

        private void Btn_comp_product_Click(object sender, EventArgs e)
        {
            _ = new ProductCompanyForm
            {
                Visible = true
            };
            this.Close();
        }

        //<--------------------------  Vehicle Information Button   -------------------------->  

        private void Btn_vehicle_Click(object sender, EventArgs e)
        {
            _ = new VehicleForm
            {
                Visible = true
            };
            this.Close();
        }

        //<--------------------------  Products Information Button   -------------------------->  

        private void Btn_Product_Click(object sender, EventArgs e)
        {
            _ = new ProductInformation
            {
                Visible = true
            };
            this.Close();
        }

        //<--------------------------  WareHouse Information Button   -------------------------->  

        private void Btn_Warehouse_Click(object sender, EventArgs e)
        {
            _ = new WareHouseForm
            {
                Visible = true
            };
            this.Close();
        }




        //<--------------------------  Employee Tab Control   -------------------------->  




        //Add Button
        private void Btn_emp_View_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB);
            SqlDataReader reader = null;

            try
            {
                sqlCon.Open();
                string loginID = txt_emp_ID.Text;

                if (!int.TryParse(loginID, out int parsedLoginID))
                {
                    MessageBox.Show("Invalid LoginID. Please enter a valid ID.");
                    return;
                }

                string query = "SELECT UserName, UserRole, UserPassword, Fname, Lname, salary, Email, Address, Phone " +
                                "FROM UserINFO.Login WHERE LoginID = @loginID";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@loginID", parsedLoginID);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Display employee details in respective textboxes
                    txt_emp_name.Text = reader["UserName"].ToString();
                    cb_emp_role.Text = reader["UserRole"].ToString();
                    txt_emp_Password.Text = reader["UserPassword"].ToString();
                    txt_emp_fname.Text = reader["Fname"].ToString();
                    txt_emp_lname.Text = reader["Lname"].ToString();
                    txt_emp_Salary.Text = reader["salary"].ToString();
                    txt_emp_email.Text = reader["Email"].ToString();
                    txt_emp_Address.Text = reader["Address"].ToString();
                    txt_emp_Phone.Text = reader["Phone"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found...");
                    ClearTextBoxes();
                    // You may want to clear the textboxes or take appropriate action here.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                reader?.Close();
                sqlCon?.Close();
            }
        }

        private void Btn_emp_Update_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB);

            try
            {
                sqlCon.Open();

                string loginID = txt_emp_ID.Text;
                string fName = txt_emp_fname.Text;
                string lName = txt_emp_lname.Text;
                string salary = txt_emp_Salary.Text;
                string email = txt_emp_email.Text;
                string address = txt_emp_Address.Text;
                string phone = txt_emp_Phone.Text;
                string username = txt_emp_name.Text;
                string password = txt_emp_Password.Text;
                string userRole = cb_emp_role.Text;

                // Validation for non-empty fields
                if (string.IsNullOrWhiteSpace(loginID) || string.IsNullOrWhiteSpace(fName) ||
                    string.IsNullOrWhiteSpace(lName) || string.IsNullOrWhiteSpace(salary) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                // Update EmployeeDetails table
                string updateEmployeeQuery = "UPDATE UserINFO.Login " +
                    "SET Fname = @fName, Lname = @lName, salary = @salary, Email = @email, " +
                    "Address = @address, Phone = @phone, UserName = @username, UserPassword = @password, UserRole = @userRole " +
                    "WHERE LoginID = @loginID";

                using (SqlCommand cmd = new SqlCommand(updateEmployeeQuery, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@UserRole", userRole);
                    cmd.Parameters.AddWithValue("@fName", fName);
                    cmd.Parameters.AddWithValue("@lName", lName);
                    cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(salary));
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@loginID", Convert.ToInt32(loginID));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee details updated successfully.");
                        // Clear text boxes or take any other necessary action
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("No employee details were updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlCon?.Close();
            }
        }

        private void Btn_emp_Delete_Click(object sender, EventArgs e)
        {
            string loginID = txt_emp_ID.Text.Trim();

            if (string.IsNullOrEmpty(loginID))
            {
                MessageBox.Show("Please enter a Login ID.");
                return;
            }

            if (!int.TryParse(loginID, out _))
            {
                MessageBox.Show("Login ID must be a numeric value.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                    {
                        sqlCon.Open();

                        string deleteEmployeeQuery = "DELETE FROM UserINFO.Login WHERE LoginID = @loginID";

                        using (SqlCommand cmd = new SqlCommand(deleteEmployeeQuery, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@loginID", Convert.ToInt32(loginID));

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee details deleted successfully.");
                                // Clear text boxes or take any other necessary action
                                ClearTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Employee with the provided ID not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Btn_emp_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string userName = txt_emp_name.Text;
                    string userPassword = txt_emp_Password.Text;
                    string fName = txt_emp_fname.Text;
                    string lName = txt_emp_lname.Text;
                    string salary = txt_emp_Salary.Text;
                    string email = txt_emp_email.Text;
                    string address = txt_emp_Address.Text;
                    string phone = txt_emp_Phone.Text;
                    string userRole = cb_emp_role.Text;

                    // Check for empty fields
                    if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(salary) ||
                        string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) )
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    // Additional checks for numeric fields (e.g., Salary, Phone)
                    if (!double.TryParse(salary, out _))
                    {
                        MessageBox.Show("Please enter a valid salary.");
                        return;
                    }


                    // SQL query to insert employee details
                    string query = "INSERT INTO UserINFO.Login (Fname, Lname, salary, Email, Address, Phone, UserName, UserRole, UserPassword) VALUES (@fName, @lName, @salary, @email, @address, @phone, @userName, @userRole, @userPassword)";

                    using (SqlCommand cmdInsertEmployee = new SqlCommand(query, sqlCon))
                    {
                        cmdInsertEmployee.Parameters.AddWithValue("@fName", fName);
                        cmdInsertEmployee.Parameters.AddWithValue("@lName", lName);
                        cmdInsertEmployee.Parameters.AddWithValue("@salary", salary);
                        cmdInsertEmployee.Parameters.AddWithValue("@email", email);
                        cmdInsertEmployee.Parameters.AddWithValue("@address", address);
                        cmdInsertEmployee.Parameters.AddWithValue("@phone", phone);
                        cmdInsertEmployee.Parameters.AddWithValue("@userName", userName);
                        cmdInsertEmployee.Parameters.AddWithValue("@userPassword", userPassword);
                        cmdInsertEmployee.Parameters.AddWithValue("@userRole", userRole);

                        int rowsAffected = cmdInsertEmployee.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee details added successfully.");
                            // Clear text boxes or take any other necessary action
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee details.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void ClearTextBoxes()
        {
            txt_emp_ID.Text = "";
            txt_emp_Address.Text = "";
            txt_emp_email.Text = "";
            txt_emp_fname.Text = "";
            txt_emp_lname.Text = "";
            txt_emp_name.Text = "";
            txt_emp_Password.Text = "";
            txt_emp_Phone.Text = "";
            txt_emp_Salary.Text = "";
            cb_emp_role.SelectedIndex = -1;
        }




        private DataTable FetchDataForGridView(string shipmentStatus)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT S.ShipmentID, S.WarehouseID, S.DockID, S.VehicleID, S.Date, 
                            C.Name AS CompanyName, S.Status
                            FROM ShipmentINFO.Shipment S
                            INNER JOIN ShipmentINFO.Company C ON S.CompanyID = C.CompanyID
                            WHERE S.ShipmentStatus = @ShipmentStatus";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    adapter.SelectCommand.Parameters.AddWithValue("@ShipmentStatus", shipmentStatus);

                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return dataTable;
        }

        private void PopulateGridView(DataGridView gridView, string shipmentStatus)
        {
            gridView.AutoGenerateColumns = true;
            DataTable dataTable = FetchDataForGridView(shipmentStatus);
            gridView.DataSource = dataTable;
        }

        // Usage:
        private void PopulateASNGridView()
        {
            PopulateGridView(grid_ASN_View, "Arrival");
        }

        private void PopulateOPNGridView()
        {
            PopulateGridView(grid_View_OPN, "Departure");
        }


        private void DisplayTotalIncome()
        {

            using (SqlConnection connection = new SqlConnection(connectTo_WMS_DB))
            {
                string query = "SELECT SUM(ExtraCharges) + SUM(TotalStorageCharges) AS TotalIncome FROM ProductINFO.BillDetails";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            decimal totalIncome = Convert.ToDecimal(result);
                            total_income.Text = "Total Income: " + totalIncome.ToString(); // Display the total income in the label
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
        }



    }
}
