using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeVente
{
    internal class Commandes
    {
        private int id;
        private string cl_email;
        private int prod_id;
        private DateTime date_commande;
        private int quantite;
        private double total;

        public Commandes(string cl_email, int prod_id, DateTime date_commande, int quantite, double total)
        {
            
            this.cl_email = cl_email;
            this.prod_id = prod_id;
            this.date_commande = date_commande;
            this.quantite = quantite;
            this.total = total;
        }

        public int Id { get => id; set => id = value; }
        public string Cl_email { get => cl_email; set => cl_email = value; }
        public int Prod_id { get => prod_id; set => prod_id = value; }
        public DateTime Date_commande { get => date_commande; set => date_commande = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double Total{ get => total; set => total = value; }
    }


}
