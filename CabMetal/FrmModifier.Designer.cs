namespace CabMetal
{
    partial class FrmModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifier));
            this.cmbCatalogue = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblCatalogue = new System.Windows.Forms.Label();
            this.lblModifier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCatalogue
            // 
            this.cmbCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCatalogue.FormattingEnabled = true;
            this.cmbCatalogue.Location = new System.Drawing.Point(133, 83);
            this.cmbCatalogue.Name = "cmbCatalogue";
            this.cmbCatalogue.Size = new System.Drawing.Size(210, 28);
            this.cmbCatalogue.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Chocolate;
            this.btnValider.Location = new System.Drawing.Point(133, 152);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(210, 28);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // lblCatalogue
            // 
            this.lblCatalogue.AutoSize = true;
            this.lblCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCatalogue.Location = new System.Drawing.Point(12, 82);
            this.lblCatalogue.Name = "lblCatalogue";
            this.lblCatalogue.Size = new System.Drawing.Size(102, 25);
            this.lblCatalogue.TabIndex = 2;
            this.lblCatalogue.Text = "Catalogue";
            // 
            // lblModifier
            // 
            this.lblModifier.AutoSize = true;
            this.lblModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblModifier.Location = new System.Drawing.Point(138, 9);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(110, 31);
            this.lblModifier.TabIndex = 3;
            this.lblModifier.Text = "Modifier";
            // 
            // FrmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(382, 207);
            this.Controls.Add(this.lblModifier);
            this.Controls.Add(this.lblCatalogue);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbCatalogue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CabMétal SA - Modifier";
            this.Load += new System.EventHandler(this.FrmModifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCatalogue;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblCatalogue;
        private System.Windows.Forms.Label lblModifier;
    }
}