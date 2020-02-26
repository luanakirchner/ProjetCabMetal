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
                    ControllerEmplacement(txtEmplacement.Text);
                    MessageBox.Show("Votre emplacement est bien sauvegarder");
                }
                //Ajouter itens 
                if (txtCatalogue.Text == "" && dgvItems.Rows.Count != 0 && txtEmplacement.Text == "")
                {
                    Insertproduits();
                    MessageBox.Show("Vous produits ont été bien sauvegardée");                 
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
                        MessageBox.Show("Votre catalogue était bien sauvegarder");
                    }
                    //Catalgoue + emplacement
                    if(dgvItems.Rows.Count == 0 && txtEmplacement.Text !="")
                    {
                        long idEmplacement = ControllerEmplacement(txtEmplacement.Text);
                        MysqlConn.OpenDB();
                        MysqlConn.InsertCatalogWithPlace(txtCatalogue.Text, idEmplacement);
                        MysqlConn.CloseDB();
                        MessageBox.Show("Vous avez ajoutée un catalog avec son emplacement");
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
                            long idEmplacement = ControllerEmplacement(txtEmplacement.Text);
                            MysqlConn.OpenDB();
                            MysqlConn.InsertCatalogWithPlace(txtCatalogue.Text, idEmplacement);
                            MysqlConn.CloseDB();
                            long idProduit = ControllerProduits(txtEmplacement.Text);

                          

                        }
                    }
                }
                txtEmplacement.Text = "";
                txtCatalogue.Text = "";
                dgvItems.Rows.Clear();
                txtItem.Text = "";
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
         
            for(int i = 1; i<= dgvItems.Rows.Count; i++)
            {
                ControllerProduits(dgvItems.Rows[i - 1].Cells[0].Value.ToString());
            }
           
           
        }
        private long ControllerCatalog(string catalog)
        {
            return 0;
        }
        private long ControllerProduits(string produit)
        {
            long idProduit = 0;
            MysqlConn.OpenDB();
            List<Categories> listCategorie = MysqlConn.ReadCategorieWhereCategorie(produit);
            MysqlConn.CloseDB();
            if(listCategorie.Count == 0)
            {
                MysqlConn.OpenDB();
                idProduit = MysqlConn.InsertCategorie(produit);
                MysqlConn.CloseDB();
            }
            if(listCategorie.Count != 0)
            {
                foreach (Categories value in listCategorie)
                {
                    idProduit = value.Id;
                }
            }
            return idProduit;
        }

        private long ControllerEmplacement(string emplacement)
        {
            MysqlConn.OpenDB();
            List<Places> listPlace = MysqlConn.ReadPlacesWherePlaces(emplacement);
            MysqlConn.CloseDB();
            long idPlace = 0;
            if (listPlace.Count == 0)
            {
                MysqlConn.OpenDB();
                idPlace = MysqlConn.InsertPlace(emplacement);
                MysqlConn.CloseDB();
            }
            if(listPlace.Count != 0)
            {
                foreach(Places value in listPlace)
                {
                    idPlace = value.Id;
                }
            }
            return idPlace;
        }

    }
}
