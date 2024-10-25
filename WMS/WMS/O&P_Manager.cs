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
    public partial class O_P_Manager : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public O_P_Manager()
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

        private void O_P_Manager_Load(object sender, EventArgs e)
        {
            LoadOverallShipments();
        }

        private void Tab_particular_order_Click(object sender, EventArgs e)
        {

        }

        private void Tab_overall_Click(object sender, EventArgs e)
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
                             v.RegistrationNo AS 'Vehicle Registration No', s.Date AS 'Departure Date', c.Name AS 'Company Name'
                             FROM ShipmentINFO.Shipment s
                             JOIN ShipmentINFO.Vehicle v ON s.VehicleID = v.VehicleID
                             JOIN ShipmentINFO.Company c ON s.CompanyID = c.CompanyID
                             WHERE s.Status = 'At Order Placing' AND s.ShipmentStatus = 'Departure'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        grid_View_orders.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading shipments: " + ex.Message);
                }
            }
        }


        // Validate Shipment ID input before processing
        private bool ValidateShipmentID(string shipmentIDText, out int shipmentID)
        {
            if (!int.TryParse(shipmentIDText, out shipmentID) || shipmentID <= 0)
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return false;
            }
            return true;
        }





        private void Btn_View_Click(object sender, EventArgs e)
        {
            if (ValidateShipmentID(txt_OPN_ID.Text, out int shipmentID))
            {
                ViewShipmentAndBillDetails(shipmentID);
            }
        }




        private void ViewShipmentAndBillDetails(int shipmentID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    string shipmentQuery = @"SELECT S.WarehouseID, S.CompanyID, S.DockID, V.RegistrationNo AS 'Vehicle Registration', S.Date AS DepartureDate ,C.Name AS 'Company Name'
                                 FROM ShipmentINFO.Shipment S
								 JOIN ShipmentINFO.Vehicle V ON S.VehicleID = V.VehicleID
								 JOIN ShipmentINFO.Company C ON S.CompanyID = C.CompanyID
                                 WHERE ShipmentID = @ShipmentID AND ShipmentStatus = 'Departure' AND Status = 'At Order Placing'";

                    using (SqlCommand shipmentCmd = new SqlCommand(shipmentQuery, sqlCon))
                    {
                        shipmentCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        using (SqlDataReader shipmentReader = shipmentCmd.ExecuteReader())
                        {
                            if (shipmentReader.Read())
                            {
                                txt_warehouse_ID.Text = shipmentReader["WarehouseID"].ToString();
                                txt_company_ID.Text = shipmentReader["CompanyID"].ToString();
                                txt_Dock_ID.Text = shipmentReader["DockID"].ToString();
                                txt_Vehicle_ID.Text = shipmentReader["Vehicle Registration"].ToString();
                                txt_Company_name.Text = shipmentReader["Company Name"].ToString();
                                txt_OPN_date.Text = Convert.ToDateTime(shipmentReader["DepartureDate"]).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Order ID not found.");
                                Clear();
                                return;
                            }
                        }
                    }

                    // Fetch BillDetails data for the given ShipmentID
                    string billDetailsQuery = @"SELECT p.ProductID, p.Name AS 'Product Name', bd.Quantity, p.Weight, p.ProductWidth , p.ProductLength , p.ProductHeight , p.ProductHandling AS 'Special Handling'
                                    FROM ProductINFO.Products p
                                    JOIN ProductINFO.BillDetails bd ON p.ProductID = bd.ProductID
                                    WHERE bd.BillID IN (SELECT BillID FROM ShipmentINFO.Shipment WHERE ShipmentID = @ShipmentID)";

                    using (SqlCommand billDetailsCmd = new SqlCommand(billDetailsQuery, sqlCon))
                    {
                        billDetailsCmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(billDetailsCmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            grid_View_OPN_Mnager.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void Btn_Successfully_Load_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_OPN_ID.Text, out int shipmentID) || shipmentID <= 0)
            {
                MessageBox.Show("Please enter a valid Shipment ID.");
                return;
            }

            SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB);

            try
            {
                sqlCon.Open();

                string updateQuery = @"UPDATE ShipmentINFO.Shipment
                               SET Status = 'Order Complete'
                               WHERE ShipmentID = @ShipmentID AND ShipmentStatus = 'Departure' AND Status = 'At Order Placing'";

                SqlCommand cmd = new SqlCommand(updateQuery, sqlCon);
                cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Status updated to Departure Complete.");
                    LoadOverallShipments();
                    Clear();
                    // If needed, you can perform additional actions after the status update
                }
                else
                {
                    MessageBox.Show("No records updated. Order ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }


        private void Clear()
        {
            txt_OPN_ID.Text = "";
            txt_Company_name.Text = "";
            txt_company_ID.Text = "";
            txt_Dock_ID.Text = "";
            txt_OPN_date.Text = "";
            txt_Vehicle_ID.Text = "";
            txt_warehouse_ID.Text = "";
        }
    }
}
