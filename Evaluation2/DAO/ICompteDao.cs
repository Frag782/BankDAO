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
        Compte GetCompte(string numero);
        bool AjouterCompte(Compte compte);
        Tuple<string, float> GetNumeroAndSolde(string numero);
        string GetInformationComptes();
    }
}
