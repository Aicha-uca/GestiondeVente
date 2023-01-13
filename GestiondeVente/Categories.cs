using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeVente
{
    internal class Categories
    {
        private int id;
        private String code;
        private String libelle;
        private static int count = 0;

        public Categories(string code, string libelle)
        {
           
            this.code = code;
            this.libelle = libelle;
        }

        
        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
