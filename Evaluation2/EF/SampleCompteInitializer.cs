using Evaluation2.UTILEMETIER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.EF
{
    public class SampleCompteInitializer : CreateDatabaseIfNotExists<EfContext>
    {
        protected override void Seed(EfContext context)
        {
            foreach (var compte in Utils.GetComptes()) context.Comptes.Add(compte);
            //base.Seed(context);
            context.SaveChanges();
        }
    }
}
