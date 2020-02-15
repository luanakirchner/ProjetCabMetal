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
            FrmModifier CatalogueModifier = new FrmModifier();
            CatalogueModifier.ShowDialog();
            long idcatalogue = CatalogueModifier.idSelectionne;
            
            if(idcatalogue >= 1)
            {
                frmAjouterModifier modifier = new frmAjouterModifier();
                modifier.textlblNom = "Modifier";
                modifier.idModifier = idcatalogue;
                modifier.ShowDialog();
            }


        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            cmbTriepar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbTriepar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTriepar.AutoCompleteSource = AutoCompleteSource.ListItems;

        

            cmbTriepar.Items.Add("Catalogue");
            cmbTriepar.Items.Add("Categories");
            cmbTriepar.Items.Add("Emplacement");

        }

        private void CbmTriepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNomTrie.Items.Clear();
            cmbNomTrie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbNomTrie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNomTrie.AutoCompleteSource = AutoCompleteSource.ListItems;


            if(cmbTriepar.SelectedIndex == 0)
            {
                MysqlConn.OpenDB();
                List<Catalogs> listCatagos = MysqlConn.ReadCatalogs();
                foreach(Catalogs value in listCatagos)
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
                MessageBox.Show("Selectioner un nom pour triéer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                Catalogs catalogSelectionner = (Catalogs)cmbNomTrie.SelectedItem;
                dgvMenu.Rows.Clear();
                
                //-----Triéer par catalogue----
                if(cmbTriepar.SelectedIndex == 0)
                {
                    MysqlConn.OpenDB();
                    List<Categories> listCategorie = MysqlConn.ReadCategorieWhereCatalogue(catalogSelectionner.Catalog);
                    MysqlConn.CloseDB();
                    MysqlConn.OpenDB();
                    List<Places> listPlace = MysqlConn.ReadPlacesWhereCatalogue(catalogSelectionner.Catalog);
                    MysqlConn.CloseDB();

                    string place = "";
                    foreach(Places value in listPlace)
                    {
                        place = value.Place;
                    }

                    foreach(Categories value in listCategorie)
                    {
                        dgvMenu.Rows.Add(catalogSelectionner.Catalog, place, value.Categorie);
                    }
                }
            }
        }
    }
}
