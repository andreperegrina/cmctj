using cmctj.Utils;
using CMCTJ.BusinessEntity;
using CMCTJ.BusinessLogic.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmctj.Carrera
{
    public partial class FormIniciarCarrera : Form
    {
        public FormIniciarCarrera()
        {
            InitializeComponent();
            WrapperManager nuevoWrapperManager = new WrapperManager();
            sglueDxCategoria.Properties.DataSource = nuevoWrapperManager.GetAllCategoriaWrapper();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CarreraInicioCategoriaManager nuevoManager = new CarreraInicioCategoriaManager();
            int? carreraID = (int?)SessionData.Instance["carrera_actual_id"];
            carrera_inicio_categoria nuevoInicioCarrera = new carrera_inicio_categoria()
            {
                carrera_id = carreraID.Value,
                 categoria_id=(int)sglueDxCategoria.EditValue,
                 tiempo_inicio_carrera=DateTime.Now
            };

            nuevoManager.Save(nuevoInicioCarrera);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
