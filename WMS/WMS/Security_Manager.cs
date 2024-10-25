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
    public partial class Security_Manager : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public Security_Manager()
        {
            InitializeComponent();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            _ = new login
            {
                Visible = true
            };
            this.Close();
           
        }


        private void Security_Manager_Load(object sender, EventArgs e)
        {
            LoadArrivalShipments();
            LoadDepartureShipments();
        }

        private void TabPage_Security_arrival_Click(object sender, EventArgs e)
        {
            LoadArrivalShipments();
        }

        private void TabPage_Security_departure_Click(object sender, EventArgs e)
        {
            LoadDepartureShipments();
        }


        // Shipment VIEW button
        private void Btn_View_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_shipmentID.Text, out int shipmentID))
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT V.RegistrationNo, V.DriverName, V.DriverCINC, V.Type AS VehicleType, S.Date, C.Name AS CompanyName
                             FROM ShipmentINFO.Shipment S
                             INNER JOIN ShipmentINFO.Vehicle V ON S.VehicleID = V.VehicleID
                             INNER JOIN ShipmentINFO.Company C ON S.CompanyID = C.CompanyID
                             WHERE S.ShipmentID = @ShipmentID AND S.ShipmentStatus= 'Arrival'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_vehicleNo.Text = reader["RegistrationNo"].ToString();
                            txt_DriverName.Text = reader["DriverName"].ToString();
                            txt_DriverCNIC.Text = reader["DriverCINC"].ToString();
                            txt_VehicleType.Text = reader["VehicleType"].ToString();
                            txt_ArrivingDate.Text = reader["Date"].ToString();
                            txt_Company.Text = reader["CompanyName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Shipment ID not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("A SQL error occurred: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        // Shipment on GRID VIEW function
        private void LoadArrivalShipments()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string query = @"SELECT s.ShipmentID AS 'Shipment No', RegistrationNo AS 'Vehicle Registration', Date AS 'Arrival Date',
                             DriverName AS 'Driver Name', c.Name AS 'Company Name'
                             FROM ShipmentINFO.Shipment s
                             JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                             JOIN ShipmentINFO.Company c ON s.CompanyID = c.CompanyID
                             WHERE s.Status = 'At the Way' AND s.ShipmentStatus = 'Arrival'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        grid_view_arrival_shipments.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A SQL error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // Shipment Gate Pass Button
        private void Btn_genertate_Gate_Pass_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_shipmentID.Text, out int shipmentID))
                {
                    MessageBox.Show("Please enter a valid Shipment ID.");
                    return;
                }

                // Update the status to 'At Dock'
                UpdateShipmentStatus(shipmentID, "At Dock");

                // Reload the grid view
                LoadArrivalShipments();

                // Clear the text boxes
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // Fucntion invoke when gate pass enter
        // this function update status of shipment At Dock
        private void UpdateShipmentStatus(int shipmentID, string newStatus)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"UPDATE ShipmentINFO.Shipment
                             SET Status = @NewStatus
                             WHERE ShipmentID = @ShipmentID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                        cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle sent to parking.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update shipment status.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        // This button only clear the Feilds
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            try
            {
                // Clear text boxes
                txt_shipmentID.Text = "";
                txt_vehicleNo.Text = "";
                txt_DriverName.Text = "";
                txt_DriverCNIC.Text = "";
                txt_VehicleType.Text = "";
                txt_ArrivingDate.Text = "";
                txt_Company.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing fields: " + ex.Message);
            }
        }













        // This func to GRID VIEW to display
        private void LoadDepartureShipments()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();

                    string query = @"SELECT s.ShipmentID AS 'Order No', RegistrationNo AS 'Vehicle Registration', Date AS 'Departure Date',
                         DriverName AS 'Driver Name', c.Name AS 'Company Name'
                         FROM ShipmentINFO.Shipment s
                         JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                         JOIN ShipmentINFO.Company c ON s.CompanyID = c.CompanyID
                         WHERE s.Status = 'At the Way' AND s.ShipmentStatus = 'Departure'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        grid_view_departure.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Order Gate Pass Function
        private void Btn_generate_gate_pass_departure_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_orderID.Text, out int OrderID))
                {
                    UpdateOrderStatus(OrderID, "At Dock");
                    LoadDepartureShipments();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Order ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void UpdateOrderStatus(int OrderID, string newStatus)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"UPDATE ShipmentINFO.Shipment
                             SET Status = @NewStatus
                             WHERE ShipmentID = @ShipmentID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                        cmd.Parameters.AddWithValue("@ShipmentID", OrderID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle Sent to Parking.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update shipment status.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void ClearForm()
        {
            try
            {
                txt_orderID.Text = "";
                txt_Vehicle_ID.Text = "";
                txt_driver_CNIC.Text = "";
                txt_departure_Date.Text = "";
                txt_driver_name.Text = "";
                txt_Vehcile_type.Text = "";
                txt_company_name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing the form: " + ex.Message);
            }
        }

        private void Btn_clear_order_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Btn_ORder_View_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_orderID.Text, out int orderID))
            {
                MessageBox.Show("Please enter a valid Order ID.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT V.RegistrationNo, V.DriverName, V.DriverCINC, V.Type AS VehicleType, S.Date, C.Name AS CompanyName
                             FROM ShipmentINFO.Shipment S
                             INNER JOIN ShipmentINFO.Vehicle V ON S.VehicleID = V.VehicleID
                             INNER JOIN ShipmentINFO.Company C ON S.CompanyID = C.CompanyID
                             WHERE S.ShipmentID = @ShipmentID AND S.ShipmentStatus= 'Departure'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@ShipmentID", orderID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_Vehicle_ID.Text = reader["RegistrationNo"].ToString();
                                txt_driver_name.Text = reader["DriverName"].ToString();
                                txt_driver_CNIC.Text = reader["DriverCINC"].ToString();
                                txt_Vehcile_type.Text = reader["VehicleType"].ToString();
                                txt_departure_Date.Text = reader["Date"].ToString();
                                txt_company_name.Text = reader["CompanyName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Order ID not found.");
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
    }
}
