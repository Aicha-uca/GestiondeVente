using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeVente
{
    internal class Produits
    {
        private int id;
        private string nom;
        private int quantité;
        private double prix;
        private string categorie;
        private string description;
        Byte[] image;

        public Produits(string nom, int quantité, double prix, string categorie, string description, byte[] image)
        {
            
            this.nom = nom;
            this.quantité = quantité;
            this.prix = prix;
            this.categorie = categorie;
            this.description = description;
            this.image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Quantité { get => quantité; set => quantité = value; }
        public double Prix { get => prix; set => prix = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Description { get => description; set => description = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}
