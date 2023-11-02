using Evaluation2.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.DAO
{
    public interface ICompteDao
    {
        #region CRUD
        Compte GetCompte(string numero);
        bool AjouterCompte(Compte compte);
        bool ModifierSolde(Compte compte, float solde);
        bool SupprimerCompte(string numero);
        #endregion

        string GetInformationComptes();
        Tuple<string, float> GetNumeroAndSolde(string numero);
    }
}
