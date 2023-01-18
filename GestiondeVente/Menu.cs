using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeVente
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u= new User();
            u.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.Show();
            this.Hide();
        }

        private void btn_Categorie_Click(object sender, EventArgs e)
        {
            Categorie c = new Categorie();
            c.Show();
            this.Hide();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
            this.Hide();


        }

        private void btn_Commande_Click(object sender, EventArgs e)
        {
            Commande c = new Commande();
            c.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Statistique s = new Statistique();
            s.Show();
            this.Hide();
        }
    }
}
