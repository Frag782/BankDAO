using Evaluation2.METIER;
using Evaluation2.UTILEMETIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Comptes = Utile.GetComptes();
        }
        #endregion
        #region implementation
        public Compte GetCompte(string numero)
        {
            return Comptes.
                Where(compte => compte.Numero.Equals(numero)).
                FirstOrDefault();
        }

        public Tuple<string, float> GetNumeroAndSolde(string numero)
        {
            return Comptes.
                Where(compte => compte.Numero.Equals(numero)).
                Select(compte => new Tuple<string, float>(compte.Numero, compte.Solde)).
                FirstOrDefault();
        }
        public string GetInformationComptes() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Information sur les comptes:");
            stringBuilder.AppendLine($"Nombre de comptes : {Comptes.Count()}");
            stringBuilder.AppendLine($"Total des soldes : {Comptes.Sum(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Moyenne des soldes : {Comptes.Average(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Solde minimum : {Comptes.Min(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Solde maximum : {Comptes.Max(compte => compte.Solde)}");
            return stringBuilder.ToString();
        }

        public bool AjouterCompte(Compte compte)
        {
            if (GetCompte(compte.Numero) != null) return false;

            Comptes.Add(compte);
            return true;
        }
        #endregion
    }
}
