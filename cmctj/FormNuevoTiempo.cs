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
            String numeroCorredor=txtEditNumero.Text;
            int numeroResultado=-1;
            Int32.TryParse(numeroCorredor,out numeroResultado);
            if (numeroResultado!=-1)
            {
                int? carreraID=(int?)SessionData.Instance["carrera_id_en_progreso"];
                CorredorManager corredorManager=new CorredorManager();
                corredor corredorSeleccionado=corredorManager.GetCorredorById(numeroResultado);
                TiempoManager managerTiempo=new TiempoManager();
                managerTiempo.RegistrarTiempo(corredorSeleccionado,carreraID.Value);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
