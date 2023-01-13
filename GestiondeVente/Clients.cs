using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeVente
{
    internal class Clients
    {
        private int id;
        private static int count = 0;
        private String nom;
        private String prenom;
        private String adresse;
        private String telephone;
        private String email;
public Clients(string nom, string prenom, string adresse, string telephone, string email)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Telephone = telephone;
            this.Email = email;
        }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }

        
    }
}
