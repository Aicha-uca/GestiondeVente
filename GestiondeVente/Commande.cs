using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            double prix = 0;
            if (guna2TextBox2.Text == "" || txt_nom.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cnx.connexion();
                    cnx.cnxOpen();
                    MySqlCommand Command = new MySqlCommand("select * from produit where id =" + id_produit, cnx.connMaster);
                    MySqlDataReader dr = Command.ExecuteReader();
                    while (dr.Read())
                    {

                        prix = Convert.ToDouble(dr["prix"]);


                    }
                    cnx.cnxClose();

                    double total = prix * Convert.ToDouble(guna2TextBox2.Text);

                    Commandes command = new Commandes(txt_nom.Text, id_produit, guna2DateTimePicker1.Value, Convert.ToInt16(guna2TextBox2.Text), total);

                    txt_nom.Clear();
                    guna2TextBox2.Clear();

                    cnx.connexion();
                    cnx.cnxOpen();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO commande (client_email,produit_id,date_cmd,quantite,total) VALUES (@client_email,@produit_id,@date_cmd,@quantite,@total)", cnx.connMaster);
                    cmd.Parameters.AddWithValue("@client_email", command.Cl_email);
                    cmd.Parameters.AddWithValue("@produit_id", command.Prod_id);
                    cmd.Parameters.AddWithValue("@date_cmd", command.Date_commande);
                    cmd.Parameters.AddWithValue("@quantite", command.Quantite);
                    cmd.Parameters.AddWithValue("@total", command.Total);

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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            double total = 0;
            int total_produit = 0;


            cnx.connexion();
            cnx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from commande", cnx.connMaster);
            MySqlDataReader dr = Command.ExecuteReader();
            while (dr.Read())
            {

                total_produit += Convert.ToInt32(dr["quantite"]);
                total += Convert.ToDouble(dr["total"]);


            }

            cnx.cnxClose();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            /* printPreviewDialog1.Document = printDocument1;
             printPreviewDialog1.ShowDialog();
            */
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Facture des Commandes";
            p.SubTitle = string.Format("Date:{0}", DateTime.Now);
           

            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            p.PreviewDialog = printPreviewDialog1;
           // p.printDocument = printDocument1;
            p.PageNumbers = true;
            p.PorportionalColumns = true;

            p.HeaderCellAlignment = StringAlignment.Near;

            p.Footer = "";

            p.FooterSpacing = 15;
            p.PrintPreviewDataGridView(guna2DataGridView1);
        }

       /* private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FACTURE", new Font("Arial", 20, FontStyle.Bold), Brushes.PeachPuff, new Point(400, 10));
            e.Graphics.DrawString("Rapport du facture", new Font("Arial", 18, FontStyle.Bold), Brushes.PeachPuff, new Point(10, 40));

            e.Graphics.DrawString("nom".ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Aqua, new Point(10, 150));
            e.Graphics.DrawString("| Quantite".ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Aqua, new Point(500, 150));

            e.Graphics.DrawString("________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 180));

            cnx.connexion();
            cnx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select c.id, p.nom ,c.quantite from commande c, produit p where c.produit_id=p.id order by c.quantite limit 5", cnx.connMaster);
            MySqlDataReader dr = Command.ExecuteReader();
            int i = 210;
            while (dr.Read())
            {

                e.Graphics.DrawString("_________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, i));

                e.Graphics.DrawString(dr["nom"].ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Aqua, new Point(10, i + 3));
                e.Graphics.DrawString("|" + dr["quantite"].ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Aqua, new Point(500, i + 3));

                i += 30;

            }

            cnx.cnxClose();



        }*/

       
    }
}
