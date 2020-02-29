namespace CabMetal
{
    partial class frmLoupe
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
            this.btnValider = new System.Windows.Forms.Button();
            this.lsbProduits = new System.Windows.Forms.ListBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Peru;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnValider.Location = new System.Drawing.Point(31, 397);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(192, 40);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // lsbProduits
            // 
            this.lsbProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbProduits.FormattingEnabled = true;
            this.lsbProduits.ItemHeight = 16;
            this.lsbProduits.Location = new System.Drawing.Point(31, 90);
            this.lsbProduits.Name = "lsbProduits";
            this.lsbProduits.Size = new System.Drawing.Size(192, 276);
            this.lsbProduits.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Peru;
            this.lblNom.Location = new System.Drawing.Point(25, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(71, 31);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // frmLoupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(261, 455);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lsbProduits);
            this.Controls.Add(this.btnValider);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoupe";
            this.Text = "Loupe";
            this.Load += new System.EventHandler(this.FrmLoupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ListBox lsbProduits;
        public System.Windows.Forms.Label lblNom;
    }
}