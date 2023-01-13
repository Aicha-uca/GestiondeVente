using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondeVente
{
    internal class Connexion
    {
        public MySqlConnection connMaster;
        public void connexion()
        {
            connMaster = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=;database=gestionvente");
        }
        public void cnxOpen()
        {
            connMaster.Open();
        }
        public void cnxClose()
        {
            connMaster.Close();
        }

    }
}

