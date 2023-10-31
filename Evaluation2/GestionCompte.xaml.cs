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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Evaluation2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region props
        public ICompteDao Dao { get; }
        #endregion
        #region ctor
        public MainWindow()
        {
            InitializeComponent();
            Dao = new CompteDao();
        }
        #endregion

        private void btnRechercher_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumero.Text == "") return;
            Compte compte = Dao.GetCompte(txtNumero.Text);

            MessageBox.Show(compte != null ? compte.ToString() : "Compte introuvable.");
            txtNumero.Clear();
        }

        private void btnCreer_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumero2.Text == "") {
                MessageBox.Show("Veuillez saisir un numéro de compte.");
                ClearTextBoxes();
                return;
            }

            bool succes = Dao.AjouterCompte(
                new Compte {
                    Numero = txtNumero2.Text,
                    Solde = float.TryParse(txtSolde.Text, out float solde) ? solde : 0,
                    DateCreation = DateTime.Now
                }
            );

            MessageBox.Show(succes ? $"Compte # {txtNumero2.Text} ajouté." : "Ce numéro de compte existe déjà.");
            ClearTextBoxes();
        }

        private void ClearTextBoxes() {
            foreach (var box in new TextBox[] { txtNumero, txtNumero2, txtSolde}) box.Clear();
        }
    }
}
