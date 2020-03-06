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
        public bool ModifierCatalog = false;
        public string NomCatalogModifer;
        Image imagedelet = Image.FromFile(Application.StartupPath + "/Images/delete (1).png");

        public frmAjouterModifier()
        {
            InitializeComponent();
         
        }

        private void FrmAjouter_Load(object sender, EventArgs e)
        {
            this.dgvItems.BorderStyle = BorderStyle.Fixed3D;
            dgvItems.DefaultCellStyle.Font = new Font("Sans serif", 10);
            btnSauvegarder.FlatStyle = FlatStyle.Flat;
            btnSauvegarder.FlatAppearance.BorderColor = Color.LightSalmon;
            btnSauvegarder.FlatAppearance.BorderSize = 2;

            DataGridViewImageColumn imgdelet = new DataGridViewImageColumn();
            imgdelet.Image = imagedelet;
            imgdelet.Name = "Delet";
            dgvItems.Columns.Add(imgdelet);

            lblNomAdd.Text = textlblNom;
            if(ModifierCatalog == true)
            {
                txtCatalogue.Text = NomCatalogModifer;
              
                MysqlConn.OpenDB();
                List<Places> listPlace = MysqlConn.ReadPlacesWhereCatalogue(NomCatalogModifer);
                MysqlConn.CloseDB();
                foreach (Places value in listPlace)
                {
                    txtEmplacement.Text = value.Place;
                }

                MysqlConn.OpenDB();
                List<Categories> listCategorie = MysqlConn.ReadCategorieWhereCatalogue(NomCatalogModifer);
                MysqlConn.CloseDB();
                foreach (Categories value in listCategorie)
                {
                    dgvItems.Rows.Add(value.Categorie);
                }
            }
        }

        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            if (ModifierCatalog == true)
            {
                try
                {
                    Controller.characterController(txtEmplacement.Text);
                    long idEmplacement = 0;
                    if (txtEmplacement.Text != "")
                    {
                        idEmplacement = ControllerEmplacement(txtEmplacement.Text);
                    }

                        MysqlConn.OpenDB();
                        //Upade 
                        if(idEmplacement == 0)
                        {
                            MysqlConn.UpadateCatalogSansEmplacement(NomCatalogModifer);
                        }
                        if(idEmplacement != 0)
                        {
                            MysqlConn.UpadateCatalogEmplacement(NomCatalogModifer, idEmplacement);
                        }
                        MysqlConn.CloseDB();

                        MysqlConn.OpenDB();
                        //Supprimer la table intermediare
                        MysqlConn.DeleteCatalogsHasCategorie(NomCatalogModifer);
                        MysqlConn.CloseDB();
                        //Chercher les produits dans le tableau, les ajoutes et les relier avec le catalog
                        for (int i = 1; i <= dgvItems.Rows.Count; i++)
                        {
                            long idProduit = ControllerProduits(dgvItems.Rows[i - 1].Cells[0].Value.ToString());
                            MysqlConn.OpenDB();
                            MysqlConn.InsertCatalogAndCategorie(NomCatalogModifer, idProduit);
                            MysqlConn.CloseDB();
                        }
                        MysqlConn.OpenDB();
                        //Upade 
                        MysqlConn.UpdateCatalog(NomCatalogModifer,txtCatalogue.Text);
                        MysqlConn.CloseDB();
                        MessageBox.Show("Les nouvelles données ont été enregistrées");
                        CleanChamps();
                        this.Close();
                    }

                catch (ExecpetionCode ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //--------------------Ajouter---------------------------
            else
            {

                try
                {
                    Controller.characterController(txtCatalogue.Text);
                    Controller.characterController(txtEmplacement.Text);

                    //Ajouter un emplacement 
                    if (txtCatalogue.Text == "" && dgvItems.Rows.Count == 0 && txtEmplacement.Text != "")
                    {
                        ControllerEmplacement(txtEmplacement.Text);
                        MessageBox.Show("Votre emplacement a bien été sauvegardé");
                        CleanChamps();
                    }
                    //Ajouter itens 
                    if (txtCatalogue.Text == "" && dgvItems.Rows.Count != 0 && txtEmplacement.Text == "")
                    {
                        Insertproduits();
                        MessageBox.Show("Vos produits ont bien été sauvegardés");
                        CleanChamps();
                    }
                    //Ajouter Catalogue 
                    if (txtCatalogue.Text != "")
                    {
                        try
                        {
                            ControllerCatalog(txtCatalogue.Text);

                            //Juste un catalogue
                            if (dgvItems.Rows.Count == 0 && txtEmplacement.Text == "")
                            {
                                MysqlConn.OpenDB();
                                MysqlConn.InsertCatalog(txtCatalogue.Text);
                                MysqlConn.CloseDB();
                                MessageBox.Show("Votre catalogue a bien été sauvegardé");
                                CleanChamps();
                            }
                            //Catalgoue + emplacement
                            if (dgvItems.Rows.Count == 0 && txtEmplacement.Text != "")
                            {
                                long idEmplacement = ControllerEmplacement(txtEmplacement.Text);
                                MysqlConn.OpenDB();
                                MysqlConn.InsertCatalogWithPlace(txtCatalogue.Text, idEmplacement);
                                MysqlConn.CloseDB();
                                MessageBox.Show("Vous avez ajouté un catalogue avec son emplacement");
                                CleanChamps();
                            }
                            //Catalogue + emplacement + produits
                            if (dgvItems.Rows.Count != 0)
                            {
                                long idEmplacement = 0;
                                if (txtEmplacement.Text != "")
                                {
                                    //Recuperer le id du emplacement 
                                    idEmplacement = ControllerEmplacement(txtEmplacement.Text);

                                }
                                    MysqlConn.OpenDB();
                                    if (idEmplacement == 0)
                                    {
                                        MysqlConn.InsertCatalog(txtCatalogue.Text);
                                    }
                                    if(idEmplacement != 0)
                                    {
                                        //Inserer le catalog avec le emplacement 
                                        MysqlConn.InsertCatalogWithPlace(txtCatalogue.Text, idEmplacement);
                                    }
                                    MysqlConn.CloseDB();

                                    //Chercher les produits dans le tableau, les ajoutes et les relier avec le catalog
                                    for (int i = 1; i <= dgvItems.Rows.Count; i++)
                                    {
                                        long idProduit = ControllerProduits(dgvItems.Rows[i - 1].Cells[0].Value.ToString());
                                        MysqlConn.OpenDB();
                                        MysqlConn.InsertCatalogAndCategorie(txtCatalogue.Text, idProduit);
                                        MysqlConn.CloseDB();
                                    }

                                    MessageBox.Show("Vous avez ajouté un catalogue avec son emplacement et ses produits");
                                    CleanChamps();
                                }
                            }
                        catch (ExecpetionCode ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                catch (ExceptionCaracterespeciaux ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
       
        public void CleanChamps()
        {
            txtEmplacement.Text = "";
            txtCatalogue.Text = "";
            dgvItems.Rows.Clear();
            txtItem.Text = "";
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
        private void ControllerCatalog(string catalog)
        {

            MysqlConn.OpenDB();
            List<Catalogs> listCatalog = MysqlConn.ReadCatalogsWhereCatalogs(catalog);
            MysqlConn.CloseDB();
            if(listCatalog.Count != 0)
            {
                throw new ExecpetionCode("Le catalogue existe déjà !");
            }
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

        private void DgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewCell oncell in dgvItems.SelectedCells)
            {
                //Clic sur supprimer 
                if (dgvItems.Rows[e.RowIndex].Cells[1].Selected)
                {
                    dgvItems.Rows.RemoveAt(oncell.RowIndex);
                }
            }
        }

        private void PicPlaces_Click(object sender, EventArgs e)
        {
            string nomPlace = "";
            frmLoupe LoupeEmplacement = new frmLoupe();
            LoupeEmplacement.Emplacement = true;
            LoupeEmplacement.lblNom.Text = "Emplacement";
            LoupeEmplacement.ShowDialog();
            nomPlace = LoupeEmplacement.emplacementSelec;

            if (nomPlace != "")
            {
                txtEmplacement.Text = nomPlace;
            }
        }

        private void PicProduit_Click(object sender, EventArgs e)
        {
            frmLoupe LoupeProduit = new frmLoupe();
            LoupeProduit.Produit = true;
            LoupeProduit.lblNom.Text = "Produits";
            LoupeProduit.ShowDialog();
            List<Categories> selecProduitlst = new List<Categories>();
            selecProduitlst = LoupeProduit.lstCategorieSelec;

            foreach(Categories value in selecProduitlst)
            {
                dgvItems.Rows.Add(value.Categorie);
            }
        }
    }
}
