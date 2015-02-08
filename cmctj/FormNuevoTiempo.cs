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

namespace cmctj
{
    public partial class FormNuevoTiempo : Form
    {
        public FormNuevoTiempo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lbMensajeError.Text = "";
            String numeroCorredor=txtEditNumero.Text;
            int numeroResultado=-1;
            bool esNumero=Int32.TryParse(numeroCorredor,out numeroResultado);
            //TODO:AGREGAR CORREDOR
            if (esNumero && numeroResultado != -1)
            {
                WrapperManager wrapperManager = new WrapperManager();
                if (wrapperManager.GetBuscaCorredorById(numeroResultado) >= 0)
                {
                    int? carreraID = (int?)SessionData.Instance["carrera_actual_id"];
                    CorredorManager corredorManager = new CorredorManager();
                    corredor corredorSeleccionado = corredorManager.GetCorredorById(numeroResultado);
                    TiempoManager managerTiempo = new TiempoManager();
                    managerTiempo.RegistrarTiempo(corredorSeleccionado, carreraID.Value);
                    txtEditNumero.Text = "";
                }
                else
                {
                   lbMensajeError.Text = "Error no se encontro corredor";
                }
            }
            else
            {

                lbMensajeError.Text = "Por favor ingrese un número valido";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
