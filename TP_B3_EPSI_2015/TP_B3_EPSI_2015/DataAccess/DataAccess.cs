using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace TP_B3_EPSI_2015.DataAccess
{
    public class DataAccess : IDisposable
    {

        private SqlConnection _connexion;
        public DataAccess(string connexion)
        {
            _connexion = new SqlConnection(connexion);
            _connexion.Open();
        }

        public void Dispose()
        {
            _connexion.Close();
        }
    }
}