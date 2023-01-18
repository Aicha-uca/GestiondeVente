using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeVente
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
            load_total();
            load_produit();
            load_client();
        }



        public void chart()
        {
            
            MySqlConnection conn = new MySqlConnection("Datasource=localhost;database=gestionvente;port=3306;username=root;password=");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("SELECT COUNT(*) FROM commande", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            
            double[] dataX = new double[count];
            double[] dataY = new double[count];
            var plt = new ScottPlot.Plot(610, 404);
            String[] labels = new String[count];
            String[] ord = new String[count];

            
            MySqlConnection conn2 = new MySqlConnection("Datasource=localhost;database=gestionvente;port=3306;username=root;password=");
            conn2.Open();
            MySqlCommand comm2 = new MySqlCommand("SELECT count(*) FROM commande group by client_email", conn2);
            MySqlDataReader rdr;

            rdr = comm2.ExecuteReader();     
            int i = 0;
            while (rdr.Read())
            {
                ord[i] = rdr.GetString(0); 
                i++;
            }

            conn2.Close();
            

            
            MySqlConnection conn3 = new MySqlConnection("Datasource=localhost;database=gestionvente;port=3306;username=root;password=");
            conn3.Open();
            MySqlCommand comm3 = new MySqlCommand("SELECT client_email FROM commande group by client_email", conn3);
            MySqlDataReader rdr3;

            rdr3 = comm3.ExecuteReader();     
            int j = 0;
            while (rdr3.Read())
            {
                labels[j] = rdr3.GetString(0); 
                j++;
            }

            conn3.Close();
            
            for (i = 0; i < count; i++)
            {
                dataY[i] = i;
            }
           
            for (i = 0; i < count; i++)
            {
                dataX[i] = Convert.ToInt32(ord[i]);
            }
            


            formsPlot1.Plot.AddBar(dataX, dataY, color: System.Drawing.Color.Pink);
            formsPlot1.Plot.XTicks(dataY, labels);
            formsPlot1.Plot.SetAxisLimits(yMin: 0);
            formsPlot1.Refresh();
        }
        public void load_total()
        {
            MySqlConnection conn = new MySqlConnection("Datasource=localhost;database=gestionvente;port=3306;username=root;password=");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("SELECT sum(total) FROM commande", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                label1.Text = Convert.ToString(count.ToString()) + " DHS";
            }
            else
            {
                label1.Text = "0 DHS";
            }
            conn.Close();
        }
        public void load_produit()
        {
            MySqlConnection conn = new MySqlConnection("Datasource=localhost;database=gestionvente;port=3306;username=root;password=");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("SELECT sum(quantite) FROM commande", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                label2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label2.Text = "0";
            }
            conn.Close();
        }
        public void load_client()
        {
            MySqlConnection conn = new MySqlConnection("Datasource=localhost;database=gestionvente;port=3306;username=root;password=");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("SELECT count(*) FROM client", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                label3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label3.Text = "0";
            }
            conn.Close();
        }
        private void Statistique_Load(object sender, EventArgs e)
        {
            chart();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
