using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ISET_2018_Decouverte
{
    sealed class ParamApplication : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        public string chConnDB
        {
            get { return (string)this["csPerso"]; }
            set { this["csPerso"] = value; }
        }
             
    }
    static class Program
    {
        public static ParamApplication PA = new ParamApplication();//its for accessing it in normal forms
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EcranAccueil());
            Application.Run(new EcranPrincipal());
        }
    }
}
