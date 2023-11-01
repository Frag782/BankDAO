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
        void ModifierCompte(Compte compte, float solde);
        bool SupprimerCompte(Compte compte);
        #endregion

        Tuple<string, float> GetNumeroAndSolde(string numero);
        string GetInformationComptes();
    }
}
