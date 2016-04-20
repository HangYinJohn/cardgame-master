using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameNewVersion
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
            GameLevelDifficult gameForm = new GameLevelDifficult();
            StartMenu myForm = new StartMenu();
            Model myModel = new Model();
            Controller myController = new Controller(gameForm, myModel);
            myForm.SetController(myController);
            myController.SetController();
            myController.Go();
            Application.Run(myForm);
        }
    }
}
