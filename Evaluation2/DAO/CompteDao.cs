using Evaluation2.METIER;
using Evaluation2.UTILEMETIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Evaluation2.DAO
{
    public class CompteDao : ICompteDao
    {
        #region props
        public List<Compte> Comptes { get; }
        #endregion
        #region ctor
        public CompteDao()
        {
            Comptes = Utils.GetComptes();
        }
        #endregion
        #region implement
        public Compte GetCompte(string numero)
        {
            return Comptes.
                Where(compte => compte.Numero.Equals(numero)).
                FirstOrDefault();
        }

        public bool AjouterCompte(Compte compte)
        {
            if (GetCompte(compte.Numero) != null) return false;

            Comptes.Add(compte);
            return true;
        }

        public bool ModifierSolde(Compte compte, float solde)
        {
            if (!Comptes.Exists(cpte => cpte.Numero == compte.Numero)) return false;

            Comptes.Find(cpte => cpte.Numero == compte.Numero).Solde = solde;
            return true;
        }

        public bool SupprimerCompte(string numero)
        {
            return Comptes.Remove(GetCompte(numero));
        }

        public Tuple<string, float> GetNumeroAndSolde(string numero)
        {
            return Comptes.
                Where(compte => compte.Numero.Equals(numero)).
                Select(compte => new Tuple<string, float>(compte.Numero, compte.Solde)).
                FirstOrDefault();
        }
        public string GetInformationComptes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Information sur les comptes:");
            stringBuilder.AppendLine(new string('_', 25));
            stringBuilder.AppendLine($"Nombre de comptes :  {Comptes.Count()}");
            stringBuilder.AppendLine($"Total des soldes :   {Comptes.Sum(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Moyenne des soldes : {Comptes.Average(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Solde minimum :      {Comptes.Min(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Solde maximum :      {Comptes.Max(compte => compte.Solde)}");
            return stringBuilder.ToString();
        }
        #endregion
    }
}
