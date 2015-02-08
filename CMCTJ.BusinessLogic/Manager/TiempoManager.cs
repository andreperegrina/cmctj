using CMCTJ.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Manager
{
    public class TiempoManager : GeneralManager<tiempo>
    {
        public int RegistrarTiempo(corredor corredorRegistrar,int carreraID)
        {
            tiempo nuevoTiempo = new tiempo() { 
                carrera_id = carreraID, 
                corredor_id = corredorRegistrar.corredor_id, 
                categoria_id = corredorRegistrar.categoria_id, 
                vuelta=0,
                tiempo_diferencia=DateTime.Now.TimeOfDay,
                tiempo_corredor = DateTime.Now };
            return entityDAO.Save(nuevoTiempo);
        }


        public tiempo GetTiempoById(int corredorID)
        {
            return entityDAO.Find(e => e.tiempo_id == corredorID);
        }
    }
}
