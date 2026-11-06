using System;
using System.Windows.Forms;
using habilitations2024.controller;
using habilitations2024.model;

namespace habilitations2024.view
{
    public partial class FrmAuthentification : Form
    {
        // contrôleur de la fenêtre
        private readonly FrmAuthentificationController controller;

        public FrmAuthentification()
        {
            InitializeComponent();
            controller = new FrmAuthentificationController();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // vérifie que tous les champs sont remplis
            if (!string.IsNullOrWhiteSpace(txtNom.Text) && !string.IsNullOrWhiteSpace(txtPrenom.Text)
                && !string.IsNullOrEmpty(txtPwd.Text))
            {
                // regroupe les saisies dans un objet Admin
                Admin admin = new Admin(txtNom.Text, txtPrenom.Text, txtPwd.Text);
                // demande au contrôleur de vérifier
                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frm = new FrmHabilitations();
                    this.Hide();        // cache la fenêtre de connexion
                    frm.ShowDialog();   // ouvre FrmHabilitations et attend sa fermeture
                    this.Close();       // ferme la connexion, donc l'application
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin.", "Alerte");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}