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
        public FrmModifier()
        {
            InitializeComponent();
        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {
            cmbCatalogue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbCatalogue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCatalogue.AutoCompleteSource = AutoCompleteSource.ListItems;



            cmbCatalogue.Items.Add("Catalogue1");
            cmbCatalogue.Items.Add("Catalogue2");
            cmbCatalogue.Items.Add("Catalogue3");
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (cmbCatalogue.SelectedIndex < 0)
            {
                MessageBox.Show("Selectioner un nom pour triéer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                idSelectionne = 1;
                this.Hide();
            }
        }
    }
}
