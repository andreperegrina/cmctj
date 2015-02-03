using cmctj.Utils;
using CMCTJ.BusinessLogic.Manager;
using CMCTJ.BusinessLogic.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmctj
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CarreraManager nuevoCarreraManager = new CarreraManager();
            this.ActualizarDatos();
            this.ActualizaDatosCategoria();
            int nuevoCarreraManagerGetCarreraActualcarrera_id = nuevoCarreraManager.GetCarreraActual().carrera_id;
            SessionData.Instance["carrera_actual_id"] = nuevoCarreraManagerGetCarreraActualcarrera_id;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FormNuevoTiempo nuevoTiempo = new FormNuevoTiempo())
            {
                nuevoTiempo.ShowDialog();
            }

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            WrapperManager nuevoWrapperManager = new WrapperManager();
            List<TiempoWrapper> tiempoWrapperLista =
                nuevoWrapperManager.GetAllTiempoWrapper();
            gcDxTiempo.DataSource = tiempoWrapperLista;
        }

        private void ActualizaDatosCategoria()
        {
            WrapperManager nuevoWrapperManager = new WrapperManager();
            List<CarreraIniciadaWrapper> tiempoWrapperLista =
                nuevoWrapperManager.GetAllCarreraIniciadaWrapper();
            gcDxCarreasIniciadas.DataSource = tiempoWrapperLista;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (Corredor.FormConsultaCorredor nuevoTiempo = new Corredor.FormConsultaCorredor())
            {
                nuevoTiempo.ShowDialog();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (Carrera.FormIniciarCarrera nuevoTiempo = new Carrera.FormIniciarCarrera())
            {
                nuevoTiempo.ShowDialog();
            }
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ActualizarDatos();
        }
    }
}
