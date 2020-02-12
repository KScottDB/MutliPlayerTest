using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPlayerTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            char choice = ' ';
            
            Console.Write("[C]lient or [S]erver? ");

            // C or S
            while ("CScs".Contains(choice = Console.ReadKey().KeyChar)) { }

            Console.Write("\n");

            // Turn into FMain.States to pass into FMain
            FMain.States enuch;
            switch (choice)
            {
                case 'C':
                case 'c':
                    enuch = FMain.States.SearchingForServers;
                    break;

                case 'S':
                case 's':
                    enuch = FMain.States.Server;
                    break;

                default:
                    enuch = FMain.States.Server;
                    break;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain(enuch));
        }
    }
}
