﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Informes.frmRecordAcad_SelecEstudiantes());
            //Application.Run(new Adm.Frmusuario());
            //Application.Run(new Informes.frminformeEstudiantes());
        }
    }
}
