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
        public CompteDao()
        {
            Comptes = Utile.GetComptes();
        }

        public List<Compte> Comptes {  get; }

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
        #endregion
    }
}
