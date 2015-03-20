using cmctj.Utils;
using CMCTJ.BusinessEntity;
using CMCTJ.BusinessLogic.Manager;
using CMCTJ.BusinessLogic.Wrapper;
using DevExpress.XtraGrid.Views.Grid;
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

            this.ActualizaDatosCategoria();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ActualizarDatos();
            this.ActualizaDatosCategoria();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var item in gcDxTiempo.ViewCollection)
            {
                if (item.GetType() == typeof(GridView))
                {
                    GridView grdview = (GridView)item as GridView;
                    int[] selectedRows = grdview.GetSelectedRows();
                    if (selectedRows.Length > 0)
                    {
                        DialogResult seleccion = MessageBox.Show("¿Realmente deseas eliminar este tiempo?", "Atención!!!", MessageBoxButtons.OKCancel);

                        if (seleccion == DialogResult.OK)
                        {

                            TiempoManager cor = new TiempoManager();

                            TiempoWrapper corredorSeleccionadoVW = (TiempoWrapper)grdview.GetRow(selectedRows[0]);

                            tiempo corredorSeleccionado = cor.GetTiempoById(corredorSeleccionadoVW.TiempoId);

                            cor.Remove(corredorSeleccionado);

                            grdview.FocusedRowHandle = selectedRows[0];

                            MessageBox.Show("Se elimino el tiempo", "Atención");
                            ActualizarDatos();

                        }
                    }
                    break;
                }
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var item in gcDxTiempo.ViewCollection)
            {
                if (item.GetType() == typeof(GridView))
                {
                    GridView grdview = (GridView)item as GridView;
                    int[] selectedRows = grdview.GetSelectedRows();
                    if (selectedRows.Length > 0)
                    {
                        DialogResult seleccion = MessageBox.Show("¿Realmente deseas eliminar este tiempo?", "Atención!!!", MessageBoxButtons.OKCancel);

                        if (seleccion == DialogResult.OK)
                        {

                            CarreraInicioCategoriaManager cor = new CarreraInicioCategoriaManager();

                            CarreraIniciadaWrapper corredorSeleccionadoVW = (CarreraIniciadaWrapper)gridView1.GetRow(selectedRows[0]);

                            carrera_inicio_categoria corredorSeleccionado = cor.GetById(corredorSeleccionadoVW.CarreraInicioCategoriaId);

                            cor.Remove(corredorSeleccionado);

                            grdview.FocusedRowHandle = selectedRows[0];

                            MessageBox.Show("Se elimino el tiempo", "Atención");
                            ActualizaDatosCategoria();

                        }
                    }
                    break;
                }
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Reporte.FormReporteTiempo nuevoTiempo = new Reporte.FormReporteTiempo())
            {
                nuevoTiempo.ShowDialog();
            }


        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Corredor.FormTiempoCorredor nuevoTiempo = new Corredor.FormTiempoCorredor())
            {
                nuevoTiempo.ShowDialog();
            }

        }
    }
}
