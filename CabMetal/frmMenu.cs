using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabMetal
{
    public partial class frmMenu : Form
    {
        DataBase MysqlConn = new DataBase();
        Catalogs catalogSelectionner;
        public frmMenu()
        {
            InitializeComponent();
        }

        public void ReadAllData()
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAjouterModifier ajouter = new frmAjouterModifier();
            ajouter.textlblNom = "Ajouter";
            ajouter.ShowDialog();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            string nomCatalog = "";
            FrmModifier CatalogueModifier = new FrmModifier();
            CatalogueModifier.ShowDialog();
            nomCatalog = CatalogueModifier.nomCatalog;

            if (nomCatalog !=null)
            {
                frmAjouterModifier modifier = new frmAjouterModifier();
                modifier.textlblNom = "Modifier";
                modifier.ModifierCatalog = true;
                modifier.NomCatalogModifer = nomCatalog;
                modifier.ShowDialog();
            }


        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            cmbTriepar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbTriepar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTriepar.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvMenu.DefaultCellStyle.Font = new Font("Sans serif", 10);    

            cmbTriepar.Items.Add("Catalogue");
            cmbTriepar.Items.Add("Produits");
            cmbTriepar.Items.Add("Emplacement");

        }

        private void CbmTriepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNomTrie.Items.Clear();
            cmbNomTrie.Text = "";
            cmbNomTrie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbNomTrie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNomTrie.AutoCompleteSource = AutoCompleteSource.ListItems;


            if(cmbTriepar.SelectedIndex == 0)
            {
                MysqlConn.OpenDB();
                List<Catalogs> listCatalogs = MysqlConn.ReadCatalogs();
                foreach(Catalogs value in listCatalogs)
                {
                    cmbNomTrie.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
            if (cmbTriepar.SelectedIndex == 1)
            {
                MysqlConn.OpenDB();
                List<Categories> listCategories = MysqlConn.ReadCategorie();
                foreach (Categories value in listCategories)
                {
                    cmbNomTrie.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
            if(cmbTriepar.SelectedIndex == 2)
            {
                MysqlConn.OpenDB();
                List<Places> listPlaces = MysqlConn.ReadPlaces();
                foreach (Places value in listPlaces)
                {
                    cmbNomTrie.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }


        }

        private void BtnValiderTrie_Click(object sender, EventArgs e)
        {
            if (cmbNomTrie.SelectedIndex < 0)
            {
                MessageBox.Show("Sélectionnez une catégorie pour le trie", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                dgvMenu.Rows.Clear();         
                //-----Triée par catalogue----
                if(cmbTriepar.SelectedIndex == 0)
                {
                    trierCatalogue();
                }
                //--------Triée par categorie -------
                if(cmbTriepar.SelectedIndex == 1)
                {
                    trierCategorie();
                }
                //-------Triée par places ------------
                if(cmbTriepar.SelectedIndex == 2)
                {
                    TrierPlaces();
                }
            }
        }

        public void trierCatalogue()
        {
            catalogSelectionner = (Catalogs)cmbNomTrie.SelectedItem;
            MysqlConn.OpenDB();
            List<Categories> listCategorie = MysqlConn.ReadCategorieWhereCatalogue(catalogSelectionner.Catalog);
            MysqlConn.CloseDB();
            MysqlConn.OpenDB();
            List<Places> listPlace = MysqlConn.ReadPlacesWhereCatalogue(catalogSelectionner.Catalog);
            MysqlConn.CloseDB();

            string place = "";
            foreach (Places value in listPlace)
            {
                place = value.Place;
            }

            foreach (Categories value in listCategorie)
            {
                dgvMenu.Rows.Add(catalogSelectionner.Catalog, place, value.Categorie);
            }
            if(listCategorie.Count == 0)
            {
                dgvMenu.Rows.Add(catalogSelectionner.Catalog, place);
            }
        }
        public void trierCategorie()
        {
            Categories categorieSelectionner = (Categories)cmbNomTrie.SelectedItem;
            MysqlConn.OpenDB();
            List<Catalogs> listCatalogs = MysqlConn.ReadCataloguePlacesWhereCategorie(categorieSelectionner.Categorie);
            MysqlConn.CloseDB();
            foreach (Catalogs value in listCatalogs)
            {
                dgvMenu.Rows.Add(value.Catalog,value.Places,categorieSelectionner.Categorie);
            }
        }

        public void TrierPlaces()
        {
            Places placeSelectionner = (Places)cmbNomTrie.SelectedItem;
            MysqlConn.OpenDB();
            List<Catalogs> listCatalogs = MysqlConn.ReadCatalogsWherePlaces(placeSelectionner.Place);
            MysqlConn.CloseDB();
            foreach (Catalogs value in listCatalogs)
            {
                dgvMenu.Rows.Add(value.Catalog, placeSelectionner.Place);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            frmSuppimer supprimer = new frmSuppimer();
            supprimer.ShowDialog();
        }
    }
}
