//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMCTJ.BusinessEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class carrera
    {
        public carrera()
        {
            this.has_carrera = new HashSet<has_carrera>();
            this.tiempo = new HashSet<tiempo>();
            this.carrera_inicio_categoria = new HashSet<carrera_inicio_categoria>();
        }
    
        public int carrera_id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public System.DateTime fecha_carrera { get; set; }
        public System.DateTime tiempo_inicio_carrera { get; set; }
    
        public virtual ICollection<has_carrera> has_carrera { get; set; }
        public virtual ICollection<tiempo> tiempo { get; set; }
        public virtual ICollection<carrera_inicio_categoria> carrera_inicio_categoria { get; set; }
    }
}
