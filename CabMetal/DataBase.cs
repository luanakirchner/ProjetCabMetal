using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Json.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace CabMetal
{
    class DataBase
    {
        private MySqlConnection connection;

        public DataBase()
        {
            InitConnexion();
        }

        ConfigurationDB configJson;
        public void ReadJson()
        {
            string Jsonformat = File.ReadAllText(Application.StartupPath + "/Json/ConnectionDB.json");
            configJson = ConfigurationDB.FromJson(Jsonformat);

        }
        private void InitConnexion()
        {
            ReadJson();
            string connectionString = "SERVER =" + configJson.Server + ";" + "DATABASE =" + configJson.Database + ";" + "UID =" + configJson.Uid + ";" + "PASSWORD =" + configJson.Password;
            connection = new MySqlConnection(connectionString);
        }

        public void OpenDB()
        {
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Connexion à la base de données impossible. Si le problème persiste, contactez le support.");
                Environment.Exit(0);
            }
        }
        public void CloseDB()
        {
            connection.Close();
        }

        public void ReadAllData()
        {

        }

        public List<Categories> ReadCategorieWhereCatalogue(string catalogue)
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT categories.category FROM categories Right JOIN catalogs_has_categories ON categories.id = catalogs_has_categories.Category_id INNER JOIN catalogs ON catalogs.id = catalogs_has_categories.Catalog_id WHERE catalogs.catalog = '"+catalogue.Replace("'", "''") + "';";
            List<Categories> listCategories = new List<Categories>();
            MySqlDataReader dataCategories = requete.ExecuteReader();
            while (dataCategories.Read())
            {
                string categorieData = dataCategories["category"].ToString();

                Categories categorie = new Categories(categorieData);
                listCategories.Add(categorie);

            }
            return listCategories;
        }

        public List<Places> ReadPlacesWhereCatalogue(string catalogue)
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT places.place FROM catalogs Right JOIN catalogs_has_categories ON catalogs.id = catalogs_has_categories.Catalog_id INNER JOIN places ON catalogs.Place_id = places.id WHERE catalogs.catalog ='"+catalogue.Replace("'", "''") + "';";
            List<Places> listPlaces = new List<Places>();
            MySqlDataReader dataPlaces = requete.ExecuteReader();
            while (dataPlaces.Read())
            {
                string PlaceData = dataPlaces["place"].ToString();

                Places Place = new Places(PlaceData);
                listPlaces.Add(Place);

            }
            return listPlaces;
        }

        public List<Catalogs> ReadCatalogsWhereCatalogs(string catalog)
        {
        
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT * FROM catalogs Where catalog = '"+ catalog.Replace("'", "''") + "';";
            List<Catalogs> listCatalgs = new List<Catalogs>();
            MySqlDataReader dataCatalog = requete.ExecuteReader();
            while (dataCatalog.Read())
            {
                string catalogData = dataCatalog["catalog"].ToString();
                int idData = (int)dataCatalog["id"];

                Catalogs catalogTrouve = new Catalogs(idData, catalogData);
                listCatalgs.Add(catalogTrouve);

            }
            return listCatalgs;
        }

        public List<Catalogs> ReadCatalogs()
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT * FROM catalogs;";
            List<Catalogs> listCatalgs = new List<Catalogs>();
            MySqlDataReader dataCatalog = requete.ExecuteReader();
            while (dataCatalog.Read())
            {
                string catalogData = dataCatalog["catalog"].ToString();
                int idData = (int)dataCatalog["id"];

                Catalogs catalog = new Catalogs(idData,catalogData);
                listCatalgs.Add(catalog);

            }
            return listCatalgs;
        }
        public List<Categories> ReadCategorieWhereCategorie(string categories)
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT * FROM categories Where category ='" + categories.Replace("'", "''") + "';";
            List<Categories> listCategories = new List<Categories>();
            MySqlDataReader dataCategories = requete.ExecuteReader();
            while (dataCategories.Read())
            {
                string categorieData = dataCategories["category"].ToString();
                int idData = (int)dataCategories["id"];

                Categories categorie = new Categories(idData, categorieData);
                listCategories.Add(categorie);

            }
            return listCategories;
        }

        public List<Categories> ReadCategorie()
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT * FROM categories;";
            List<Categories> listCategories = new List<Categories>();
            MySqlDataReader dataCategories = requete.ExecuteReader();
            while (dataCategories.Read())
            {
                string categorieData = dataCategories["category"].ToString();
                int idData = (int)dataCategories["id"];

                Categories categorie = new Categories(idData,categorieData);
                listCategories.Add(categorie);

            }
            return listCategories;
        }

        public List<Catalogs> ReadCataloguePlacesWhereCategorie(string categorie)
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT catalogs.catalog, places.place FROM catalogs INNER JOIN catalogs_has_categories ON catalogs.id = catalogs_has_categories.Catalog_id INNER JOIN categories ON categories.id = catalogs_has_categories.Category_id LEFT JOIN places ON catalogs.Place_id = places.id WHERE categories.category = '"+categorie.Replace("'", "''") + "';";
            List<Catalogs> listCatalgs = new List<Catalogs>();
            MySqlDataReader dataCatalog = requete.ExecuteReader();
            while (dataCatalog.Read())
            {
                string catalogData = dataCatalog["catalog"].ToString();
                string placeData = dataCatalog["place"].ToString();

                Catalogs catalog = new Catalogs(catalogData, placeData);
                listCatalgs.Add(catalog);

            }
            return listCatalgs;
        }
        
        public List<Places> ReadPlaces()
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT * FROM places;";
            List<Places> listPlaces = new List<Places>();
            MySqlDataReader dataplaces = requete.ExecuteReader();
            while (dataplaces.Read())
            {
                string placeData = dataplaces["place"].ToString();
                int idData = (int)dataplaces["id"];

                Places places = new Places(idData, placeData);
                listPlaces.Add(places);

            }
            return listPlaces;
        }
        public List<Places> ReadPlacesWherePlaces(string place)
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT * FROM places WHERE place = '"+place.Replace("'", "''") + "';";
            List<Places> listPlaces = new List<Places>();
            MySqlDataReader dataplaces = requete.ExecuteReader();
            while (dataplaces.Read())
            {
                string placeData = dataplaces["place"].ToString();
                int idData = (int)dataplaces["id"];

                Places places = new Places(idData, placeData);
                listPlaces.Add(places);

            }
            return listPlaces;
        }

        public List<Catalogs> ReadCatalogsWherePlaces(string places)
        {
            MySqlCommand requete = connection.CreateCommand();
            requete.CommandText = "SELECT catalogs.catalog, places.place FROM catalogs Right JOIN catalogs_has_categories ON catalogs.id = catalogs_has_categories.Catalog_id INNER JOIN categories ON categories.id = catalogs_has_categories.Category_id INNER JOIN places ON catalogs.Place_id = places.id WHERE places.place = '" + places.Replace("'", "''") + "' GROUP BY catalogs.catalog;";
            List<Catalogs> listCatalgs = new List<Catalogs>();
            MySqlDataReader dataCatalog = requete.ExecuteReader();
            while (dataCatalog.Read())
            {
                string catalogData = dataCatalog["catalog"].ToString();

                Catalogs catalog = new Catalogs(catalogData);
                listCatalgs.Add(catalog);

            }
            return listCatalgs;
        }
        //----------------------INSERT-------------------------
        public long InsertCategorie(string categorie)
        {
            string commande = "INSERT INTO categories (id, category) VALUES (DEFAULT, '"+categorie.Replace("'", "''") + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }

        public void InsertCatalog(string catalog)
        {
            string commande = "INSERT INTO catalogs (id, catalog) VALUES (DEFAULT, '" + catalog.Replace("'", "''")+ "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public long InsertPlace(string place)
        {
            string commande = "INSERT INTO places (id, place) VALUES (DEFAULT, '" + place.Replace("'", "''") + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        public void InsertCatalogWithPlace(string catalog, long idplace)
        {
            string commande = "INSERT INTO catalogs (id, catalog, Place_id) VALUES (DEFAULT, '" + catalog.Replace("'", "''") + "', "+idplace + ");";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        public void InsertCatalogAndCategorie(string catalog, long categorie)
        {
            string commande = "INSERT INTO catalogs_has_categories (Category_id, Catalog_id) VALUES ("+categorie + ",(SELECT id FROM catalogs WHERE catalogs.catalog = '"+catalog.Replace("'", "''") + "'));";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        //-------------------------UPDATE----------------------------
        public void UpdateCategorie(string categorie, string modification)
        {
            string commande = "UPDATE categories SET categories.category = '"+modification.Replace("'", "''") + "' WHERE categories.category = '"+categorie.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        public void UpdateCatalog(string catalog, string modifer)
        {
            string commande = "UPDATE catalogs SET catalogs.catalog = '"+modifer.Replace("'", "''") + "' WHERE catalogs.catalog = '"+catalog.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void UpadateCatalogEmplacement(string catalog, long emplacement)
        {
            string commande = "UPDATE catalogs SET catalogs.Place_id = '"+emplacement+ "' WHERE catalogs.catalog = '"+catalog.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void UpadateCatalogSansEmplacement(string catalog)
        {
            string commande = "UPDATE catalogs SET catalogs.Place_id = null WHERE catalogs.catalog = '" + catalog.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        // ----------------------- Supprimer ----------------
        public void DeleteCatalogsHasCategorie(string catalog)
        {
            string commande = "DELETE FROM catalogs_has_categories  WHERE catalogs_has_categories.Catalog_id = (SELECT id FROM catalogs WHERE catalogs.catalog = '"+catalog.Replace("'", "''") + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void DeleteCatalog(string catalog)
        {
            string commande = "DELETE FROM catalogs WHERE catalogs.catalog = '"+catalog.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();

        }
        public void DeleteCategorie(string categorie)
        {
            string commande = "DELETE FROM categories WHERE categories.category = '"+ categorie.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void DeletePlace(string place)
        {
            string commande = "DELETE FROM places WHERE places.place = '"+place.Replace("'", "''") + "';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
