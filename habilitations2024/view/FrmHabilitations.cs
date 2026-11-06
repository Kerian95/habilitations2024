using System;
using System.Collections.Generic;
using System.Windows.Forms;
using habilitations2024.controller;
using habilitations2024.model;

namespace habilitations2024.view
{
    public partial class FrmHabilitations : Form
    {
        // contrôleur de la fenêtre
        private FrmHabilitationsController controller;
        // intermédiaires entre les listes et les contrôles visuels
        private readonly BindingSource bdgDeveloppeurs = new BindingSource();
        private readonly BindingSource bdgProfils = new BindingSource();
        private bool enCoursDeModifDev = false;

        public FrmHabilitations()
        {
            InitializeComponent();
        }

        // au chargement de la fenêtre
        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new FrmHabilitationsController();
            RemplirListeDeveloppeurs();
            RemplirListeProfils();
        }

        // remplit le tableau des développeurs
        private void RemplirListeDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = controller.GetLesDeveloppeurs();
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvDeveloppeurs.DataSource = bdgDeveloppeurs;
            // on cache les colonnes inutiles à l'affichage
            dgvDeveloppeurs.Columns["Iddeveloppeur"].Visible = false;
            dgvDeveloppeurs.Columns["Pwd"].Visible = false;
        }

        // remplit le combo des profils
        private void RemplirListeProfils()
        {
            List<Profil> lesProfils = controller.GetLesProfils();
            bdgProfils.DataSource = lesProfils;
            cboProfil.DataSource = bdgProfils;
            // sélectionne le premier profil par défaut
            if (cboProfil.Items.Count > 0)
            {
                cboProfil.SelectedIndex = 0;
            }
        }

        private void ViderZoneDev()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cboProfil.SelectedIndex = 0;
        }

        // active (true) ou désactive (false) le mode modification
        private void ActiverModeModif(bool modif)
        {
            enCoursDeModifDev = modif;
            grbLesDeveloppeurs.Enabled = !modif;   // zone 1 bloquée pendant une modification
            if (modif)
            {
                grbDeveloppeur.Text = "modifier un développeur";
            }
            else
            {
                grbDeveloppeur.Text = "ajouter un développeur";
            }
        }

        private void btnDemandeSupprDev_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                // récupère le développeur de la ligne sélectionnée
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                // demande une confirmation
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " ?",
                    "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();   // réaffiche le tableau à jour
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnEnregDev_Click(object sender, EventArgs e)
        {
            // vérifie que tous les champs sont remplis
            if (!string.IsNullOrWhiteSpace(txtNom.Text) && !string.IsNullOrWhiteSpace(txtPrenom.Text)
                && !string.IsNullOrWhiteSpace(txtTel.Text) && !string.IsNullOrWhiteSpace(txtMail.Text))
            {
                // récupère le profil sélectionné dans le combo
                Profil profil = (Profil)bdgProfils.List[bdgProfils.Position];
                if (enCoursDeModifDev)
                {
                    // modification : on récupère le développeur sélectionné et on le met à jour
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = txtPrenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    controller.UpdateDeveloppeur(developpeur);
                }
                else
                {
                    // ajout : 0 pour l'id car il est généré par la base
                    Developpeur developpeur = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil);
                    controller.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                ViderZoneDev();
                ActiverModeModif(false);   // on revient en mode ajout
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnAnnulDev_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViderZoneDev();
                ActiverModeModif(false);
            }
        }

        private void btnDemandeModifDev_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                ActiverModeModif(true);
                // récupère le développeur sélectionné
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                // affiche ses informations dans la zone 2
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                // sélectionne son profil dans le combo (recherche par le nom affiché)
                cboProfil.SelectedIndex = cboProfil.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}