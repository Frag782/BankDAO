using Evaluation2.DAO;
using Evaluation2.UTILEMETIER;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Evaluation2
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ICompteDao Dao { get; set; }
        public App()
        {
            Utils.CreateDatabaseWithSample();
            Dao = new CompteDaoBd();
        }
    }
}
