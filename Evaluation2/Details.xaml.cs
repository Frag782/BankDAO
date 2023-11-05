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
            AfficherDetailsCompte();
        }
        #endregion

        public void AfficherDetailsCompte() {
            lblNumero.Content = CompteDetails.Numero;
            lblCreation.Content = CompteDetails.DateCreation;
            lblSolde.Content = CompteDetails.Solde.ToString() + "$";
        }

        #region buttons
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

        private void btnDeposer_Click(object sender, RoutedEventArgs e)
        {
            if (!float.TryParse(txtMontantDepot.Text, out float montant) || (montant <= 0)) 
            {
                MessageBox.Show("Montant de dépôt invalide.");
                ClearTextBoxes();
                return;
            }

            float solde = CompteDetails.Solde + montant;
            Dao.ModifierSolde(CompteDetails, solde);
            AfficherDetailsCompte();
            ClearTextBoxes();
        }

        private void btnRetirer_Click(object sender, RoutedEventArgs e)
        {
            if (!float.TryParse(txtMontantRetrait.Text, out float montant) || (CompteDetails.Solde - montant < 0)) 
            {
                MessageBox.Show("Montant de retrait invalide.");
                ClearTextBoxes();
                return;
            }

            float solde = CompteDetails.Solde - montant;
            Dao.ModifierSolde(CompteDetails, solde);
            AfficherDetailsCompte();
            ClearTextBoxes();
        }
        #endregion

        private void ClearTextBoxes()
        {
            foreach (var box in new TextBox[] { txtMontantDepot, txtMontantRetrait }) box.Clear();
        }
    }
}
