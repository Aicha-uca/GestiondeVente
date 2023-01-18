using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GestiondeVente
{
    public partial class Client : Form
    {

        
        
        DataTable dt;
        int currRowIndex;
        MySqlDataAdapter da; 

        Connexion conx = new Connexion();
        
       


        public Client()
        {
            InitializeComponent();
           GetClientList();
        }
        private void GetClientList()
        {
            conx.connexion();
            conx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from client", conx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            conx.cnxClose();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" || txt_prenom.Text == "" || txt_adresse.Text == "" ||  txt_tel.Text == ""||txt_email.Text == "" )
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    Clients C = new Clients(txt_nom.Text, txt_prenom.Text, txt_adresse.Text, txt_tel.Text, txt_email.Text);
                txt_nom.Clear();
                txt_prenom.Clear();
                txt_adresse.Clear();
                txt_tel.Clear();
                txt_email.Clear();

                conx.connexion();
                conx.cnxOpen();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO client(nom, prenom, adresse, telephone, email)" +
                    "VALUES(@nom, @prenom,@adresse,@telephone, @email)", conx.connMaster);
                cmd.Parameters.AddWithValue("@nom", C.Nom);
                cmd.Parameters.AddWithValue("@prenom", C.Prenom);
                cmd.Parameters.AddWithValue("@adresse", C.Adresse);
                cmd.Parameters.AddWithValue("@telephone", C.Telephone);
                cmd.Parameters.AddWithValue("@email", C.Email);
                    GetClientList();
                    cmd.ExecuteNonQuery();

                conx.cnxClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdate = MessageBox.Show("voulez-vous vraiment modifier les informations sur ce Client ", "Modifier un Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogUpdate == DialogResult.OK)
            {

                if (txt_nom.Text == "" || txt_prenom.Text == "" || txt_adresse.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
                {
                    DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;

                    conx.connexion();
                    conx.cnxOpen();



                    MySqlCommand cmd = new MySqlCommand("UPDATE client SET nom= @nom, prenom=@prenom, adresse=@adresse, telephone=@telephone, email=@email" +
                        " WHERE id=" + currRowIndex, conx.connMaster);
                    cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                    cmd.Parameters.AddWithValue("@prenom",txt_prenom.Text);
                    cmd.Parameters.AddWithValue("@adresse", txt_adresse.Text);
                    cmd.Parameters.AddWithValue("@telephone",txt_tel.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@id", currRowIndex);
                    GetClientList();
                    cmd.ExecuteNonQuery();
                    conx.cnxClose();
                    txt_nom.Clear(); txt_prenom.Clear(); txt_adresse.Clear();txt_tel.Clear(); txt_email.Clear();
                    guna2GradientButton2.Enabled = false;
                    guna2GradientButton3.Enabled = false;

                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;

            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer ce Client", "Supprimer un Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                guna2DataGridView1.Rows.RemoveAt(rowIndex);
                guna2GradientButton2.Enabled = false;
                guna2GradientButton3.Enabled = false;
                
                conx.cnxOpen();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM client WHERE id=" + currRowIndex,conx.connMaster);
                GetClientList();
                cmd.ExecuteNonQuery();
                conx.cnxClose();

            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
            currRowIndex = Convert.ToInt32(row.Cells[0].Value);
            txt_nom.Text = row.Cells[1].Value.ToString();
            txt_prenom.Text = row.Cells[2].Value.ToString();
            txt_adresse.Text = row.Cells[3].Value.ToString();
            txt_email.Text = row.Cells[4].Value.ToString();
            txt_tel.Text = row.Cells[5].Value.ToString();


            guna2GradientButton2.Enabled = true;
            guna2GradientButton3.Enabled = true;
        }

       

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {

            conx.connexion();
            conx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from client where nom like '%" + txt_nom.Text + "%';", conx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            conx.cnxClose();
        }
    }
}
