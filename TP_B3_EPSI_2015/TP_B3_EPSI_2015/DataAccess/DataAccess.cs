using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using TP_B3_EPSI_2015.Models;
using MySql.Data.MySqlClient;
using Dapper;

namespace TP_B3_EPSI_2015.DataAccess_layer
{
    public class DataAccess : IDisposable
    {

        private MySqlConnection _connexion;

        public DataAccess()
        {
            _connexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            _connexion.Open();
        }

        public List<Album> Liste()
        {
            var requete = "select id, titre, genre, auteur, annee from albums";
            return _connexion.Query<Album>(requete).ToList();
        }

        public void Create(Album album)
        {
            var requete = @"
                insert into albums (titre, genre, auteur, annee)
                values (@Titre, @Genre, @Auteur, @Annee)
                ";
            _connexion.Execute(requete, new { Titre = album.Titre, Genre = album.Genre, Auteur = album.Auteur, Annee = album.Annee });
        }

        public void Delete(Album album)
        {
            var requete = "delete albums from ablums from albums where id=@Id";
            _connexion.Execute(requete, new { Id = album.Id });
        }

        public void Update(Album album)
        {
            var requete = @"
                update albums set
                    titre=@Titre
                    auteur=@Auteur
                    genre=@Genre
                    annee=@Annee
                where
                    id = @Id
            ";
            _connexion.Execute(requete, new { Id = album.Id, Titre = album.Titre, Genre = album.Genre, Auteur = album.Auteur, Annee = album.Annee });
        }

        public Album Read(int id)
        {
            var requete = "select id, titre, genre, auteur, annee from albums where id=@Id";
            return _connexion.Query<Album>(requete, new { id = id }).ToList().FirstOrDefault();
        }

        public void Dispose()
        {
            _connexion.Close();
        }
    }
}