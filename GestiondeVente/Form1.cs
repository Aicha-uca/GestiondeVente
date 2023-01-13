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
using MySql.Data.MySqlClient;

namespace GestiondeVente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conx = new MySqlConnection("SERVER=localhost; DATABASE=gestionvente; UID=root; PASSWORD=");


        public void Login()
        {
            String query = "SELECT * from login where username= '" + txt_username.Text + "' and password='" + txt_password.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(query, conx);
            DataTable dataTable = new DataTable();
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conx.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                    }
                   Menu form2 = new Menu();
                   form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error");
                }
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Email")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.WhiteSmoke;
            }

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "password";
                txt_password.ForeColor = Color.Silver;
            }

        }

        private void txt_username_Leave(object sender, EventArgs e)
        {

            if (txt_username.Text == "")
            {
                txt_username.Text = "email";
                txt_username.ForeColor = Color.Silver;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
