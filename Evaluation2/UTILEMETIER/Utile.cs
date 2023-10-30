using Evaluation2.METIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.UTILEMETIER
{
    public class Utile
    {
        public static List<Compte> GetComptes() {
            return new List<Compte>
            {
                new Compte("101", 100, new DateTime (2016, 10, 10 )),
                new Compte("102", 0, new DateTime (2017, 7, 18 )),
                new Compte("103", 100, new DateTime (2017, 3, 15 )),
                new Compte("104", 500, new DateTime (2016, 2, 05 )),
                new Compte("105", 200, new DateTime (2015, 8, 03 )),
                new Compte("106", 200, new DateTime (2014, 9, 24 )),
                new Compte("107", 200, new DateTime (2015, 1, 27 ))
            };
        }
    }
}
