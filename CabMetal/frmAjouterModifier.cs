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
    public partial class frmAjouterModifier : Form
    {
        public string textlblNom;
        public long idModifier = -1;
        Image imagedelet = Image.FromFile(Application.StartupPath + "/Images/delete (1).png");

        public frmAjouterModifier()
        {
            InitializeComponent();
        }

        private void FrmAjouter_Load(object sender, EventArgs e)
        {
            this.dgvItems.BorderStyle = BorderStyle.Fixed3D;
            btnSauvegarder.FlatStyle = FlatStyle.Flat;
            btnSauvegarder.FlatAppearance.BorderColor = Color.LightSalmon;
            btnSauvegarder.FlatAppearance.BorderSize = 2;

            DataGridViewImageColumn imgdelet = new DataGridViewImageColumn();
            imgdelet.Image = imagedelet;
            imgdelet.Name = "Delet";
            dgvItems.Columns.Add(imgdelet);

            lblNomAdd.Text = textlblNom;
            if(idModifier >= 0)
            {
                txtCatalogue.Text = "Modifier";
                dgvItems.Rows.Add("Vidro");
               
            }
        }

        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.characterController(txtCatalogue.Text);
                Controller.characterController(txtEmplacement.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnValiderItem_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.characterController(txtItem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
