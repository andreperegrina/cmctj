using CMCTJ.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmctj
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
            Application.ThreadException += App_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());


        }


        public static void App_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            //El usuario desea continuar?
            StringBuilder msg = new StringBuilder();

            msg.AppendLine("Ooops! ha ocurrido un problema en la aplicación:");
            msg.AppendLine(e.Exception.Message);

            DialogResult res;

            if (e.Exception.Message.ToUpper().Contains("OPEN") == false)
            {
                msg.Append("¿Desea continuar la ejecución de la aplicación?");

                res = MessageBox.Show(msg.ToString(), "Error inesperado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                msg.Append("Contacte con un administrador y vuelva a intentar");

                res = MessageBox.Show(msg.ToString(), "Error inesperado",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (res == DialogResult.Yes)
            {
                //Si desea continuar, no hacemos nada
                return;
            }
            else
            {
                //Si desea salir de la aplicación, la cerramos
                Application.Exit();
            }
        }

    }
}
