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
        public Compte CompteDetails { get; set; }
        #endregion
        #region ctor
        public Details(Compte compte)
        {
            InitializeComponent();
            CompteDetails = compte;
            AjouterDetails();
        }
        #endregion

        public void AjouterDetails() {
            lblNumero.Content = CompteDetails.Numero;
            lblCreation.Content = CompteDetails.DateCreation;
            txtSolde.Text = CompteDetails.Solde.ToString();
        }
    }
}
