using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FurnitureAppVS9
{
    public partial class OrderForm : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=furniture_store;Uid=root;Pwd=newpassword;";
        private DataTable furnitureTable;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadFurnitureList();
        }

        private void LoadFurnitureList()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT ID, Type, Brand FROM Furniture";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                furnitureTable = new DataTable();
                da.Fill(furnitureTable);

                comboFurniture.DisplayMember = "DisplayName";
                comboFurniture.ValueMember = "ID";

                furnitureTable.Columns.Add("DisplayName", typeof(string), "Type + ' (' + Brand + ')'");

                comboFurniture.DataSource = furnitureTable;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboFurniture.SelectedValue == null || string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            int furnitureId = Convert.ToInt32(comboFurniture.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (FurnitureID, CustomerName, Quantity, OrderDate) VALUES (@fid, @name, @qty, @date)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fid", furnitureId);
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@qty", numericQuantity.Value);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Замовлення оформлено.");
                this.Close();
            }
        }
    }
}
