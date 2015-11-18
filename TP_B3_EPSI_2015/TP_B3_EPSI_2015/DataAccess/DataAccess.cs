using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using TP_B3_EPSI_2015.Models;

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

        public void Create(Album album)
        {
            _connexion.Open();
            SqlCommand cmd;
            cmd = _connexion.CreateCommand();
            cmd.CommandText = @"INSERT INTO table album VALUES ('"+album.id+"','"+album.titre+"','"+album.auteur+"','"+album.genre+"','"+album.annee_sortie+"')";
            cmd.ExecuteReader();
            cmd.Dispose();
            this.Dispose();
        }

        public void Dispose()
        {
            _connexion.Close();
        }
    }
}