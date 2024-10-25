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
    public partial class Dock_Manager : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public Dock_Manager()
        {
            InitializeComponent();
            DisplayArrivalShipmentsAtDock();
            LoadAllShipmentsOrder();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            _ = new login
            {
                Visible = true
            };
            this.Close();
        }

        private void Dock_Manager_Load(object sender, EventArgs e)
        {
            DisplayArrivalShipmentsAtDock();
            LoadAllShipmentsOrder();
        }


        //Arrival Unload Shipments
        private void Tab_arrival_Click(object sender, EventArgs e)
        {
            DisplayArrivalShipmentsAtDock();
        }


        private void Btn_View_arrival_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_shipment_No.Text, out int shipmentID) || shipmentID <= 0)
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT v.RegistrationNo AS 'Registration No', s.WarehouseID AS 'Warehouse No',
                                     s.DockID AS 'Dock Number', d.Status AS 'Dock Status'
                                     FROM ShipmentINFO.Shipment s
                                     JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                                     JOIN WareHouseINFO.Dock d ON s.DockID = d.DockID
                                     WHERE s.ShipmentID = @ShipmentID AND ShipmentStatus = 'Arrival' AND Status = 'At Dock'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_Vehciel_ID.Text = reader["Registration No"].ToString();
                                txt_Warehouse_No.Text = reader["Warehouse No"].ToString();
                                txt_dock_No.Text = reader["Dock Number"].ToString();
                                txt_dock_sta.Text = reader["Dock Status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Shipment ID not found.");
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


        private void Btn_send_to_dock_arrival_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_shipment_No.Text, out int shipmentID) || shipmentID <= 0)
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string updateShipmentStatusQuery = @"UPDATE ShipmentINFO.Shipment SET Status = 'At Receiving' WHERE ShipmentID = @ShipmentID  AND ShipmentStatus = 'Arrival' AND Status = 'At Dock'";
                    SqlCommand updateShipmentStatusCmd = new SqlCommand(updateShipmentStatusQuery, sqlCon);
                    updateShipmentStatusCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);
                    updateShipmentStatusCmd.ExecuteNonQuery();

                    string updateDockStatusQuery = @"UPDATE WareHouseINFO.Dock SET Status = 'Busy' WHERE DockID IN (SELECT DockID FROM ShipmentINFO.Shipment WHERE ShipmentID = @ShipmentID)";
                    SqlCommand updateDockStatusCmd = new SqlCommand(updateDockStatusQuery, sqlCon);
                    updateDockStatusCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);
                    updateDockStatusCmd.ExecuteNonQuery();

                    MessageBox.Show("Shipment At Receiving and Dock is Busy Now.");
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void Stay_here_arrival_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DisplayArrivalShipmentsAtDock()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT s.ShipmentID AS 'Shipment No', v.RegistrationNo AS 'Registration No', s.Date AS 'Date',
                                     v.DriverName AS 'Driver Name', c.Name AS 'Company Name'
                                     FROM ShipmentINFO.Shipment s
                                     JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                                     JOIN ShipmentINFO.Company c ON s.CompanyID = c.CompanyID
                                     WHERE s.ShipmentStatus = 'Arrival' AND s.Status = 'At Dock'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        grid_View_all_Shipments_arrival.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }






        //Departure Load Shipments

        private void Load_shipments_Click(object sender, EventArgs e)
        {
            LoadAllShipmentsOrder();
        }

        // view the order particular order in the details
        private void Btn_View_Order_shipments_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_Order_ID.Text, out int shipmentID) || shipmentID <= 0)
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT v.RegistrationNo, s.WarehouseID, s.DockID, d.Status AS 'Dock Status'
                             FROM ShipmentINFO.Shipment s
                             JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                             JOIN WareHouseINFO.Dock d ON s.DockID = d.DockID
                             WHERE s.ShipmentID = @ShipmentID AND ShipmentStatus = 'Departure' AND Status = 'At Dock' ";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_registration_no.Text = reader["RegistrationNo"].ToString();
                                txt_warehouse_ID.Text = reader["WarehouseID"].ToString();
                                txt_dock_ID.Text = reader["DockID"].ToString();
                                txt_Dock_status.Text = reader["Dock Status"].ToString();
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


        // this will clear the input fields
        private void Btn_stay_here_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //this will update the status to 'At Order placing' and make the dock busy
        private void Btn_SendToDock_Departure_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_Order_ID.Text, out int shipmentID) || shipmentID <= 0)
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string shipmentUpdateQuery = @"UPDATE ShipmentINFO.Shipment 
                                           SET Status = 'At Order Placing'
                                           WHERE ShipmentID = @ShipmentID  AND ShipmentStatus = 'Departure' AND Status = 'At Dock' ";

                    using (SqlCommand shipmentCmd = new SqlCommand(shipmentUpdateQuery, sqlCon))
                    {
                        shipmentCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);
                        shipmentCmd.ExecuteNonQuery();
                    }

                    string dockUpdateQuery = @"UPDATE WareHouseINFO.Dock 
                                       SET Status = 'Busy' 
                                       WHERE DockID = (
                                           SELECT DockID 
                                           FROM ShipmentINFO.Shipment 
                                           WHERE ShipmentID = @ShipmentID
                                       )";

                    using (SqlCommand dockCmd = new SqlCommand(dockUpdateQuery, sqlCon))
                    {
                        dockCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);
                        dockCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Shipment status updated to 'At Order Placing' and corresponding dock status set to 'Busy'.");
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        // dispaly al the watint order shipments
        private void LoadAllShipmentsOrder()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT s.ShipmentID AS 'Shipment ID', v.RegistrationNo AS 'Registration No', s.Date AS 'Date',
                                    v.DriverName AS 'Driver Name', c.Name AS 'Company Name'
                             FROM ShipmentINFO.Shipment s
                             JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                             JOIN ShipmentINFO.Company c ON s.CompanyID = c.CompanyID
                             WHERE s.Status = 'At Dock' AND s.ShipmentStatus = 'Departure'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        grid_View_All_Shipments_Order.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Clear()
        {
            txt_shipment_No.Text = "";
            txt_dock_sta.Text = "";
            txt_dock_No.Text = "";
            txt_dock_ID.Text = "";
            txt_Dock_status.Text = "";
            txt_Order_ID.Text = "";
            txt_registration_no.Text = "";
            txt_Vehciel_ID.Text = "";
            txt_warehouse_ID.Text = "";
            txt_Warehouse_No.Text = "";
        }
    }
}
