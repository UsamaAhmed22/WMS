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
    public partial class R_P_Manager : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public R_P_Manager()
        {
            InitializeComponent();
            LoadOverallShipments();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            _ = new login
            {
                Visible = true
            };
            this.Close();
        }

        private void Tab_overall_Click(object sender, EventArgs e)
        {
            LoadOverallShipments();
        }

        private void R_P_Manager_Load(object sender, EventArgs e)
        {
            LoadOverallShipments();
        }
        private void LoadOverallShipments()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string query = @"SELECT s.ShipmentID AS 'Shipment ID', s.WarehouseID AS 'Warehouse ID', s.DockID AS 'Dock ID',
                             v.RegistrationNo AS 'Vehicle Registration No', s.Date AS 'Arrival Date', c.Name AS 'Company Name'
                             FROM ShipmentINFO.Shipment s
                             JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                             JOIN ShipmentINFO.Company c ON s.CompanyID = c.CompanyID
                             WHERE s.Status = 'At Receiving' AND s.ShipmentStatus = 'Arrival'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        grid_View_Overall.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading shipments: " + ex.Message);
                }
            }
        }


        private void ViewShipmentAndBillDetails(int shipmentID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string shipmentQuery = @"SELECT S.WarehouseID, S.CompanyID, S.DockID, V.RegistrationNo AS 'Vehicle Registration', S.Date AS ArrivalDate ,C.Name AS 'Company Name'
                                     FROM ShipmentINFO.Shipment S
									 JOIN ShipmentINFO.Vehicle V ON S.VehicleID = V.VehicleID
									 JOIN ShipmentINFO.Company C ON S.CompanyID = C.CompanyID
                                     WHERE ShipmentID = @ShipmentID AND ShipmentStatus = 'Arrival' AND Status = 'At Receiving'";

                    using (SqlCommand shipmentCmd = new SqlCommand(shipmentQuery, sqlCon))
                    {
                        shipmentCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        using (SqlDataReader shipmentReader = shipmentCmd.ExecuteReader())
                        {
                            if (shipmentReader.Read())
                            {
                                txt_warehouse_ID.Text = shipmentReader["WarehouseID"].ToString();
                                txt_company_ID.Text = shipmentReader["CompanyID"].ToString();
                                txt_dock_ID.Text = shipmentReader["DockID"].ToString();
                                txt_registration_No.Text = shipmentReader["Vehicle Registration"].ToString();
                                txt_comp_name.Text = shipmentReader["Company Name"].ToString();
                                txt_arrival_date.Text = Convert.ToDateTime(shipmentReader["ArrivalDate"]).ToString();
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
                    MessageBox.Show("An error occurred while viewing shipment details: " + ex.Message);
                }
            }
        }


        private void Btn_View_ASN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ASN_ID.Text, out int shipmentID))
            {
                ViewShipmentAndBillDetails(shipmentID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
            }
        }

        private void Btn_Successful_placement_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ASN_ID.Text, out int shipmentID))
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    try
                    {
                        sqlCon.Open();

                        string updateQuery = @"UPDATE ShipmentINFO.Shipment
                                       SET Status = 'Arrival Complete'
                                       WHERE ShipmentID = @ShipmentID AND ShipmentStatus = 'Arrival' AND Status = 'At Receiving'";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Status updated to Arrival Complete.");
                                LoadOverallShipments();
                            }
                            else
                            {
                                MessageBox.Show("No records updated. Shipment ID not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating shipment status: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
            }
        }
    }
}

