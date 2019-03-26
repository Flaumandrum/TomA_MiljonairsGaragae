using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomA_MiljonairsGaragae
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
        //Tom Adriaens
        //25/03/2019
        //Project Miljonairsgarage
        //velden
        static string[] _merk;
        static string[] _kleur;
        static string[] _nrPlaat;
 
        //functies en methoden
        static public void AanmaakArrays(int ontvAantalAutos)
        {
            _merk = new string[ontvAantalAutos];
            _kleur = new string[ontvAantalAutos];
            _nrPlaat = new string[ontvAantalAutos];
        }

    }

}
