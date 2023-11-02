using Evaluation2.EF;
using Evaluation2.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.DAO
{
    public class CompteDaoBd : ICompteDao
    {
        #region props
        public EfContext Context { get; }
        #endregion
        #region ctor
        public CompteDaoBd() => Context = new EfContext();
        #endregion
        #region implement
        public bool AjouterCompte(Compte compte)
        {
            if (GetCompte(compte.Numero) != null) return false;

            Context.Comptes.Add(compte);
            return Context.SaveChanges() != 0;
        }

        public Compte GetCompte(string numero)
        {
            return Context.Comptes.
                Where(cpte => cpte.Numero.Equals(numero)).
                FirstOrDefault();
        }

        public string GetInformationComptes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Information sur les comptes:");
            stringBuilder.AppendLine(new string('_', 25));
            stringBuilder.AppendLine($"Nombre de comptes :  {Context.Comptes.Count()}");
            stringBuilder.AppendLine($"Total des soldes :   {Context.Comptes.Sum(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Moyenne des soldes : {Context.Comptes.Average(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Solde minimum :      {Context.Comptes.Min(compte => compte.Solde)}");
            stringBuilder.AppendLine($"Solde maximum :      {Context.Comptes.Max(compte => compte.Solde)}");
            return stringBuilder.ToString();
        }

        public Tuple<string, float> GetNumeroAndSolde(string numero)
        {
            Compte compte = GetCompte(numero);

            if (compte == null) return null;
            return new Tuple<string, float>(compte.Numero, compte.Solde);
        }

        public bool ModifierSolde(Compte compte, float solde)
        {
            compte.Solde = solde;
            return Context.SaveChanges() != 0;
        }

        public bool SupprimerCompte(string numero)
        {
            Context.Comptes.Remove(GetCompte(numero));
            return Context.SaveChanges() != 0;
        }
        #endregion
    }
}
