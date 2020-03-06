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
    public partial class frmSuppimer : Form
    {
        DataBase MysqlConn = new DataBase();
        public frmSuppimer()
        {
            InitializeComponent();
        }
        private void FrmSuppimer_Load(object sender, EventArgs e)
        {
            btnSuppimer.FlatStyle = FlatStyle.Flat;
            btnSuppimer.FlatAppearance.BorderColor = Color.LightSalmon;
            btnSuppimer.FlatAppearance.BorderSize = 2;

            cmbTriePar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbTriePar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTriePar.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbTriePar.Items.Add("Catalogue");
            cmbTriePar.Items.Add("Produits");
            cmbTriePar.Items.Add("Emplacement");
        }

        private void BtnSuppimer_Click(object sender, EventArgs e)
        {
            if (cmdNomsupprimer.SelectedIndex >=0)
            {
                DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce produit définitivement?", "Message de confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cmbTriePar.SelectedIndex == 0)
                    {
                        Catalogs selectionner = (Catalogs)cmdNomsupprimer.SelectedItem;
                        MysqlConn.OpenDB();
                        MysqlConn.DeleteCatalog(selectionner.Catalog);
                        MysqlConn.CloseDB();
                    }
                    if (cmbTriePar.SelectedIndex == 1)
                    {
                        Categories selectionner = (Categories)cmdNomsupprimer.SelectedItem;
                        MysqlConn.OpenDB();
                        MysqlConn.DeleteCategorie(selectionner.Categorie);
                        MysqlConn.CloseDB();
                    }
                    if (cmbTriePar.SelectedIndex == 2)
                    {
                        Places selectionner = (Places)cmdNomsupprimer.SelectedItem;
                        MysqlConn.OpenDB();
                        MysqlConn.DeletePlace(selectionner.Place);
                        MysqlConn.CloseDB();
                    }
                    MessageBox.Show("Votre élément a été supprimé");
                    cmdNomsupprimer.Text = "";
                    cmbTriePar.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void CmbTriePar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdNomsupprimer.Items.Clear();
            cmdNomsupprimer.Text = "";
            cmdNomsupprimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmdNomsupprimer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmdNomsupprimer.AutoCompleteSource = AutoCompleteSource.ListItems;


            if (cmbTriePar.SelectedIndex == 0)
            {
                MysqlConn.OpenDB();
                List<Catalogs> listCatalogs = MysqlConn.ReadCatalogs();
                foreach (Catalogs value in listCatalogs)
                {
                    cmdNomsupprimer.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
            if (cmbTriePar.SelectedIndex == 1)
            {
                MysqlConn.OpenDB();
                List<Categories> listCategories = MysqlConn.ReadCategorie();
                foreach (Categories value in listCategories)
                {
                    cmdNomsupprimer.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
            if (cmbTriePar.SelectedIndex == 2)
            {
                MysqlConn.OpenDB();
                List<Places> listPlaces = MysqlConn.ReadPlaces();
                foreach (Places value in listPlaces)
                {
                    cmdNomsupprimer.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
        }
    }
}
