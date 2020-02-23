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
        DataBase MysqlConn = new DataBase();
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

                if(txtCatalogue.Text == "" && dgvItems.Rows.Count == 0 && txtEmplacement.Text!="")
                {
                    MysqlConn.OpenDB();
                    MysqlConn.InsertPlace(txtEmplacement.Text);
                    MysqlConn.CloseDB();
                    txtEmplacement.Text = "";
                    MessageBox.Show("Votre emplacement est bien sauvegarder");
                }
                //Ajouter itens 
                if (txtCatalogue.Text == "" && dgvItems.Rows.Count != 0 && txtEmplacement.Text == "")
                {
                    Insertproduits();
                    MessageBox.Show("Vous produits ont été bien sauvegardée");
                    dgvItems.Rows.Clear();
                }
                //Ajouter Catalogue 
                if (txtCatalogue.Text != "")
                {
                    //Juste un catalogue
                    if(dgvItems.Rows.Count == 0 && txtEmplacement.Text == "")
                    {
                        MysqlConn.OpenDB();
                        MysqlConn.InsertCatalog(txtCatalogue.Text);
                        MysqlConn.CloseDB();
                        txtCatalogue.Text = "";
                        MessageBox.Show("Votre catalogue était bien sauvegarder");
                    }
                    //Catalgoue + emplacement
                    if(dgvItems.Rows.Count == 0)
                    {
                        MessageBox.Show("2");
                        
                    }
                    //Catalogue + emplacement + produits
                    if(dgvItems.Rows.Count != 0)
                    {
                        if(txtEmplacement.Text == "")
                        {
                            MessageBox.Show("Ajoutez un emplacement");
                        }
                        else
                        {
                            MessageBox.Show("3");
                        }
                    }
                }

            }
            catch (ExceptionCaracterespeciaux ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnValiderItem_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.characterController(txtItem.Text);
                dgvItems.Rows.Add(txtItem.Text);
                txtItem.Text = "";
            }
            catch (ExceptionCaracterespeciaux ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Insertproduits()
        {
            int ligne = 0;
            MysqlConn.OpenDB();
            for(int i = 1; i<= dgvItems.Rows.Count; i++)
            {
                MysqlConn.InsertCategorie(dgvItems.Rows[i-1].Cells[0].Value.ToString());
            }
            MysqlConn.CloseDB();
           
        }
    }
}
