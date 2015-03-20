using CMCTJ.BusinessLogic.Manager;
using CMCTJ.BusinessLogic.Wrapper;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
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
    public partial class FormTiempoCorredor : Form
    {
        public FormTiempoCorredor()
        {
            InitializeComponent();
            this.ActualizarDatos();
        }

        public void ActualizarDatos()
        {
            WrapperManager nuevoWrapperManager = new WrapperManager();
            List<CorredorTiempoWrapper> tiempoWrapperLista =
                nuevoWrapperManager.GetReporteGanadores();
            gcDxTiempo.DataSource = tiempoWrapperLista;
        }


        public void ExportToPDF(GridControl gcDxCualquierGrid)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Guardar como";
            saveDialog.DefaultExt = ".pdf";
            saveDialog.AddExtension = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "Archivos de Acrobat Reader (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            saveDialog.ShowDialog();
            //XlsExportOptions options = new XlsExportOptions();
            //options.TextExportMode = TextExportMode.Text;
            if (!string.IsNullOrEmpty(saveDialog.FileName))
                gcDxCualquierGrid.ExportToPdf(saveDialog.FileName);
        }
        public void ExportToExcel(GridControl gcDxCualquierGrid)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Guardar como";
            saveDialog.DefaultExt = ".xls";
            saveDialog.AddExtension = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "Archivos de Microsoft Excel 2007 (*.xls)|*.xls|Todos los archivos (*.*)|*.*";
            saveDialog.ShowDialog();
            XlsExportOptions options = new XlsExportOptions();
            options.TextExportMode = TextExportMode.Text;
            if (!string.IsNullOrEmpty(saveDialog.FileName))
                gcDxCualquierGrid.ExportToXls(saveDialog.FileName, options);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ActualizarDatos();

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ExportToPDF(gcDxTiempo);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToExcel(gcDxTiempo);
        }
    }
}
