﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    static class Program
    {
        /// <summary> Punto de entrada principal para la aplicación. </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
