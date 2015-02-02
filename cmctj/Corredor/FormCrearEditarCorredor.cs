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

namespace cmctj.Corredor
{
    public partial class FormCrearEditarCorredor : Form
    {
        public FormCrearEditarCorredor()
        {
            InitializeComponent();

            //Ejemplo de como llenar los combo
            dtFecha.DateTime = DateTime.Today;
            WrapperManager nuevoWrapperManager=new WrapperManager();
            sglueDxCategoria.Properties.DataSource = nuevoWrapperManager.GetAllCategoriaWrapper();
            sglueDxClub.Properties.DataSource = nuevoWrapperManager.GetAllClubWrapper();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errPrValidar.Clear();

            //Validar el sexo
            if (rbMasculino.Checked != true && rbFemenino.Checked != true)
            {
                errPrValidar.SetError(gbSexo, "Elemento requerido");
                this.DialogResult = DialogResult.None;
                return;
            }
            
            //Validar apellido paterno
            if (String.IsNullOrEmpty(txtPaterno.Text))
            {
                errPrValidar.SetError(txtPaterno, "Elemento requerido");
                txtPaterno.Focus();
                this.DialogResult = DialogResult.None;
               return;
            }
            //Ejemplo de como validar que no este vacio o cualquier validación
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                errPrValidar.SetError(txtNombre, "Elemento requerido");
                txtNombre.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            //Validar fecha de nacimiento
            if (dtFechaNacimiento.DateTime == new DateTime())
            {
                errPrValidar.SetError(dtFechaNacimiento, "Elemento requerido");
                this.DialogResult = DialogResult.None;
                return;
            }
            //Validar club

            int? clubID = (int?)sglueDxClub.EditValue;
            if (clubID == null)
            {
                errPrValidar.SetError(sglueDxClub, "Elemento requerido");
                this.DialogResult = DialogResult.None;
                return;
            }
            //Validar categoria

            int? cateogriaID = (int?)sglueDxCategoria.EditValue;
            if (cateogriaID == null)
            {
                errPrValidar.SetError(sglueDxCategoria, "Elemento requerido");
                this.DialogResult = DialogResult.None;
                return;
            }
            //Obtener valor para el sexo
            int sex;
            if (rbMasculino.Checked == true)
                sex = 0;
            else
                sex = 1;
            CorredorManager nuevoCorredor = new CorredorManager();
            corredor nuevo = new corredor() { 
                club_id = (int)clubID, 
                categoria_id = (int)cateogriaID,
                fecha = dtFechaNacimiento.DateTime,
                apellido_paterno = txtPaterno.Text,
                apellido_materno = txtMaterno.Text,
                nombre = txtNombre.Text,
                fecha_nacimiento = dtFechaNacimiento.DateTime,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text,
                facebook = txtFacebook.Text,
                sexo = sex
                
            };
            nuevoCorredor.Save(nuevo);
            MessageBox.Show("Corredor ingresado exitosamente");


            
            

            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
