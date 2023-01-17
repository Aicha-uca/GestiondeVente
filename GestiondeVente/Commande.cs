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

namespace GestiondeVente
{
    public partial class Commande : Form
    {
        Connexion cnx = new Connexion();
        MySqlDataAdapter da;
        DataTable dt;
        private static int id_produit;
        private static int id_command;
        public Commande()
        {
            InitializeComponent();
            GetCommandsList();
            GetProduitsList();
        }
        private void GetCommandsList()
        {

            cnx.connexion();
            cnx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from commande", cnx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            cnx.cnxClose();

        }
        private void GetProduitsList()
        {

            cnx.connexion();
            cnx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from produit", cnx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            dt = dt.DefaultView.ToTable(true, "id", "nom", "quantite", "prix", "cat", "description");
            guna2DataGridView2.DataSource = dt;
            cnx.cnxClose();

        }




        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_produit = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_command = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int id_command = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);


            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer cette commande", "Supprimer une commande", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                cnx.connexion();
                cnx.cnxOpen();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM commande WHERE id = '" + id_command + "'", cnx.connMaster);
                cmd.ExecuteNonQuery();
                GetProduitsList();
                GetCommandsList();
                cnx.cnxClose();

                txt_nom.Clear();
                guna2TextBox2.Clear();

            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "" || txt_nom.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    Commandes command = new Commandes(txt_nom.Text, id_produit, guna2DateTimePicker1.Value, Convert.ToInt16(guna2TextBox2.Text));

                    txt_nom.Clear();
                    guna2TextBox2.Clear();

                    cnx.connexion();
                    cnx.cnxOpen();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO commande (client_email,produit_id,date_cmd,quantite) VALUES (@client_email,@produit_id,@date_cmd,@quantite)", cnx.connMaster);
                    cmd.Parameters.AddWithValue("@client_email", command.Cl_email);
                    cmd.Parameters.AddWithValue("@produit_id", command.Prod_id);
                    cmd.Parameters.AddWithValue("@date_cmd", command.Date_commande);
                    cmd.Parameters.AddWithValue("@quantite", command.Quantite);
                   
                    cmd.ExecuteNonQuery();
                    cnx.cnxClose();

                    cnx.cnxOpen();
                    MySqlCommand cmd2 = new MySqlCommand("update produit set quantite = quantite - " + command.Quantite + " where id = @id", cnx.connMaster);
                    cmd2.Parameters.AddWithValue("@id", id_produit);
                    cmd2.ExecuteNonQuery();
                    cnx.cnxClose();
                    GetCommandsList();
                    GetProduitsList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
