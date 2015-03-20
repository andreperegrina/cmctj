using CMCTJ.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Manager
{
    public class CarreraInicioCategoriaManager : GeneralManager<carrera_inicio_categoria>
    {

        public carrera_inicio_categoria GetById(int id)
        {
            return entityDAO.Find(e=>e.carrera_inicio_categoria_id==id);
        }
    }
}
