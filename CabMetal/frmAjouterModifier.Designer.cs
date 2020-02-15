namespace CabMetal
{
    partial class frmAjouterModifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCatalogue = new System.Windows.Forms.TextBox();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnValiderItem = new System.Windows.Forms.Button();
            this.lblCatologue = new System.Windows.Forms.Label();
            this.lblEmplacement = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblNomAdd = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatalogue
            // 
            this.txtCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatalogue.Location = new System.Drawing.Point(172, 61);
            this.txtCatalogue.Name = "txtCatalogue";
            this.txtCatalogue.Size = new System.Drawing.Size(152, 23);
            this.txtCatalogue.TabIndex = 0;
            // 
            // txtEmplacement
            // 
            this.txtEmplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmplacement.Location = new System.Drawing.Point(172, 105);
            this.txtEmplacement.Name = "txtEmplacement";
            this.txtEmplacement.Size = new System.Drawing.Size(152, 23);
            this.txtEmplacement.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(172, 148);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(152, 23);
            this.txtItem.TabIndex = 2;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item});
            this.dgvItems.Location = new System.Drawing.Point(44, 188);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(368, 164);
            this.dgvItems.TabIndex = 4;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSauvegarder.Location = new System.Drawing.Point(44, 368);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(368, 30);
            this.btnSauvegarder.TabIndex = 5;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.BtnSauvegarder_Click);
            // 
            // btnValiderItem
            // 
            this.btnValiderItem.Location = new System.Drawing.Point(337, 148);
            this.btnValiderItem.Name = "btnValiderItem";
            this.btnValiderItem.Size = new System.Drawing.Size(75, 23);
            this.btnValiderItem.TabIndex = 3;
            this.btnValiderItem.Text = "Valider Item";
            this.btnValiderItem.UseVisualStyleBackColor = true;
            this.btnValiderItem.Click += new System.EventHandler(this.BtnValiderItem_Click);
            // 
            // lblCatologue
            // 
            this.lblCatologue.AutoSize = true;
            this.lblCatologue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatologue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCatologue.Location = new System.Drawing.Point(35, 61);
            this.lblCatologue.Name = "lblCatologue";
            this.lblCatologue.Size = new System.Drawing.Size(102, 25);
            this.lblCatologue.TabIndex = 6;
            this.lblCatologue.Text = "Catologue";
            // 
            // lblEmplacement
            // 
            this.lblEmplacement.AutoSize = true;
            this.lblEmplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplacement.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmplacement.Location = new System.Drawing.Point(35, 105);
            this.lblEmplacement.Name = "lblEmplacement";
            this.lblEmplacement.Size = new System.Drawing.Size(131, 25);
            this.lblEmplacement.TabIndex = 7;
            this.lblEmplacement.Text = "Emplacement";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItem.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItem.Location = new System.Drawing.Point(39, 144);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 25);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Item";
            // 
            // lblNomAdd
            // 
            this.lblNomAdd.AutoSize = true;
            this.lblNomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAdd.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblNomAdd.Location = new System.Drawing.Point(166, 9);
            this.lblNomAdd.Name = "lblNomAdd";
            this.lblNomAdd.Size = new System.Drawing.Size(100, 31);
            this.lblNomAdd.TabIndex = 9;
            this.lblNomAdd.Text = "Ajouter";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 225;
            // 
            // frmAjouterModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(443, 420);
            this.Controls.Add(this.lblNomAdd);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblEmplacement);
            this.Controls.Add(this.lblCatologue);
            this.Controls.Add(this.btnValiderItem);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtEmplacement);
            this.Controls.Add(this.txtCatalogue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjouterModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.FrmAjouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatalogue;
        private System.Windows.Forms.TextBox txtEmplacement;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnValiderItem;
        private System.Windows.Forms.Label lblCatologue;
        private System.Windows.Forms.Label lblEmplacement;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblNomAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
    }
}