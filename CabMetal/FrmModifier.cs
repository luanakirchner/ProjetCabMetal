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
    public partial class FrmModifier : Form
    {
        public long idSelectionne;
        DataBase MysqlConn = new DataBase();
        public string nomCatalog;
        public FrmModifier()
        {
            InitializeComponent();
        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {
            cmbCatalogue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbCatalogue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCatalogue.AutoCompleteSource = AutoCompleteSource.ListItems;

            MysqlConn.OpenDB();
            List<Catalogs> listCatalogs = MysqlConn.ReadCatalogs();
            foreach (Catalogs value in listCatalogs)
            {
                cmbCatalogue.Items.Add(value);
            }
            MysqlConn.CloseDB();

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (cmbCatalogue.SelectedIndex < 0)
            {
                MessageBox.Show("Selectioner un nom", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Catalogs catalogSelectionner = (Catalogs)cmbCatalogue.SelectedItem;
                nomCatalog = catalogSelectionner.Catalog;
                this.Hide();
            }
        }
    }
}
