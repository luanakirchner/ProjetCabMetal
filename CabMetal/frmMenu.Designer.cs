namespace CabMetal
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTriepar = new System.Windows.Forms.ComboBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Catalogue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvbTrie = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnValiderTrie = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cmbNomTrie = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTriepar
            // 
            this.cmbTriepar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTriepar.FormattingEnabled = true;
            this.cmbTriepar.Location = new System.Drawing.Point(118, 147);
            this.cmbTriepar.Name = "cmbTriepar";
            this.cmbTriepar.Size = new System.Drawing.Size(207, 28);
            this.cmbTriepar.TabIndex = 1;
            this.cmbTriepar.SelectedIndexChanged += new System.EventHandler(this.CbmTriepar_SelectedIndexChanged);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Catalogue,
            this.Emplacement,
            this.Produits});
            this.dgvMenu.Location = new System.Drawing.Point(12, 200);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(978, 516);
            this.dgvMenu.TabIndex = 6;
            // 
            // Catalogue
            // 
            this.Catalogue.HeaderText = "Catalogue";
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Width = 380;
            // 
            // Emplacement
            // 
            this.Emplacement.HeaderText = "Emplacement";
            this.Emplacement.Name = "Emplacement";
            this.Emplacement.ReadOnly = true;
            this.Emplacement.Width = 150;
            // 
            // Produits
            // 
            this.Produits.HeaderText = "Produits";
            this.Produits.Name = "Produits";
            this.Produits.ReadOnly = true;
            this.Produits.Width = 405;
            // 
            // lvbTrie
            // 
            this.lvbTrie.AutoSize = true;
            this.lvbTrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbTrie.Location = new System.Drawing.Point(12, 150);
            this.lvbTrie.Name = "lvbTrie";
            this.lvbTrie.Size = new System.Drawing.Size(84, 25);
            this.lvbTrie.TabIndex = 3;
            this.lvbTrie.Text = "Trié par ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(358, 150);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 25);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom";
            // 
            // btnValiderTrie
            // 
            this.btnValiderTrie.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnValiderTrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderTrie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnValiderTrie.Location = new System.Drawing.Point(686, 142);
            this.btnValiderTrie.Name = "btnValiderTrie";
            this.btnValiderTrie.Size = new System.Drawing.Size(304, 33);
            this.btnValiderTrie.TabIndex = 3;
            this.btnValiderTrie.Text = "Valider";
            this.btnValiderTrie.UseVisualStyleBackColor = false;
            this.btnValiderTrie.Click += new System.EventHandler(this.BtnValiderTrie_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(686, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(792, 44);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 35);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // cmbNomTrie
            // 
            this.cmbNomTrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomTrie.FormattingEnabled = true;
            this.cmbNomTrie.Location = new System.Drawing.Point(429, 147);
            this.cmbNomTrie.Name = "cmbNomTrie";
            this.cmbNomTrie.Size = new System.Drawing.Size(231, 28);
            this.cmbNomTrie.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(898, 44);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 35);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::CabMetal.Properties.Resources.Logo_Cabmetal_SA_sans_fond;
            this.picLogo.Location = new System.Drawing.Point(77, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(565, 102);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1002, 728);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cmbNomTrie);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnValiderTrie);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lvbTrie);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.cmbTriepar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CabMétal SA - Gestionnaire de catalogues";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTriepar;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label lvbTrie;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnValiderTrie;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cmbNomTrie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catalogue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produits;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

