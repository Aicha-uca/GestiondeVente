using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeVente
{
    internal class Users
    {
        private static int count;
        private int id;
        private String nom;
        private String motdepasse;

        public Users(string nom, string motdepasse)
        {
            this.nom = nom;
            this.motdepasse = motdepasse;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Motdepasse { get => motdepasse; set => motdepasse = value; }
    }
}
