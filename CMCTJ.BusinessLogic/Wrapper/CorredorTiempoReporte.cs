using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Wrapper
{
    public class CorredorTiempoReporte
    {
        public int TiempoId { get; set; }
        public int Vuelta { get; set; }
        public String Nombre { get; set; }
        public int Numero { get; set; }
        public String Tiempo { get; set; }
        public string TiempoRegistrado { get; set; }
        public String Categoria { get; set; }
    }
}
