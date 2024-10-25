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
    public partial class WareHouseForm : Form
    {

        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public WareHouseForm()
        {
            InitializeComponent();
        }
        // Form Load
        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            cb_wareHouse_category.Items.Add("Full-Air Condition");
            cb_wareHouse_category.Items.Add("Semi-Air Condition");
            cb_wareHouse_category.Items.Add("Non-Air Condition");

            cb_wareHouse_status.Items.Add("Full");
            cb_wareHouse_status.Items.Add("Moderate");
            cb_wareHouse_status.Items.Add("Empty");
            cb_wareHouse_status.Items.Add("Active");
            cb_wareHouse_status.Items.Add("Non-Active");

            cb_dock_status.Items.Add("Free");
            cb_dock_status.Items.Add("Busy");

            TotalWareHouses();
        }
        //go back to WMS manager screen

        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            _ = new WMS_Manager
            {
                Visible = true
            };
            this.Close();
        }

        //view warehouses

        private void Btn_Warehouse_View_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_warehouse_ID.Text))
            {
                MessageBox.Show("Enter a Valid Warehouse ID.");
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string wareHouseID = txt_warehouse_ID.Text;
                    string query = "SELECT Name, Status, Category, WarehouseWidth, WarehouseLength, WarehouseHeight, TotalArea FROM WareHouseINFO.Warehouse WHERE WarehouseID = @wareHouseID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@wareHouseID", Convert.ToInt32(wareHouseID));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_warehouse_Name.Text = reader["Name"].ToString();
                                cb_wareHouse_status.Text = reader["Status"].ToString();
                                cb_wareHouse_category.Text = reader["Category"].ToString();
                                txt_warehouse_Width.Text = reader["WarehouseWidth"].ToString();
                                txt_warehouse_Length.Text = reader["WarehouseLength"].ToString();
                                txt_warehouse_Height.Text = reader["WarehouseHeight"].ToString();
                                lbl_count_total_area.Text = reader["TotalArea"].ToString();

                                TotalArea();
                            }
                            else
                            {
                                MessageBox.Show("Warehouse not Found...");
                                // You may want to clear the textboxes or take appropriate action here.
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //update warehouse
        private void Btn_Warehouse_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_warehouse_ID.Text))
            {
                MessageBox.Show("Please! Enter a Valid Warehouse ID.");
                return;
            }
            if (string.IsNullOrEmpty(txt_warehouse_Name.Text) || string.IsNullOrEmpty(cb_wareHouse_status.Text) ||
                    string.IsNullOrEmpty(cb_wareHouse_category.Text) || string.IsNullOrEmpty(txt_warehouse_Width.Text) ||
                    string.IsNullOrEmpty(txt_warehouse_Length.Text) || string.IsNullOrEmpty(txt_warehouse_Height.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string wareHouseName = txt_warehouse_Name.Text;
                    string Status = cb_wareHouse_status.Text;
                    string Category = cb_wareHouse_category.Text;
                    string Width = txt_warehouse_Width.Text;
                    string Length = txt_warehouse_Length.Text;
                    string Height = txt_warehouse_Height.Text;
                    string WarehouseID = txt_warehouse_ID.Text;
                    string totalArea = lbl_count_total_area.Text;

                    string query = "UPDATE WareHouseINFO.Warehouse SET Name = @Name, Status = @Status, Category = @Category, " +
                                   "WarehouseWidth = @WarehouseWidth, WarehouseLength = @WarehouseLength, WarehouseHeight = @WarehouseHeight, " +
                                   "TotalArea = @totalArea WHERE WarehouseID = @WarehouseID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Name", wareHouseName);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@Category", Category);
                        cmd.Parameters.AddWithValue("@WarehouseWidth", Width);
                        cmd.Parameters.AddWithValue("@WarehouseLength", Length);
                        cmd.Parameters.AddWithValue("@WarehouseHeight", Height);
                        cmd.Parameters.AddWithValue("@totalArea", totalArea);
                        cmd.Parameters.AddWithValue("@WarehouseID", Convert.ToInt32(WarehouseID));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Warehouse Updated Successfully...");

                            // Clear text boxes after update
                            ClearWarehouseFields();
                        }
                        else
                        {
                            MessageBox.Show("Warehouse not Found or Update Failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // add warehouse
        private void Btn_Warehouse_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_warehouse_Name.Text) || string.IsNullOrEmpty(cb_wareHouse_status.Text) ||
                    string.IsNullOrEmpty(cb_wareHouse_category.Text) || string.IsNullOrEmpty(txt_warehouse_Width.Text) ||
                    string.IsNullOrEmpty(txt_warehouse_Length.Text) || string.IsNullOrEmpty(txt_warehouse_Height.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string query = "INSERT INTO WareHouseINFO.Warehouse (Name, Status, Category , WarehouseWidth, WarehouseLength, WarehouseHeight, TotalArea) " +
                                   "VALUES (@Name, @Status, @Category, @WarehouseWidth, @WarehouseLength, @WarehouseHeight, @totalArea)";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Name"             , txt_warehouse_Name.Text);
                        cmd.Parameters.AddWithValue("@Status"           , cb_wareHouse_status.Text);
                        cmd.Parameters.AddWithValue("@Category"         , cb_wareHouse_category.Text);
                        cmd.Parameters.AddWithValue("@WarehouseWidth"   , txt_warehouse_Width.Text);
                        cmd.Parameters.AddWithValue("@WarehouseLength"  , txt_warehouse_Length.Text);
                        cmd.Parameters.AddWithValue("@WarehouseHeight"  , txt_warehouse_Height.Text);
                        cmd.Parameters.AddWithValue("@totalArea"        , lbl_count_total_area.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Warehouse Registered Successfully...");
                            ClearWarehouseFields();
                            TotalWareHouses();
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed. Try Again...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // delete warehouse 
        private void Btn_Warehouse_Delete_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txt_warehouse_ID.Text))
                {
                    MessageBox.Show("Please enter a Warehouse ID.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this Warehouse?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                        {
                            sqlCon.Open();
                            string warehouseID = txt_warehouse_ID.Text;
                            string query = "DELETE FROM WareHouseINFO.Warehouse WHERE WarehouseID = @WarehouseID";

                            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                            {
                                cmd.Parameters.AddWithValue("@WarehouseID", Convert.ToInt32(warehouseID));

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Warehouse Deleted Successfully...");
                                    ClearWarehouseFields();
                                    TotalWareHouses();
                                }
                                else
                                {
                                    MessageBox.Show("Warehouse does not exist or Deletion Failed...");
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
        

        // Method to clear warehouse-related text boxes
        private void ClearWarehouseFields()
        {
            txt_warehouse_Name.Text = "";
            cb_wareHouse_status.Text = "";
            cb_wareHouse_category.Text = "";
            txt_warehouse_Width.Text = "";
            txt_warehouse_Height.Text = "";
            txt_warehouse_Length.Text = "";
            txt_warehouse_ID.Text = "";
            lbl_count_total_area.Text = "0";
        }

        // Count total warehouses
        private void TotalWareHouses()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM WareHouseINFO.Warehouse WHERE Name IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        int totalCount = (int)cmd.ExecuteScalar();
                        lbl_count_warehouses.Text = $"{totalCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Calculate total area of warehouse
        private void TotalArea()
        {
            try
            {
                if (double.TryParse(txt_warehouse_Length.Text, out double length) && double.TryParse(txt_warehouse_Width.Text, out double width) && double.TryParse(txt_warehouse_Height.Text, out double height))
                {
                    double area = length * width * height;
                    lbl_count_total_area.Text = $"{area}";
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Length, Width & Height.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Btn_dock_View_Click(object sender, EventArgs e)
        {
            if (txt_dock_ID.Text == "")
            {
                MessageBox.Show("Please! Enter Dock ID.");
            }
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string dockID = txt_dock_ID.Text;
                    string warehouseID = txt_dock_warehouse_ID.Text;

                    string query = "SELECT d.Name AS DockName, d.Status AS DockStatus " +
                                   "FROM WareHouseINFO.Warehouse w " +
                                   "JOIN WareHouseINFO.Dock d ON w.WarehouseID = d.WarehouseID " +
                                   "WHERE w.WarehouseID = @WarehouseID " +
                                   "AND d.DockID = @DockID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseID", Convert.ToInt32(warehouseID));
                        cmd.Parameters.AddWithValue("@DockID", Convert.ToInt32(dockID));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_dock_Name.Text = (string)reader["DockName"];
                                cb_dock_status.Text = (string)reader["DockStatus"];
                                lbl_free_dock.Text = $"{GetDocksCountAtWarehouse(Convert.ToInt32(warehouseID))}";
                                lbl_busy_dock.Text = $"{GetDocksCountAtWarehouseBusy(Convert.ToInt32(warehouseID))}";

                            }
                            else
                            {
                                MessageBox.Show("Dock not found for the provided IDs.");
                                // You may want to clear the textboxes or take appropriate action here.
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Helper method to get dock count at a warehouse
        public int GetDocksCountAtWarehouse(int warehouseID)
        {
            int specificWarehouseDocksCount = 0;
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) AS DocksAtWarehouseCount FROM WarehouseINFO.Dock WHERE WarehouseID = @WarehouseID AND Status = 'Free' ";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@WarehouseID", warehouseID);
                    specificWarehouseDocksCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Handle exception, log, or show an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return specificWarehouseDocksCount;
        }

        public int GetDocksCountAtWarehouseBusy(int warehouseID)
        {
            int specificWarehouseDocksCount = 0;
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) AS DocksAtWarehouseCount FROM WarehouseINFO.Dock WHERE WarehouseID = @WarehouseID AND Status = 'Busy' ";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@WarehouseID", warehouseID);
                    specificWarehouseDocksCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Handle exception, log, or show an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return specificWarehouseDocksCount;
        }


        private void Btn_dock_Update_Click(object sender, EventArgs e)
        {
            if (!AreFieldsValid())
            {
                return;
            }
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string dockID = txt_dock_ID.Text;
                    string warehouseID = txt_dock_warehouse_ID.Text;
                    string dockName = txt_dock_Name.Text;
                    string dockStatus = cb_dock_status.Text;

                    string query = "UPDATE WareHouseINFO.Dock " +
                                   "SET Name = @DockName, Status = @DockStatus " +
                                   "WHERE DockID = @DockID AND WarehouseID = @WarehouseID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@DockName", dockName);
                        cmd.Parameters.AddWithValue("@DockStatus", dockStatus);
                        cmd.Parameters.AddWithValue("@DockID", Convert.ToInt32(dockID));
                        cmd.Parameters.AddWithValue("@WarehouseID", Convert.ToInt32(warehouseID));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dock Updated Successfully.");
                            // Clear text boxes after update
                            txt_dock_Name.Text = "";
                            cb_dock_status.Text = "";
                            txt_dock_ID.Text = "";
                            txt_dock_warehouse_ID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Dock Update Failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void Btn_dock_Add_Click(object sender, EventArgs e)
        {
            if (!AreFieldsValid())
            {
                return;
            }

            try
            {
                
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string dockName = txt_dock_Name.Text;
                    string dockStatus = cb_dock_status.Text;
                    string warehouseID = txt_dock_warehouse_ID.Text;

                    string query = "INSERT INTO WareHouseINFO.Dock (WarehouseID, Name, Status) " +
                                   "VALUES (@WarehouseID, @DockName, @DockStatus)";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseID", Convert.ToInt32(warehouseID));
                        cmd.Parameters.AddWithValue("@DockName", dockName);
                        cmd.Parameters.AddWithValue("@DockStatus", dockStatus);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dock Added Successfully.");
                            // Clear text boxes after insertion
                            txt_dock_Name.Text = "";
                            cb_dock_status.Text = "";
                            txt_dock_ID.Text = "";
                            txt_dock_warehouse_ID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Dock Addition Failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void Btn_dock_Delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_dock_ID.Text, out int dockid) || dockid <= 0)
            {
                MessageBox.Show("Please! Provide the Dock ID.");
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string dockID = txt_dock_ID.Text;

                    string query = "DELETE FROM WareHouseINFO.Dock " +
                                   "WHERE DockID = @DockID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@DockID", Convert.ToInt32(dockID));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dock Deleted Successfully.");
                            // Clear text boxes after deletion
                            txt_dock_Name.Text = "";
                            cb_dock_status.Text = "";
                            txt_dock_ID.Text = "";
                            txt_dock_warehouse_ID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Dock Deletion Failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        public int GetTotalWarehouseCount()
        {
            int totalWarehouseCount = 0;
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS TotalWarehouseCount FROM WarehouseINFO.Warehouse", sqlCon);
                    totalWarehouseCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Handle exception, log, or show an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return totalWarehouseCount;
        }



        private bool AreFieldsValid()
        {
            if (txt_dock_Name.Text == "")
            {
                MessageBox.Show("Please! Fill Dock Name");
                return false;
            }
            if (cb_dock_status.Text == "")
            {
                MessageBox.Show("Please! Select the dock Status");
                return false;

            }
            if (!int.TryParse(txt_dock_warehouse_ID.Text, out int warehouseid) || warehouseid <= 0)
            {
                MessageBox.Show("Please! Provide Warehouse ID");
                return false;
            }
            return true;
        }



    }
}
