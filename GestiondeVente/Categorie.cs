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
    public partial class Categorie : Form
    {

        // string parametres = "SERVER=localhost; DATABASE=gestionvente; UID=root; PASSWORD=";
        // private MySqlConnection conx;

        DataTable dt;
        int currRowIndex;
        MySqlDataAdapter da;

        Connexion conx = new Connexion();

        public Categorie()
        {
            InitializeComponent();
          GetCategorieList();
        }
           private void GetCategorieList()
            {
            conx.connexion();
            conx.cnxOpen();
                MySqlCommand Command = new MySqlCommand("select * from categorie", conx.connMaster);
                Command.ExecuteNonQuery();
              dt = new DataTable();
              da = new MySqlDataAdapter(Command);
              da.Fill(dt);
              guna2DataGridView1.DataSource = dt;
              conx.cnxClose();


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
            currRowIndex = Convert.ToInt32(row.Cells[0].Value);
            txt_code.Text = row.Cells[1].Value.ToString();
            txt_libelle.Text = row.Cells[2].Value.ToString();


            guna2GradientButton2.Enabled = true;
            guna2GradientButton3.Enabled = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "" || txt_libelle.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    conx.connexion();
                    conx.cnxOpen();
                    Categories C = new Categories(txt_code.Text, txt_libelle.Text);

                    txt_code.Clear(); txt_libelle.Clear();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO categorie(code,libelle)" +
                        "VALUES(@code, @libelle)", conx.connMaster);
                    cmd.Parameters.AddWithValue("@code", C.Code);
                    cmd.Parameters.AddWithValue("@libelle", C.Libelle);

                    GetCategorieList();
                    cmd.ExecuteNonQuery();
                    conx.cnxClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdate = MessageBox.Show("voulez-vous vraiment modifier les informations sur cette categorie ", "Modifier une categorie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogUpdate == DialogResult.OK)
            {

                if (txt_code.Text == "" ||txt_libelle.Text == "" )
                {
                    DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;


                    conx.connexion();
                    conx.cnxOpen();

                    MySqlCommand cmd = new MySqlCommand("UPDATE categorie SET code= @code, libelle=@libelle" +
                        " WHERE id=" + currRowIndex, conx.connMaster);
                    cmd.Parameters.AddWithValue("@code", txt_code.Text);
                    cmd.Parameters.AddWithValue("@libelle", txt_libelle.Text);
                    GetCategorieList();

                    cmd.ExecuteNonQuery();
                    conx.cnxClose();
                    txt_code.Clear(); txt_libelle.Clear(); 
                    guna2GradientButton2.Enabled = false;
                    guna2GradientButton3.Enabled = false;

                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;

            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer cette categorie", "Supprimer une categorie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                guna2DataGridView1.Rows.RemoveAt(rowIndex);
                guna2GradientButton2.Enabled = false;
                guna2GradientButton3.Enabled = false;
                conx.cnxOpen();

                MySqlCommand cmd= new MySqlCommand("DELETE FROM categorie WHERE id=" + currRowIndex, conx.connMaster);
                GetCategorieList();
                cmd.ExecuteNonQuery();
                conx.cnxClose();

            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
