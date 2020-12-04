
namespace WinCinoche
{
    partial class Cinema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinema));
            this.lblChoixHoraire = new System.Windows.Forms.Label();
            this.lblChoixJour = new System.Windows.Forms.Label();
            this.lblTarif11h = new System.Windows.Forms.Label();
            this.lblTarifLundi = new System.Windows.Forms.Label();
            this.lblPleinTarif = new System.Windows.Forms.Label();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCarte = new System.Windows.Forms.Label();
            this.rdbAutre = new System.Windows.Forms.RadioButton();
            this.rdbEtudiant = new System.Windows.Forms.RadioButton();
            this.rdbCE = new System.Windows.Forms.RadioButton();
            this.chkMajoration3D = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTarifApplicable = new System.Windows.Forms.Button();
            this.lblTarifApplicable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixHoraire
            // 
            this.lblChoixHoraire.AutoSize = true;
            this.lblChoixHoraire.Location = new System.Drawing.Point(35, 79);
            this.lblChoixHoraire.Name = "lblChoixHoraire";
            this.lblChoixHoraire.Size = new System.Drawing.Size(123, 20);
            this.lblChoixHoraire.TabIndex = 0;
            this.lblChoixHoraire.Text = "Choisir l\'horaire : ";
            // 
            // lblChoixJour
            // 
            this.lblChoixJour.AutoSize = true;
            this.lblChoixJour.Location = new System.Drawing.Point(35, 132);
            this.lblChoixJour.Name = "lblChoixJour";
            this.lblChoixJour.Size = new System.Drawing.Size(115, 20);
            this.lblChoixJour.TabIndex = 1;
            this.lblChoixJour.Text = "Choisir un jour : ";
            // 
            // lblTarif11h
            // 
            this.lblTarif11h.AutoSize = true;
            this.lblTarif11h.Location = new System.Drawing.Point(388, 79);
            this.lblTarif11h.Name = "lblTarif11h";
            this.lblTarif11h.Size = new System.Drawing.Size(114, 20);
            this.lblTarif11h.TabIndex = 2;
            this.lblTarif11h.Text = "(5,20 € à 11h10)";
            // 
            // lblTarifLundi
            // 
            this.lblTarifLundi.AutoSize = true;
            this.lblTarifLundi.Location = new System.Drawing.Point(388, 132);
            this.lblTarifLundi.Name = "lblTarifLundi";
            this.lblTarifLundi.Size = new System.Drawing.Size(114, 20);
            this.lblTarifLundi.TabIndex = 3;
            this.lblTarifLundi.Text = "(5,70 € le Lundi)";
            // 
            // lblPleinTarif
            // 
            this.lblPleinTarif.AutoSize = true;
            this.lblPleinTarif.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPleinTarif.Location = new System.Drawing.Point(35, 22);
            this.lblPleinTarif.Name = "lblPleinTarif";
            this.lblPleinTarif.Size = new System.Drawing.Size(167, 25);
            this.lblPleinTarif.TabIndex = 6;
            this.lblPleinTarif.Text = "Plein tarif : 8,70 €";
            // 
            // picTicket
            // 
            this.picTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTicket.BackgroundImage")));
            this.picTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTicket.Location = new System.Drawing.Point(437, 183);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(162, 143);
            this.picTicket.TabIndex = 7;
            this.picTicket.TabStop = false;
            this.picTicket.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "11h10",
            "13h10",
            "15h10",
            "18h10",
            "20h15",
            "23h15"});
            this.comboBox1.Location = new System.Drawing.Point(201, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.comboBox2.Location = new System.Drawing.Point(201, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCarte);
            this.groupBox1.Controls.Add(this.rdbAutre);
            this.groupBox1.Controls.Add(this.rdbEtudiant);
            this.groupBox1.Controls.Add(this.rdbCE);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(35, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 174);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarif réduit";
            // 
            // lblCarte
            // 
            this.lblCarte.AutoSize = true;
            this.lblCarte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarte.Location = new System.Drawing.Point(13, 123);
            this.lblCarte.Name = "lblCarte";
            this.lblCarte.Size = new System.Drawing.Size(171, 38);
            this.lblCarte.TabIndex = 3;
            this.lblCarte.Text = "(carte vermeil, carte famille\r\n nombreuse, handicapé)";
            // 
            // rdbAutre
            // 
            this.rdbAutre.AutoSize = true;
            this.rdbAutre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbAutre.Location = new System.Drawing.Point(6, 87);
            this.rdbAutre.Name = "rdbAutre";
            this.rdbAutre.Size = new System.Drawing.Size(112, 24);
            this.rdbAutre.TabIndex = 2;
            this.rdbAutre.TabStop = true;
            this.rdbAutre.Text = "Autre : 6,90€";
            this.rdbAutre.UseVisualStyleBackColor = true;
            // 
            // rdbEtudiant
            // 
            this.rdbEtudiant.AutoSize = true;
            this.rdbEtudiant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbEtudiant.Location = new System.Drawing.Point(6, 57);
            this.rdbEtudiant.Name = "rdbEtudiant";
            this.rdbEtudiant.Size = new System.Drawing.Size(202, 24);
            this.rdbEtudiant.TabIndex = 1;
            this.rdbEtudiant.TabStop = true;
            this.rdbEtudiant.Text = "Étudiant ou mineur : 5,90€";
            this.rdbEtudiant.UseVisualStyleBackColor = true;
            // 
            // rdbCE
            // 
            this.rdbCE.AutoSize = true;
            this.rdbCE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCE.Location = new System.Drawing.Point(7, 27);
            this.rdbCE.Name = "rdbCE";
            this.rdbCE.Size = new System.Drawing.Size(206, 24);
            this.rdbCE.TabIndex = 0;
            this.rdbCE.TabStop = true;
            this.rdbCE.Text = "Comité d\'entreprise : 5,20€";
            this.rdbCE.UseVisualStyleBackColor = true;
            // 
            // chkMajoration3D
            // 
            this.chkMajoration3D.AutoSize = true;
            this.chkMajoration3D.Location = new System.Drawing.Point(35, 398);
            this.chkMajoration3D.Name = "chkMajoration3D";
            this.chkMajoration3D.Size = new System.Drawing.Size(203, 24);
            this.chkMajoration3D.TabIndex = 11;
            this.chkMajoration3D.Text = "Majoration film 3D : 1,50€";
            this.chkMajoration3D.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(35, 428);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(185, 24);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "coupon réduction : -1€ ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(201, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "AUTRE TICKET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTarifApplicable
            // 
            this.btnTarifApplicable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTarifApplicable.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTarifApplicable.FlatAppearance.BorderSize = 3;
            this.btnTarifApplicable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifApplicable.Location = new System.Drawing.Point(437, 367);
            this.btnTarifApplicable.Name = "btnTarifApplicable";
            this.btnTarifApplicable.Size = new System.Drawing.Size(126, 55);
            this.btnTarifApplicable.TabIndex = 14;
            this.btnTarifApplicable.Text = "Tarif\r\napplicable";
            this.btnTarifApplicable.UseVisualStyleBackColor = false;
            // 
            // lblTarifApplicable
            // 
            this.lblTarifApplicable.BackColor = System.Drawing.Color.IndianRed;
            this.lblTarifApplicable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTarifApplicable.Location = new System.Drawing.Point(465, 428);
            this.lblTarifApplicable.Name = "lblTarifApplicable";
            this.lblTarifApplicable.Size = new System.Drawing.Size(70, 25);
            this.lblTarifApplicable.TabIndex = 15;
            this.lblTarifApplicable.Text = "8,70€";
            this.lblTarifApplicable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(607, 597);
            this.Controls.Add(this.lblTarifApplicable);
            this.Controls.Add(this.btnTarifApplicable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkMajoration3D);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picTicket);
            this.Controls.Add(this.lblPleinTarif);
            this.Controls.Add(this.lblTarifLundi);
            this.Controls.Add(this.lblTarif11h);
            this.Controls.Add(this.lblChoixJour);
            this.Controls.Add(this.lblChoixHoraire);
            this.Name = "Cinema";
            this.Text = "Tarif Cinéma";
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixHoraire;
        private System.Windows.Forms.Label lblChoixJour;
        private System.Windows.Forms.Label lblTarif11h;
        private System.Windows.Forms.Label lblTarifLundi;
        private System.Windows.Forms.Label lblPleinTarif;
        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCarte;
        private System.Windows.Forms.RadioButton rdbAutre;
        private System.Windows.Forms.RadioButton rdbEtudiant;
        private System.Windows.Forms.RadioButton rdbCE;
        private System.Windows.Forms.CheckBox chkMajoration3D;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTarifApplicable;
        private System.Windows.Forms.Label lblTarifApplicable;
    }
}

