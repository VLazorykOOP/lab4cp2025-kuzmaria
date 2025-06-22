using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FurnitureAppVS9
{
    public partial class LoginForm : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=furniture_store;Uid=root;Pwd=newpassword;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text); // у майбутньому: хеш

                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // не this.Hide()
                }
                else
                {
                    MessageBox.Show("Неправильний логін або пароль.");
                }
            }
        }

    }
}
