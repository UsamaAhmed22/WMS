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
    public partial class VehicleForm : Form
    {

        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public VehicleForm()
        {
            InitializeComponent();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            UpdateVehicleCount();

            cb_Vehicle_type.Items.Add("4 Wheeler Non-AC Trucks");
            cb_Vehicle_type.Items.Add("4 Wheeler AC Trucks");
            cb_Vehicle_type.Items.Add("6 Wheeler Non-AC Trucks");
            cb_Vehicle_type.Items.Add("6 Wheeler AC Trucks");
            cb_Vehicle_type.Items.Add("8 Wheeler Non-AC Trucks");
            cb_Vehicle_type.Items.Add("8 Wheeler AC Trucks");
            cb_Vehicle_type.Items.Add("10 Wheeler Non-AC Trucks");
            cb_Vehicle_type.Items.Add("10 Wheeler AC Trucks");
            cb_Vehicle_type.Items.Add("12 Wheeler Non-AC Trucks");
            cb_Vehicle_type.Items.Add("12 Wheeler AC Trucks");

            cb_Vehicle_Status.Items.Add("Active");
            cb_Vehicle_Status.Items.Add("InActive");

        }

        private void UpdateVehicleCount()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM ShipmentINFO.Vehicle WHERE RegistrationNo IS NOT NULL";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int vehicleCount = Convert.ToInt32(result);
                            lbl_Count_Vehicle.Text = vehicleCount.ToString();
                        }
                        else
                        {
                            // Handle the case where the result is null or DBNull.Value
                            lbl_Count_Vehicle.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            _ = new WMS_Manager
            {
                Visible = true
            };
            this.Close();
        }

        private void Btn_Vehicle_View_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string vehicleID = txt_vehcile_ID.Text;
                    string query = "SELECT Type, DriverName, RegistrationNo, DriverPhone, ManufacturerCompany, DriverCINC, VehicleStatus " +
                                   "FROM ShipmentINFO.Vehicle WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", Convert.ToInt32(vehicleID));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cb_Vehicle_type.Text = reader["Type"].ToString();
                                txt_vehcile_Driver_Name.Text = reader["DriverName"].ToString();
                                txt_vehcile_RegNo.Text = reader["RegistrationNo"].ToString();
                                txt_vehcile_Driver_Number.Text = reader["DriverPhone"].ToString();
                                txt_vehcile_ManVehicle.Text = reader["ManufacturerCompany"].ToString();
                                txt_vehcile_Driver_CNIC.Text = reader["DriverCINC"].ToString();
                                cb_Vehicle_Status.Text = reader["VehicleStatus"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Vehicle not Registered...");
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


        private void Btn_Vehicle_Create_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string query = "INSERT INTO ShipmentINFO.Vehicle (Type, DriverName, RegistrationNo, DriverPhone, ManufacturerCompany, DriverCINC, VehicleStatus) " +
                                   "VALUES (@Type, @DriverName, @RegNo, @DriverPhone, @ManComp, @DriverCNIC, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Type", cb_Vehicle_type.Text);
                        cmd.Parameters.AddWithValue("@DriverName", txt_vehcile_Driver_Name.Text);
                        cmd.Parameters.AddWithValue("@RegNo", txt_vehcile_RegNo.Text);
                        cmd.Parameters.AddWithValue("@DriverPhone", txt_vehcile_Driver_Number.Text);
                        cmd.Parameters.AddWithValue("@ManComp", txt_vehcile_ManVehicle.Text);
                        cmd.Parameters.AddWithValue("@DriverCNIC", txt_vehcile_Driver_CNIC.Text);
                        cmd.Parameters.AddWithValue("@Status", cb_Vehicle_Status.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle Registered Successfully...");

                            // Clear text boxes after insertion
                            txt_vehcile_ID.Text = "";
                            cb_Vehicle_type.Text = "";
                            txt_vehcile_Driver_Name.Text = "";
                            txt_vehcile_RegNo.Text = "";
                            txt_vehcile_Driver_Number.Text = "";
                            txt_vehcile_ManVehicle.Text = "";
                            txt_vehcile_Driver_CNIC.Text = "";
                            cb_Vehicle_Status.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed. Try Again...");
                        }
                    }
                }

                UpdateVehicleCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Btn_Vehicle_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string vehicleID = txt_vehcile_ID.Text;
                    string type = cb_Vehicle_type.Text;
                    string drivername = txt_vehcile_Driver_Name.Text;
                    string regNo = txt_vehcile_RegNo.Text;
                    string driverPhone = txt_vehcile_Driver_Number.Text;
                    string manComp = txt_vehcile_ManVehicle.Text;
                    string driverCNIC = txt_vehcile_Driver_CNIC.Text;
                    string status = cb_Vehicle_Status.Text;

                    string query = "UPDATE ShipmentINFO.Vehicle SET Type = @Type, DriverName = @DriverName, RegistrationNo = @RegNo, " +
                                   "DriverPhone = @DriverPhone, ManufacturerCompany = @ManComp, DriverCINC = @DriverCNIC, VehicleStatus = @Status " +
                                   "WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@DriverName", drivername);
                        cmd.Parameters.AddWithValue("@RegNo", regNo);
                        cmd.Parameters.AddWithValue("@DriverPhone", driverPhone);
                        cmd.Parameters.AddWithValue("@ManComp", manComp);
                        cmd.Parameters.AddWithValue("@DriverCNIC", driverCNIC);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@VehicleID", Convert.ToInt32(vehicleID));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle Updated Successfully.");

                            // Clear text boxes after update
                            txt_vehcile_ID.Text = "";
                            cb_Vehicle_type.Text = "";
                            txt_vehcile_Driver_Name.Text = "";
                            txt_vehcile_RegNo.Text = "";
                            txt_vehcile_Driver_Number.Text = "";
                            txt_vehcile_ManVehicle.Text = "";
                            txt_vehcile_Driver_CNIC.Text = "";
                            cb_Vehicle_Status.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Vehicle not Registered or Update Failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Btn_Vehicle_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string vehicleID = txt_vehcile_ID.Text;
                    string query = "DELETE FROM ShipmentINFO.Vehicle WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", Convert.ToInt32(vehicleID));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle Deleted Successfully...");
                            // Clear text boxes after deletion
                            txt_vehcile_ID.Text = "";
                            cb_Vehicle_type.Text = "";
                            txt_vehcile_Driver_Name.Text = "";
                            txt_vehcile_RegNo.Text = "";
                            txt_vehcile_Driver_Number.Text = "";
                            txt_vehcile_ManVehicle.Text = "";
                            txt_vehcile_Driver_CNIC.Text = "";
                            cb_Vehicle_Status.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Vehicle not Registered or Deletion Failed...");
                        }
                    }
                }

                UpdateVehicleCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
