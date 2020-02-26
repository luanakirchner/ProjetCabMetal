using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CabMetal
{
    class DataBase
    {
        private MySqlConnection connection;

        public DataBase()
        {
            InitConnexion();
        }

        private void InitConnexion()
        {
            //Création de la chaine de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=catalogues; UID=root; PASSWORD=LuanaKBL2612";
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
            requete.CommandText = "SELECT categories.category FROM categories INNER JOIN catalogs_has_categories ON categories.id = catalogs_has_categories.Category_id INNER JOIN catalogs ON catalogs.id = catalogs_has_categories.Catalog_id WHERE catalogs.catalog = '"+catalogue+"';";
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
            requete.CommandText = "SELECT places.place FROM catalogs INNER JOIN catalogs_has_categories ON catalogs.id = catalogs_has_categories.Catalog_id INNER JOIN places ON catalogs.Place_id = places.id WHERE catalogs.catalog ='"+catalogue+"';";
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
            requete.CommandText = "SELECT * FROM categories Where category ='" + categories+"';";
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
            requete.CommandText = "SELECT catalogs.catalog, places.place FROM catalogs INNER JOIN catalogs_has_categories ON catalogs.id = catalogs_has_categories.Catalog_id INNER JOIN categories ON categories.id = catalogs_has_categories.Category_id INNER JOIN places ON catalogs.Place_id = places.id WHERE categories.category = '"+categorie+"';";
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
            requete.CommandText = "SELECT * FROM places WHERE place = '"+place+"';";
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
            requete.CommandText = "SELECT catalogs.catalog, places.place FROM catalogs INNER JOIN catalogs_has_categories ON catalogs.id = catalogs_has_categories.Catalog_id INNER JOIN categories ON categories.id = catalogs_has_categories.Category_id INNER JOIN places ON catalogs.Place_id = places.id WHERE places.place = '" + places + "' GROUP BY catalogs.catalog;";
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
            string commande = "INSERT INTO categories (id, category) VALUES (DEFAULT, '"+categorie+"');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }

        public void InsertCatalog(string catalog)
        {
            string commande = "INSERT INTO catalogs (id, catalog) VALUES (DEFAULT, '" + catalog + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public long InsertPlace(string place)
        {
            string commande = "INSERT INTO places (id, place) VALUES (DEFAULT, '" + place + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        public void InsertCatalogWithPlace(string catalog, long idplace)
        {
            string commande = "INSERT INTO catalogs (id, catalog, Place_id) VALUES (DEFAULT, '" + catalog + "', "+idplace+");";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void CatalogAndCategorie(string catalog, string categorie)
        {
            string commande = "INSERT INTO catalogs_has_categories (Category_id, Catalog_id) VALUES ((SELECT id FROM categories WHERE categories.category ='" + catalog + "'),(SELECT id FROM catalogs WHERE catalogs.catalog = '"+categorie+"'));";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        //-------------------------UPDATE----------------------------
        public void UpdateCategorie(string categorie, string modification)
        {
            string commande = "UPDATE categories SET categories.category = '"+modification+ "' WHERE categories.category = '"+categorie+"';";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
