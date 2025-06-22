using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FurnitureAppVS9
{
    public partial class EditFurnitureForm : Form
    {
        private int furnitureId;
        string connectionString = "Server=localhost;Port=3306;Database=furniture_store;Uid=root;Pwd=newpassword;";

        public EditFurnitureForm(int id)
        {
            InitializeComponent();
            furnitureId = id;
        }

        private void EditFurnitureForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Furniture WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", furnitureId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtType.Text = reader["Type"].ToString();
                        txtBrand.Text = reader["Brand"].ToString();
                        txtManufacturer.Text = reader["Manufacturer"].ToString();
                        txtSupplier.Text = reader["Supplier"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE Furniture SET 
                                Type = @type, 
                                Brand = @brand, 
                                Manufacturer = @manuf, 
                                Supplier = @supp, 
                                Price = @price 
                                WHERE ID = @id";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@type", txtType.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@manuf", txtManufacturer.Text);
                cmd.Parameters.AddWithValue("@supp", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@id", furnitureId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Запис оновлено успішно!");
                this.Close();
            }
        }
    }
}
