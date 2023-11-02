using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.METIER
{
    [Table("Compte")]
    public class Compte
    {
        #region props
        [Key]
        [Column("IdCompte")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CompteId {  get; set; }
        [Column("Numero")]
        [Required]
        [MaxLength(20)]
        public string Numero { get; set; }
        [Column("Solde")]
        [DataType("Real")]
        public float Solde { get; set; }
        [Column("DateCreation")]
        [Required]
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
