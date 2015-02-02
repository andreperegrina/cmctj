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

namespace cmctj.Corredor
{
    public partial class FormCrearEditarCorredor : Form
    {
        public FormCrearEditarCorredor()
        {
            InitializeComponent();

            //Ejemplo de como llenar los combo
            WrapperManager nuevoWrapperManager=new WrapperManager();
            sglueDxCategoria.Properties.DataSource = nuevoWrapperManager.GetAllCategoriaWrapper();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Ejemplo de como validar que no este vacio o cualquier validación
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                errPrValidar.SetError(txtNombre, "Elemento requerido");
                txtNombre.Focus();
                this.DialogResult = DialogResult.None;
            }

            //Para obtener el valor del combo 
            int cateogriaID = (int)sglueDxCategoria.EditValue;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
