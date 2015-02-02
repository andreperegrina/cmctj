using CMCTJ.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Manager
{
    public class CorredorManager : GeneralManager<corredor>
    {
        public corredor GetCorredorById(int corredorID)
        {
            return entityDAO.Find(e=>e.corredor_id==corredorID);
        }
    }
}
