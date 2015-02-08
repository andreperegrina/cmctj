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
            //Obtener objeto con el manager de corredor y llenar los campos del formulario
            //SessionData.Instance["corredo_id_editar];
           
            if (SessionData.Instance["corredor_id_editar"] != null)
            {
                LlenarFormulario();
            }
        }

        public void LlenarFormulario()
        {

            //TODO: Validar número
            CorredorManager nuevoCorredor = new CorredorManager();
            corredor nuevo = new corredor();
            nuevo = nuevoCorredor.GetCorredorById((int)SessionData.Instance["corredor_id_editar"]);
            txtId.Text = nuevo.numero.ToString();
            txtNombre.Text = nuevo.nombre;
            txtPaterno.Text = nuevo.apellido_paterno;
            txtMaterno.Text = nuevo.apellido_materno;
            dtFecha.DateTime = nuevo.fecha;
            dtFechaNacimiento.DateTime = nuevo.fecha_nacimiento;
            txtCorreo.Text = nuevo.correo;
            txtFacebook.Text = nuevo.facebook;
            txtTelefono.Text = nuevo.telefono;
            int sex = nuevo.sexo;
            if (sex == 0)
            {
                rbMasculino.Checked = true;
                rbFemenino.Checked = false;
            }
            else
            {
                rbMasculino.Checked = false;
                rbFemenino.Checked = true;
            }
            sglueDxClub.EditValue = nuevo.club_id;
            sglueDxCategoria.EditValue = nuevo.categoria_id;
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
            //
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
            ////Validar fecha de nacimiento
            //if (dtFechaNacimiento.DateTime == new DateTime())
            //{
            //    errPrValidar.SetError(dtFechaNacimiento, "Elemento requerido");
            //    this.DialogResult = DialogResult.None;
            //    return;
            //}
            //Validar club

            int? clubID = (int?)sglueDxClub.EditValue;
            //if (clubID == null)
            //{
            //    errPrValidar.SetError(sglueDxClub, "Elemento requerido");
            //    this.DialogResult = DialogResult.None;
            //    return;
            //}
            if (clubID==null)
            {
                
            clubID = 4;
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
            corredor nuevo = new corredor();
            if (SessionData.Instance["corredor_id_editar"] != null)
            {
                nuevo = nuevoCorredor.GetCorredorById((int)SessionData.Instance["corredor_id_editar"]);
                
            }
            nuevo.club_id = (int)clubID;
            nuevo.categoria_id = (int)cateogriaID;
            nuevo.fecha = dtFechaNacimiento.DateTime;
            nuevo.apellido_paterno = txtPaterno.Text;
            nuevo.apellido_materno = txtMaterno.Text;
            nuevo.nombre = txtNombre.Text;
            nuevo.fecha_nacimiento = dtFechaNacimiento.DateTime;
            nuevo.correo = txtCorreo.Text;
            nuevo.telefono = txtTelefono.Text;
            nuevo.facebook = txtFacebook.Text;
            nuevo.sexo = sex;
            int numero;
            bool esNumero=Int32.TryParse(txtId.Text, out numero);
            if (!esNumero)
            {
                
            }else
            nuevo.numero = numero;


            if (SessionData.Instance["corredor_id_editar"] == null)
            {

                nuevoCorredor.Save(nuevo);
            }
            else
            {
                nuevoCorredor.Update(nuevo);
            }
            MessageBox.Show("Corredor ingresado exitosamente");
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FormCrearEditarCorredor_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
