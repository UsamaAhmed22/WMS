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
    public partial class ProductInformation : Form
    {
        private readonly string connectTo_WMS_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WMS.mdf;Integrated Security=True";

        public ProductInformation()
        {
            InitializeComponent();
        }

        private void ProductInformation_Load(object sender, EventArgs e)
        {
            PopulateCompanyComboBox();
        }

        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            _ = new WMS_Manager
            {
                Visible = true
            };
            this.Close();
        }

        private void Btn_Product_Update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_product_ID.Text, out _))
            {
                MessageBox.Show("Please! Provide Valid Input.");
                return;
            }

            if (!AreFieldsValid())
            {
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    string compName     = cb_company_ID.Text;
                    string productID    = txt_product_ID.Text;
                    string name         = txt_product_name.Text;
                    string weight       = txt_product_Weight.Text;
                    string barcode      = txt_product_BarcodeNo.Text;
                    string handling     = txt_product_SpecialHandling.Text;
                    string description  = txt_product_description.Text;
                    string width        = txt_product_Width.Text;
                    string length       = txt_product_Length.Text;
                    string height       = txt_product_Height.Text;
                    string area         = (Convert.ToDouble(width) * Convert.ToDouble(length) * Convert.ToDouble(height)).ToString(); // Calculate area in cm cube
                    string rateSize     = txt_Rate_Size.Text;
                    string rateWeight   = txt_WeightRate.Text;
                    string rateOneDay   = (Convert.ToDouble(rateSize) + Convert.ToDouble(rateWeight)).ToString();

                    sqlCon.Open();

                    string query = @"UPDATE ProductINFO.Products 
                            SET Name = @Name, Weight = @Weight, BarCodeNo = @Barcode, ProductHandling = @Handling, Description = @Description, 
                            ProductWidth = @Width, ProductLength = @Length, ProductHeight = @Height, AreaCmSq = @Area, SizeRate = @RateSize, WeightRate = @RateWeight, 
                            OneDayRate = @RateOneDay, CompanyName = @compName
                            WHERE ProductID = @ProductID";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@Name"         , name);
                    cmd.Parameters.AddWithValue("@Weight"       , weight);
                    cmd.Parameters.AddWithValue("@Barcode"      , barcode);
                    cmd.Parameters.AddWithValue("@Handling"     , handling);
                    cmd.Parameters.AddWithValue("@Description"  , description);
                    cmd.Parameters.AddWithValue("@Width"        , width);
                    cmd.Parameters.AddWithValue("@Length"       , length);
                    cmd.Parameters.AddWithValue("@Height"       , height);
                    cmd.Parameters.AddWithValue("@Area"         , area);
                    cmd.Parameters.AddWithValue("@RateSize"     , rateSize);
                    cmd.Parameters.AddWithValue("@RateWeight"   , rateWeight);
                    cmd.Parameters.AddWithValue("@RateOneDay"   , rateOneDay);
                    cmd.Parameters.AddWithValue("@ProductID"    , productID);
                    cmd.Parameters.AddWithValue("@compName", compName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.");
                        ClearProductFields();
                    }
                    else
                    {
                        MessageBox.Show("Product update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearProductFields()
        {
            cb_company_ID.SelectedIndex = -1;
            txt_product_ID.Text = "";
            txt_product_name.Text = "";
            txt_product_Weight.Text = "";
            txt_product_BarcodeNo.Text = "";
            txt_product_SpecialHandling.Text = "";
            txt_product_description.Text = "";
            txt_product_Width.Text = "";
            txt_product_Length.Text = "";
            txt_product_Height.Text = "";
            txt_Rate_Size.Text = "";
            txt_WeightRate.Text = "";
            txt_Rate_OneDay.Text = "";
            txt_product_Area.Text = "";
        }

        private void Btn_Product_view_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_product_ID.Text, out _))
            {
                MessageBox.Show("Please! Provide Valid Input.");
                return;
            }

            SqlDataReader reader = null;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
                {
                    sqlCon.Open();
                    string productID = txt_product_ID.Text;

                    string query = "SELECT * FROM ProductINFO.Products WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_product_name.Text               = reader["Name"].ToString();
                        txt_product_Weight.Text             = reader["Weight"].ToString();
                        txt_product_BarcodeNo.Text          = reader["BarCodeNo"].ToString();
                        txt_product_SpecialHandling.Text    = reader["ProductHandling"].ToString();
                        txt_product_description.Text        = reader["Description"].ToString();
                        txt_product_Width.Text              = reader["ProductWidth"].ToString();
                        txt_product_Length.Text             = reader["ProductLength"].ToString();
                        txt_product_Height.Text             = reader["ProductHeight"].ToString();
                        txt_product_Area.Text               = reader["AreaCmSq"].ToString();
                        txt_Rate_Size.Text                  = reader["SizeRate"].ToString();
                        txt_WeightRate.Text                 = reader["WeightRate"].ToString();
                        txt_Rate_OneDay.Text                = reader["OneDayRate"].ToString();
                        cb_company_ID.Text                  = reader["CompanyName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                        ClearProductFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }

        private void Btn_Product_Add_Click(object sender, EventArgs e)
        {
            if (!AreFieldsValid())
            {
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    sqlCon.Open();

                    double area = (Convert.ToDouble(txt_product_Width.Text) * Convert.ToDouble(txt_product_Length.Text) * Convert.ToDouble(txt_product_Height.Text));
                    double rateOneDay = (Convert.ToDouble(txt_Rate_Size.Text) + Convert.ToDouble(txt_WeightRate.Text));

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO ProductINFO.Products 
                        (Name, Weight, BarCodeNo, ProductHandling, Description, ProductWidth, ProductLength, ProductHeight, AreaCmSq, SizeRate, WeightRate, OneDayRate, CompanyName)
                        VALUES 
                        (@Name, @Weight, @Barcode, @Handling, @Description, @Width, @Length, @Height, @Area, @RateSize, @RateWeight, @RateOneDay, @CompanyName)", sqlCon);

                    cmd.Parameters.AddWithValue("@Name"         , txt_product_name.Text);
                    cmd.Parameters.AddWithValue("@Weight"       , txt_product_Weight.Text);
                    cmd.Parameters.AddWithValue("@Barcode"      , txt_product_BarcodeNo.Text);
                    cmd.Parameters.AddWithValue("@Handling"     , txt_product_SpecialHandling.Text);
                    cmd.Parameters.AddWithValue("@Description"  , txt_product_description.Text);
                    cmd.Parameters.AddWithValue("@Width"        , txt_product_Width.Text);
                    cmd.Parameters.AddWithValue("@Length"       , txt_product_Length.Text);
                    cmd.Parameters.AddWithValue("@Height"       , txt_product_Height.Text);
                    cmd.Parameters.AddWithValue("@Area"         , area);
                    cmd.Parameters.AddWithValue("@RateSize"     , txt_Rate_Size.Text);
                    cmd.Parameters.AddWithValue("@RateWeight"   , txt_WeightRate.Text);
                    cmd.Parameters.AddWithValue("@RateOneDay"   , rateOneDay);
                    cmd.Parameters.AddWithValue("@CompanyName"  , cb_company_ID.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully.");
                        // Clear input fields after successful addition
                        ClearProductFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Btn_Product_Delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_product_ID.Text, out _))
            {
                MessageBox.Show("Please! Provide Valid Input.");
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB))
            {
                try
                {
                    string productID = txt_product_ID.Text;

                    sqlCon.Open();
                    string query = "DELETE FROM ProductINFO.Products WHERE ProductID = @ProductID";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                        // Clear input fields after successful deletion
                        ClearProductFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product. Product ID might be invalid.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void PopulateCompanyComboBox()
        {
            SqlConnection sqlCon = new SqlConnection(connectTo_WMS_DB);

            try
            {
                sqlCon.Open();

                string query = "SELECT DISTINCT Name FROM ShipmentINFO.Company";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cb_company_ID.Items.Add(reader["Name"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching company data: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }



        //tocheck the field are not in negative numbers 
        private bool AreFieldsValid()
        {
            if(txt_product_name.Text == "")
            {
                MessageBox.Show("Please! Fill Product Name");
                return false;
            }
            if (txt_product_SpecialHandling.Text == "")
            {
                MessageBox.Show("Please! Fill Special Handling");
                return false;

            }
            if (txt_product_description.Text == "")
            {
                MessageBox.Show("Please! Fill Description");
                return false;
            }
            if (cb_company_ID.Text == "")
            {
                MessageBox.Show("Please! Select Company");
                return false;
            }

            if (txt_product_BarcodeNo.Text =="")
            {
                MessageBox.Show("Please! Fill Barcode No");
                return false;
            }

            if (!float.TryParse(txt_product_Weight.Text, out float weight) || weight <= 0)
            {
                MessageBox.Show("Please! Fill Weight");
                return false;
            }

            if (!float.TryParse(txt_product_Height.Text, out float Height) || Height <= 0)
            {
                MessageBox.Show("Please! Fill Product Height");
                return false;
            }

            if (!float.TryParse(txt_product_Length.Text, out float length) || length <= 0)
            {
                MessageBox.Show("Please! Fill Product Length");
                return false;
            }

            if (!float.TryParse(txt_product_Width.Text, out float width) || width <= 0)
            {
                MessageBox.Show("Please! Fill Product Width");
                return false;
            }

            if (!float.TryParse(txt_Rate_Size.Text, out float rateSize) || rateSize <= 0)
            {
                MessageBox.Show("Please! Fill Rate against Area");
                return false;
            }

            if (!float.TryParse(txt_WeightRate.Text, out float rateWeigth) || rateWeigth <= 0)
            {
                MessageBox.Show("Please! Fill Rate against Weight");
                return false;
            }

            return true;
        }





    }
}
