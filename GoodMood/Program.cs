/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using GoodMood.UI;
using GoodMood.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    static class Program
    {
        public static Dispatcher Dispatcher;

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var startupOptions = new CommandlineOptions();
            var options = new OptionSet()
                .Add("quiet", quiet => { startupOptions.Quiet = true; });
            options.Parse(args);
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;

            var mainForm = new FormMain(startupOptions);

            Dispatcher = new UI.Dispatcher();
            
            if (startupOptions.Quiet)
            {
                mainForm.HideToTrayArea();
            }
            else
            {
                mainForm.Show();
            }

            Application.Run();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Interaction.Error(e.Exception);
        }
    }
}
