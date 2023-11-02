using Evaluation2.DAO;
using Evaluation2.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Evaluation2
{
    /// <summary>
    /// Logique d'interaction pour Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        #region props
        public ICompteDao Dao { get; set; }
        public Compte CompteDetails { get; set; }
        #endregion
        #region ctor
        public Details(Compte compte)
        {
            InitializeComponent();
            Dao = (Application.Current as App).Dao;
            CompteDetails = compte;
            AjouterDetails();
        }
        #endregion

        public void AjouterDetails() {
            lblNumero.Content = CompteDetails.Numero;
            lblCreation.Content = CompteDetails.DateCreation;
            txtSolde.Text = CompteDetails.Solde.ToString();
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ce compte ?",
                "Confirmation de suppression",
                MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No) return;

            Dao.SupprimerCompte(CompteDetails.Numero);
            this.Close();
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            if (!float.TryParse(txtSolde.Text, out float solde) || (solde < 0)) {
                MessageBox.Show("Montant du solde invalide.");
                txtSolde.Text = CompteDetails.Solde.ToString();
                return;
            }

            MessageBox.Show(Dao.ModifierSolde(CompteDetails, solde) ? "Solde du compte modifié." : "Échec de la modification.");
            txtSolde.Text = CompteDetails.Solde.ToString();
        }
    }
}
