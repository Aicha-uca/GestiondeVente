using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeVente
{
    public partial class Produit : Form
    {
        DataTable dt;
        int currRowIndex;
        MySqlDataAdapter da;
        Byte[] img;

        Connexion conx = new Connexion();
        private static int id_produit;

        public Produit()
        {
            InitializeComponent();
            GetProduitsList();
            GetCategorieList();
        }
        private void GetProduitsList()
        {
            conx.connexion();
            conx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from produit", conx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            dt = dt.DefaultView.ToTable(true, "id", "nom", "quantite", "prix", "cat", "description");
            guna2DataGridView1.DataSource = dt;
            conx.cnxClose();
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

            cmb_categorie.DataSource = dt;
            cmb_categorie.DisplayMember = "libelle";

            conx.cnxClose();

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            

            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "|*.JPG;*.PNG; *.GIF;*.BMP ";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    image.Image = Image.FromFile(op.FileName);
                
                var ms = new MemoryStream();
                byte[] i = ms.ToArray();
                img = i;
            }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" || txt_description.Text == "" || txt_quantite.Text == "" || txt_prix.Text == "" || cmb_categorie.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Byte[] image = img;
                    Produits produits = new Produits(txt_nom.Text, Convert.ToInt32(txt_quantite.Text), Convert.ToDouble(txt_prix.Text), cmb_categorie.Text, txt_description.Text, image);


                    txt_nom.Clear();
                    txt_description.Clear();
                    txt_quantite.Clear();
                    txt_prix.Clear();

                    conx.connexion();
                    conx.cnxOpen();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO produit (nom,quantite,prix,cat,description,image) VALUES(@nom,@quantite,@prix,@categorie,@description,@image)", conx.connMaster);
                    cmd.Parameters.AddWithValue("@nom", produits.Nom);
                    cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(produits.Quantité));
                    cmd.Parameters.AddWithValue("@prix", Convert.ToDouble(produits.Prix));
                    cmd.Parameters.AddWithValue("@categorie", produits.Categorie);
                    cmd.Parameters.AddWithValue("@description", produits.Description);
                    cmd.Parameters.AddWithValue("@image", produits.Image);

                    cmd.ExecuteNonQuery();
                    GetProduitsList();
                    conx.cnxClose();


                    txt_nom.Clear();
                    txt_description.Clear();
                    txt_prix.Clear();
                    txt_quantite.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" || cmb_categorie.Text == "" || txt_description.Text == "" || txt_quantite.Text == "" || txt_prix.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int id_produit = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);

                    conx.connexion();
                    conx.cnxOpen();
                    MySqlCommand cmd = new MySqlCommand("update produit set nom =@nom,cat =@categorie ,description =@description,quantite =@quantite,prix =@prix where id = @id", conx.connMaster);

                    cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                    cmd.Parameters.AddWithValue("@categorie", cmb_categorie.Text);
                    cmd.Parameters.AddWithValue("@description", txt_description.Text);
                    cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(txt_quantite.Text));
                    cmd.Parameters.AddWithValue("@prix", Convert.ToDouble(txt_prix.Text));
                    cmd.Parameters.AddWithValue("@id", id_produit);
                    cmd.ExecuteNonQuery();
                    GetProduitsList();
                    GetCategorieList();
                    conx.cnxClose();

                    txt_nom.Clear();
                    txt_description.Clear();
                    txt_prix.Clear();
                    txt_quantite.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_produit = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
            txt_nom.Text = Convert.ToString(guna2DataGridView1.SelectedRows[0].Cells[1].Value);

            txt_quantite.Text = Convert.ToString(guna2DataGridView1.SelectedRows[0].Cells[2].Value);
            txt_prix.Text = Convert.ToString(guna2DataGridView1.SelectedRows[0].Cells[3].Value);
            cmb_categorie.SelectedItem = Convert.ToString(guna2DataGridView1.SelectedRows[0].Cells[4].Value);
            txt_description.Text = Convert.ToString(guna2DataGridView1.SelectedRows[0].Cells[5].Value);


            conx.connexion();
            conx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from produit where id =" + id_produit, conx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            dt = dt.DefaultView.ToTable(true, "image");


            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            image.Image = Image.FromStream(ms);
            image.SizeMode = PictureBoxSizeMode.StretchImage;

            conx.cnxClose();
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            GetProduitsList();
            GetCategorieList();
        }

        private void cmb_categorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int id_produit = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);


            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer ce produits", "Supprimer un produit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                conx.connexion();
                conx.cnxOpen();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM produit WHERE id = '" + id_produit + "'", conx.connMaster);
                cmd.ExecuteNonQuery();
                GetProduitsList();
                GetCategorieList();
                conx.cnxClose();

                
                txt_nom.Clear();
                txt_description.Clear();
                txt_prix.Clear();
                txt_quantite.Clear();
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            conx.cnxOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT * from produit ", conx.connMaster);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
    

}