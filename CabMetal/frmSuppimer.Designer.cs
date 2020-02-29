namespace CabMetal
{
    partial class frmSuppimer
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
            this.lblSupprimer = new System.Windows.Forms.Label();
            this.cmbTriePar = new System.Windows.Forms.ComboBox();
            this.cmdNomsupprimer = new System.Windows.Forms.ComboBox();
            this.lblTexte = new System.Windows.Forms.Label();
            this.btnSuppimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSupprimer
            // 
            this.lblSupprimer.AutoSize = true;
            this.lblSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupprimer.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblSupprimer.Location = new System.Drawing.Point(124, 21);
            this.lblSupprimer.Name = "lblSupprimer";
            this.lblSupprimer.Size = new System.Drawing.Size(138, 31);
            this.lblSupprimer.TabIndex = 0;
            this.lblSupprimer.Text = "Supprimer";
            // 
            // cmbTriePar
            // 
            this.cmbTriePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTriePar.FormattingEnabled = true;
            this.cmbTriePar.Location = new System.Drawing.Point(68, 90);
            this.cmbTriePar.Name = "cmbTriePar";
            this.cmbTriePar.Size = new System.Drawing.Size(248, 28);
            this.cmbTriePar.TabIndex = 1;
            this.cmbTriePar.SelectedIndexChanged += new System.EventHandler(this.CmbTriePar_SelectedIndexChanged);
            // 
            // cmdNomsupprimer
            // 
            this.cmdNomsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNomsupprimer.FormattingEnabled = true;
            this.cmdNomsupprimer.Location = new System.Drawing.Point(68, 191);
            this.cmdNomsupprimer.Name = "cmdNomsupprimer";
            this.cmdNomsupprimer.Size = new System.Drawing.Size(248, 28);
            this.cmdNomsupprimer.TabIndex = 2;
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTexte.Location = new System.Drawing.Point(45, 154);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(310, 25);
            this.lblTexte.TabIndex = 3;
            this.lblTexte.Text = "Sélectionner l\'élément à supprimer";
            // 
            // btnSuppimer
            // 
            this.btnSuppimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSuppimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppimer.Location = new System.Drawing.Point(68, 242);
            this.btnSuppimer.Name = "btnSuppimer";
            this.btnSuppimer.Size = new System.Drawing.Size(248, 33);
            this.btnSuppimer.TabIndex = 4;
            this.btnSuppimer.Text = "Supprimer";
            this.btnSuppimer.UseVisualStyleBackColor = false;
            this.btnSuppimer.Click += new System.EventHandler(this.BtnSuppimer_Click);
            // 
            // frmSuppimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(387, 310);
            this.Controls.Add(this.btnSuppimer);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.cmdNomsupprimer);
            this.Controls.Add(this.cmbTriePar);
            this.Controls.Add(this.lblSupprimer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppimer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuppimer";
            this.Load += new System.EventHandler(this.FrmSuppimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupprimer;
        private System.Windows.Forms.ComboBox cmbTriePar;
        private System.Windows.Forms.ComboBox cmdNomsupprimer;
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.Button btnSuppimer;
    }
}