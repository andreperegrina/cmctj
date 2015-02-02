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
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNuevoTiempo nuevoTiempo = new FormNuevoTiempo();
            nuevoTiempo.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Corredor.FormCrearEditarCorredor nuevoTiempo = new Corredor.FormCrearEditarCorredor();
            nuevoTiempo.Show();
        }
    }
}
