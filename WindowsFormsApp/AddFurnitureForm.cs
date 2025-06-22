using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FurnitureAppVS9
{
    public partial class AddFurnitureForm : Form
    {
        // ПРАВИЛЬНИЙ рядок підключення для MySQL
        string connectionString = "Server=localhost;Port=3306;Database=furniture_store;Uid=root;Pwd=newpassword;";

        public AddFurnitureForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "" || txtBrand.Text == "" || txtManufacturer.Text == "" || txtSupplier.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Furniture (Type, Brand, Manufacturer, Supplier, Price) VALUES (@type, @brand, @manuf, @supp, @price)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@type", txtType.Text);
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@manuf", txtManufacturer.Text);
                    cmd.Parameters.AddWithValue("@supp", txtSupplier.Text);
                    cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Додано успішно!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }
    }
}
