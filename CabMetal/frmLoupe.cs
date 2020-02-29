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
    public partial class frmLoupe : Form
    {
        DataBase MysqlConn = new DataBase();
        public bool Emplacement = false;
        public bool Produit = false;
        public string emplacementSelec = "";
        public string produitSelec = "";
        public List<Categories> lstCategorieSelec = new List<Categories>();
        public frmLoupe()
        {
            InitializeComponent();
        }

        private void FrmLoupe_Load(object sender, EventArgs e)
        {

            if(Emplacement == true)
            {
                MysqlConn.OpenDB();
                List<Places> listPlaces = MysqlConn.ReadPlaces();
                foreach (Places value in listPlaces)
                {
                    lsbProduits.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
            if(Produit == true)
            {
                lsbProduits.SelectionMode = SelectionMode.MultiSimple;
                MysqlConn.OpenDB();
                List<Categories> listCategories = MysqlConn.ReadCategorie();
                foreach (Categories value in listCategories)
                {
                    lsbProduits.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (Emplacement == true)
            {
                Places emaplcementSelectionner = (Places)lsbProduits.SelectedItem;
                emplacementSelec = emaplcementSelectionner.Place;
                this.Hide();
            }
            if (Produit == true)
            {
                frmAjouterModifier AjouteModifier = new frmAjouterModifier();

                foreach(Categories value in lsbProduits.SelectedItems)
                {
                    Categories categorieSelectionner = (Categories)value;
                    lstCategorieSelec.Add(value);
                }
                this.Hide();
            }
        }
    }
}
