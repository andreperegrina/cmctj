using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Wrapper
{
    public class TiempoWrapper
    {
        public int TiempoId { get; set; }
        public int Vuelta { get; set; }
        public String Nombre { get; set; }
        public TimeSpan Tiempo { get; set; }
        public DateTime TiempoRegistrado { get; set; }
        public String Categoria { get; set; }
    }
}
