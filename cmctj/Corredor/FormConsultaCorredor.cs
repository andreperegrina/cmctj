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

namespace cmctj.Corredor
{
    public partial class FormConsultaCorredor : Form
    {
        public FormConsultaCorredor()
        {
            InitializeComponent();
            WrapperManager manager = new WrapperManager(); 
            List<CorredorWrapper> corredores=manager.GetAllCorredorWrapper();
            gcDxCorredores.DataSource = corredores;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaCorredor_Load(object sender, EventArgs e)
        {

        }

        private void gcDxCorredores_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Corredor.FormCrearEditarCorredor nuevoTiempo = new Corredor.FormCrearEditarCorredor();
            nuevoTiempo.ShowDialog();
            ActualizarDatos();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditarCorredor();
        }
        private void ActualizarDatos()
        {
            WrapperManager manager = new WrapperManager();
            List<CorredorWrapper> corredores = manager.GetAllCorredorWrapper();
            gcDxCorredores.DataSource = corredores;
        }
        public void EditarCorredor()
        {

            //Este te sirve
            foreach (var item in gcDxCorredores.ViewCollection)
            {

                //Este te sirve
                if (item.GetType() == typeof(GridView))
                {
                    GridView grdview = (GridView)item as GridView;
                    int[] selectedRows = grdview.GetSelectedRows();
                    if (selectedRows.Length > 0)
                    {
                        CorredorWrapper corredorSeleccionado = (CorredorWrapper)grdview.GetRow(selectedRows[0]);
                        if (corredorSeleccionado != null)
                        {

                            SessionData.Instance["corredor_id_editar"] = corredorSeleccionado.CorredorId;
                            Corredor.FormCrearEditarCorredor nuevoTiempo = new Corredor.FormCrearEditarCorredor();
                            nuevoTiempo.ShowDialog();
                            ActualizarDatos();
                            SessionData.Instance.Remove("corredor_id_editar");
                            grdview.FocusedRowHandle = selectedRows[0];
                        }
                        else
                        {
                            MessageBox.Show("No ha seleccionado ningún corredor", "Aviso");
                        }


                    }
                    break;
                }
            }
        }

        public void EliminarCorredor()
        {
            foreach (var item in gcDxCorredores.ViewCollection)
            {
                if (item.GetType() == typeof(GridView))
                {
                    GridView grdview = (GridView)item as GridView;
                    int[] selectedRows = grdview.GetSelectedRows();
                    if (selectedRows.Length > 0)
                    {
                        DialogResult seleccion = MessageBox.Show("¿Realmente deseas eliminar este corredor?", "Atención!!!", MessageBoxButtons.OKCancel);

                        if (seleccion == DialogResult.OK)
                        {

                            CorredorManager cor = new CorredorManager();

                            CorredorWrapper corredorSeleccionadoVW = (CorredorWrapper)grdview.GetRow(selectedRows[0]);

                            corredor corredorSeleccionado = cor.GetCorredorByNId(corredorSeleccionadoVW.CorredorId);
                           
                            cor.Remove(corredorSeleccionado);

                                grdview.FocusedRowHandle = selectedRows[0];
                            
                                MessageBox.Show("Se elimino el corredor", "Atención");
                                ActualizarDatos();

                        }
                    }
                    break;
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try{
            EliminarCorredor();
            }
            catch (Exception excep)
            {
                if (excep.InnerException != null)
                {
                    if (excep.InnerException.InnerException != null)
                    {
                        MySql.Data.MySqlClient.MySqlException exceptionMysql = (MySql.Data.MySqlClient.MySqlException)excep.InnerException.InnerException;
                         if (exceptionMysql.Number == 1451)
                         {
                             MessageBox.Show("No se puede eliminar el corredor porque ya tiene registros de carreras", "Atención");
                         }
                    }

                }

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (var item in gcDxCorredores.ViewCollection)
            {
                if (item.GetType() == typeof(GridView))
                {
                    GridView grdview = (GridView)item as GridView;
                    int[] selectedRows = grdview.GetSelectedRows();
                    if (selectedRows.Length > 0)
                    {
                        DialogResult seleccion = MessageBox.Show("¿Realmente deseas eliminar este corredor?", "Atención!!!", MessageBoxButtons.OKCancel);

                        if (seleccion == DialogResult.OK)
                        {

                            CorredorManager cor = new CorredorManager();

                            CorredorWrapper corredorSeleccionadoVW = (CorredorWrapper)grdview.GetRow(selectedRows[0]);

                            corredor corredorSeleccionado = cor.GetCorredorByNId(corredorSeleccionadoVW.CorredorId);

                            corredorSeleccionado.activo = 1;
                            cor.Update(corredorSeleccionado);

                            grdview.FocusedRowHandle = selectedRows[0];

                            MessageBox.Show("Se activo el corredor", "Atención");
                            ActualizarDatos();

                        }
                    }
                    break;
                }
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            foreach (var item in gcDxCorredores.ViewCollection)
            {
                if (item.GetType() == typeof(GridView))
                {
                    GridView grdview = (GridView)item as GridView;
                    int[] selectedRows = grdview.GetSelectedRows();
                    if (selectedRows.Length > 0)
                    {
                        DialogResult seleccion = MessageBox.Show("¿Realmente deseas eliminar este corredor?", "Atención!!!", MessageBoxButtons.OKCancel);

                        if (seleccion == DialogResult.OK)
                        {

                            CorredorManager cor = new CorredorManager();

                            CorredorWrapper corredorSeleccionadoVW = (CorredorWrapper)grdview.GetRow(selectedRows[0]);

                            corredor corredorSeleccionado = cor.GetCorredorByNId(corredorSeleccionadoVW.CorredorId);

                            corredorSeleccionado.activo = 0;
                            cor.Update(corredorSeleccionado);

                            grdview.FocusedRowHandle = selectedRows[0];

                            MessageBox.Show("Se activo el corredor", "Atención");
                            ActualizarDatos();

                        }
                    }
                    break;
                }
            }
        }
    }
}
