using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.METIER
{
    public class Compte
    {
        #region props
        public long CompteId {  get; set; }
        public string Numero { get; set; }
        public float Solde { get; set; }
        public DateTime DateCreation {  get; set; }
        #endregion

        #region ctor
        public Compte() : this("Undefined") {}
        public Compte(string numero)
        {
            Numero = numero;
        }
        public Compte(string numero, float solde, DateTime dateCreation)
        {
            Numero = numero;
            Solde = solde;
            DateCreation = dateCreation;
        }
        #endregion

        #region methods
        public void Crediter(float montant) {
            Solde += montant;
        }
        public bool Debiter(float montant) {
            if (montant > Solde) return false;

            Solde -= montant;
            return true;
        }
        public override string ToString()
        {
            return String.Format(
                "Numéro : {0} \nSolde : {1}$ \nDate de création : {2}",
                Numero, Solde, DateCreation);
        }
        #endregion
    }
}
