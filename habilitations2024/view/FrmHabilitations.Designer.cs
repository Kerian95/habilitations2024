namespace habilitations2024.view
{
    partial class FrmHabilitations
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
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.btnDemandeChangePwd = new System.Windows.Forms.Button();
            this.btnDemandeSupprDev = new System.Windows.Forms.Button();
            this.btnDemandeModifDev = new System.Windows.Forms.Button();
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.grbDeveloppeur = new System.Windows.Forms.GroupBox();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAnnulDev = new System.Windows.Forms.Button();
            this.btnEnregDev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPwd = new System.Windows.Forms.GroupBox();
            this.btnAnnulPwd = new System.Windows.Forms.Button();
            this.btnEnregPwd = new System.Windows.Forms.Button();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbLesDeveloppeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.grbDeveloppeur.SuspendLayout();
            this.grbPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeChangePwd);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeSupprDev);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeModifDev);
            this.grbLesDeveloppeurs.Controls.Add(this.dgvDeveloppeurs);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(12, 12);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(607, 365);
            this.grbLesDeveloppeurs.TabIndex = 0;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "les développeurs";
            // 
            // btnDemandeChangePwd
            // 
            this.btnDemandeChangePwd.Location = new System.Drawing.Point(348, 318);
            this.btnDemandeChangePwd.Name = "btnDemandeChangePwd";
            this.btnDemandeChangePwd.Size = new System.Drawing.Size(88, 23);
            this.btnDemandeChangePwd.TabIndex = 3;
            this.btnDemandeChangePwd.Text = "changer pwd";
            this.btnDemandeChangePwd.UseVisualStyleBackColor = true;
            this.btnDemandeChangePwd.Click += new System.EventHandler(this.btnDemandeChangePwd_Click);
            // 
            // btnDemandeSupprDev
            // 
            this.btnDemandeSupprDev.Location = new System.Drawing.Point(254, 318);
            this.btnDemandeSupprDev.Name = "btnDemandeSupprDev";
            this.btnDemandeSupprDev.Size = new System.Drawing.Size(88, 23);
            this.btnDemandeSupprDev.TabIndex = 2;
            this.btnDemandeSupprDev.Text = "supprimer";
            this.btnDemandeSupprDev.UseVisualStyleBackColor = true;
            this.btnDemandeSupprDev.Click += new System.EventHandler(this.btnDemandeSupprDev_Click);
            // 
            // btnDemandeModifDev
            // 
            this.btnDemandeModifDev.Location = new System.Drawing.Point(160, 318);
            this.btnDemandeModifDev.Name = "btnDemandeModifDev";
            this.btnDemandeModifDev.Size = new System.Drawing.Size(88, 23);
            this.btnDemandeModifDev.TabIndex = 1;
            this.btnDemandeModifDev.Text = "modifier";
            this.btnDemandeModifDev.UseVisualStyleBackColor = true;
            this.btnDemandeModifDev.Click += new System.EventHandler(this.btnDemandeModifDev_Click);
            // 
            // dgvDeveloppeurs
            // 
            this.dgvDeveloppeurs.AllowUserToAddRows = false;
            this.dgvDeveloppeurs.AllowUserToDeleteRows = false;
            this.dgvDeveloppeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(6, 19);
            this.dgvDeveloppeurs.MultiSelect = false;
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.ReadOnly = true;
            this.dgvDeveloppeurs.RowHeadersVisible = false;
            this.dgvDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(584, 282);
            this.dgvDeveloppeurs.TabIndex = 0;
            // 
            // grbDeveloppeur
            // 
            this.grbDeveloppeur.Controls.Add(this.cboProfil);
            this.grbDeveloppeur.Controls.Add(this.txtTel);
            this.grbDeveloppeur.Controls.Add(this.txtMail);
            this.grbDeveloppeur.Controls.Add(this.txtPrenom);
            this.grbDeveloppeur.Controls.Add(this.txtNom);
            this.grbDeveloppeur.Controls.Add(this.btnAnnulDev);
            this.grbDeveloppeur.Controls.Add(this.btnEnregDev);
            this.grbDeveloppeur.Controls.Add(this.label5);
            this.grbDeveloppeur.Controls.Add(this.label4);
            this.grbDeveloppeur.Controls.Add(this.label3);
            this.grbDeveloppeur.Controls.Add(this.label2);
            this.grbDeveloppeur.Controls.Add(this.label1);
            this.grbDeveloppeur.Location = new System.Drawing.Point(12, 393);
            this.grbDeveloppeur.Name = "grbDeveloppeur";
            this.grbDeveloppeur.Size = new System.Drawing.Size(380, 184);
            this.grbDeveloppeur.TabIndex = 2;
            this.grbDeveloppeur.TabStop = false;
            this.grbDeveloppeur.Text = "Ajouter un développeur";
            // 
            // cboProfil
            // 
            this.cboProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(230, 58);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(134, 21);
            this.cboProfil.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(230, 33);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(134, 20);
            this.txtTel.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(75, 87);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(241, 20);
            this.txtMail.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(75, 58);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(109, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(75, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(109, 20);
            this.txtNom.TabIndex = 8;
            // 
            // btnAnnulDev
            // 
            this.btnAnnulDev.Location = new System.Drawing.Point(97, 143);
            this.btnAnnulDev.Name = "btnAnnulDev";
            this.btnAnnulDev.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulDev.TabIndex = 7;
            this.btnAnnulDev.Text = "annuler";
            this.btnAnnulDev.UseVisualStyleBackColor = true;
            this.btnAnnulDev.Click += new System.EventHandler(this.btnAnnulDev_Click);
            // 
            // btnEnregDev
            // 
            this.btnEnregDev.Location = new System.Drawing.Point(16, 143);
            this.btnEnregDev.Name = "btnEnregDev";
            this.btnEnregDev.Size = new System.Drawing.Size(75, 23);
            this.btnEnregDev.TabIndex = 6;
            this.btnEnregDev.Text = "enregistrer";
            this.btnEnregDev.UseVisualStyleBackColor = true;
            this.btnEnregDev.Click += new System.EventHandler(this.btnEnregDev_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "profil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // grbPwd
            // 
            this.grbPwd.Controls.Add(this.btnAnnulPwd);
            this.grbPwd.Controls.Add(this.btnEnregPwd);
            this.grbPwd.Controls.Add(this.txtPwd2);
            this.grbPwd.Controls.Add(this.txtPwd);
            this.grbPwd.Controls.Add(this.label7);
            this.grbPwd.Controls.Add(this.label6);
            this.grbPwd.Enabled = false;
            this.grbPwd.Location = new System.Drawing.Point(409, 393);
            this.grbPwd.Name = "grbPwd";
            this.grbPwd.Size = new System.Drawing.Size(210, 184);
            this.grbPwd.TabIndex = 3;
            this.grbPwd.TabStop = false;
            this.grbPwd.Text = "changer le mot de passe";
            // 
            // btnAnnulPwd
            // 
            this.btnAnnulPwd.Location = new System.Drawing.Point(97, 111);
            this.btnAnnulPwd.Name = "btnAnnulPwd";
            this.btnAnnulPwd.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPwd.TabIndex = 5;
            this.btnAnnulPwd.Text = "annuler";
            this.btnAnnulPwd.UseVisualStyleBackColor = true;
            this.btnAnnulPwd.Click += new System.EventHandler(this.btnAnnulPwd_Click);
            // 
            // btnEnregPwd
            // 
            this.btnEnregPwd.Location = new System.Drawing.Point(16, 111);
            this.btnEnregPwd.Name = "btnEnregPwd";
            this.btnEnregPwd.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPwd.TabIndex = 4;
            this.btnEnregPwd.Text = "enregistrer";
            this.btnEnregPwd.UseVisualStyleBackColor = true;
            this.btnEnregPwd.Click += new System.EventHandler(this.btnEnregPwd_Click);
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(63, 80);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(121, 20);
            this.txtPwd2.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(63, 51);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(121, 20);
            this.txtPwd.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "encore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "pwd";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 586);
            this.Controls.Add(this.grbPwd);
            this.Controls.Add(this.grbDeveloppeur);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbLesDeveloppeurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.grbDeveloppeur.ResumeLayout(false);
            this.grbDeveloppeur.PerformLayout();
            this.grbPwd.ResumeLayout(false);
            this.grbPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
        private System.Windows.Forms.GroupBox grbDeveloppeur;
        private System.Windows.Forms.GroupBox grbPwd;
        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulDev;
        private System.Windows.Forms.Button btnEnregDev;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnnulPwd;
        private System.Windows.Forms.Button btnEnregPwd;
        private System.Windows.Forms.Button btnDemandeChangePwd;
        private System.Windows.Forms.Button btnDemandeSupprDev;
        private System.Windows.Forms.Button btnDemandeModifDev;
    }
}

