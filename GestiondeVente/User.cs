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
    public partial class User : Form
       
    {
        DataTable dt;
        int currRowIndex;
        MySqlDataAdapter da;

        Connexion conx = new Connexion();

        public User()
        {
            InitializeComponent();
            GetUserList();
        }

        private void GetUserList()
        {
            conx.connexion();
            conx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from users", conx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            conx.cnxClose();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" || txt_mdp.Text == "" )
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    Users C = new Users(txt_nom.Text, txt_mdp.Text);
                    txt_nom.Clear();
                    txt_mdp.Clear();
                   
                    conx.connexion();
                    conx.cnxOpen();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(nom, motdepasse)" +
                        "VALUES(@nom, @motdepasse)", conx.connMaster);
                    cmd.Parameters.AddWithValue("@nom", C.Nom);
                    cmd.Parameters.AddWithValue("@motdepasse", C.Motdepasse);
                    
                    GetUserList();
                    cmd.ExecuteNonQuery();

                    conx.cnxClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        

    }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
            currRowIndex = Convert.ToInt32(row.Cells[0].Value);
            txt_nom.Text = row.Cells[1].Value.ToString();
            txt_mdp.Text = row.Cells[2].Value.ToString();
           


            btn_Modifier.Enabled = true;
            btn_Supprimer.Enabled = true;
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdate = MessageBox.Show("voulez-vous vraiment modifier les informations sur cet utilisateur ", "Modifier un utilisateur", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogUpdate == DialogResult.OK)
            {

                if (txt_nom.Text == "" || txt_mdp.Text == "" )
                {
                    DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;

                    conx.connexion();
                    conx.cnxOpen();



                    MySqlCommand cmd = new MySqlCommand("UPDATE users SET nom= @nom, motdepasse=@motdepasse" +
                        " WHERE id=" + currRowIndex, conx.connMaster);
                    cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                    cmd.Parameters.AddWithValue("@motdepasse", txt_mdp.Text);
                    
                    cmd.Parameters.AddWithValue("@id", currRowIndex);
                    GetUserList();
                    cmd.ExecuteNonQuery();
                    conx.cnxClose();
                    txt_nom.Clear(); txt_mdp.Clear();
                    btn_Modifier.Enabled = false;
                    btn_Supprimer.Enabled = false;

                }
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {

            int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;

            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer cet utilisateur", "Supprimer un utilisateur", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                guna2DataGridView1.Rows.RemoveAt(rowIndex);
                btn_Modifier.Enabled = false;
                btn_Supprimer.Enabled = false;

                conx.cnxOpen();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id=" + currRowIndex, conx.connMaster);
                GetUserList();
                cmd.ExecuteNonQuery();
                conx.cnxClose();
            }
            }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

            conx.connexion();
            conx.cnxOpen();
            MySqlCommand Command = new MySqlCommand("select * from users where nom like '%" + txt_nom.Text + "%';", conx.connMaster);
            Command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(Command);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            conx.cnxClose();
        }
    }
}
