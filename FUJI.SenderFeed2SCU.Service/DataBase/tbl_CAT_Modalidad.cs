//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FUJI.SenderFeed2SCU.Service.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_CAT_Modalidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CAT_Modalidad()
        {
            this.tbl_MST_Estudio = new HashSet<tbl_MST_Estudio>();
            this.tbl_REL_SitioModalidad = new HashSet<tbl_REL_SitioModalidad>();
        }
    
        public int intModalidadID { get; set; }
        public string vchModalidadClave { get; set; }
        public string vchModalidadDesc { get; set; }
        public Nullable<System.DateTime> datFecha { get; set; }
        public Nullable<bool> bitActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MST_Estudio> tbl_MST_Estudio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_REL_SitioModalidad> tbl_REL_SitioModalidad { get; set; }
    }
}
