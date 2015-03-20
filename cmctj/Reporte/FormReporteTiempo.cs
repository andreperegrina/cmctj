using CMCTJ.BusinessLogic.Manager;
using CMCTJ.BusinessLogic.Wrapper;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
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

namespace cmctj.Reporte
{
    public partial class FormReporteTiempo : Form
    {
        public FormReporteTiempo()
        {
            InitializeComponent();
            this.ActualizarDatos();
        }

        public void ActualizarDatos()
        {

            WrapperManager nuevoWrapperManager = new WrapperManager();
            List<CorredorTiempoReporte> tiempoWrapperLista =
                nuevoWrapperManager.GetAllCorredorTiempoReporteWrapper();
            gcDxTiempo.DataSource = tiempoWrapperLista;
        }


        public void ExportToPDF(PivotGridControl gcDxCualquierGrid)
        {
            SaveFileDialog saveDialog = new SaveFileDialog() { Title = "Guardar como", DefaultExt = ".pdf", AddExtension = true, CheckPathExists = true, Filter = "Archivos de Acrobat Reader (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*" };
            saveDialog.ShowDialog();
            //XlsExportOptions options = new XlsExportOptions();
            //options.TextExportMode = TextExportMode.Text;
            if (!string.IsNullOrEmpty(saveDialog.FileName))
                gcDxCualquierGrid.ExportToPdf(saveDialog.FileName);
        }
        public void ExportToExcel(PivotGridControl gcDxCualquierGrid)
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

        private void vGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gcDxTiempo_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {

        }

        private void gcDxTiempo_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
           
        }
    }
}
