using CMCTJ.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Manager
{
    public class CarreraManager : GeneralManager<carrera>
    {

        public carrera GetCarreraActual()
        {
            return entityDAO.Find(e=>e.carrera_id==1);
        }
    }
}
