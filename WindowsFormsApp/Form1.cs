using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FurnitureAppVS9
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=furniture_store;Uid=root;Pwd=newpassword;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string search = "")
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Furniture";
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " WHERE Type LIKE @search OR Brand LIKE @search OR Manufacturer LIKE @search";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (!string.IsNullOrWhiteSpace(search))
                        cmd.Parameters.AddWithValue("@search", $"%{search}%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFurnitureForm addForm = new AddFurnitureForm();
            addForm.ShowDialog();
            LoadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(searchForm.SearchText);
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                EditFurnitureForm editForm = new EditFurnitureForm(id);
                editForm.ShowDialog();
                LoadData();
            }
        }
    }
}
