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
    
    public partial class tbl_CAT_Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CAT_Proyecto()
        {
            this.tbl_CAT_Usuarios = new HashSet<tbl_CAT_Usuarios>();
            this.tbl_REL_ProyectoSitio = new HashSet<tbl_REL_ProyectoSitio>();
        }
    
        public int intProyectoID { get; set; }
        public string vchProyectoDesc { get; set; }
        public Nullable<bool> bitActivo { get; set; }
        public Nullable<System.DateTime> datFecha { get; set; }
        public string vchUserAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CAT_Usuarios> tbl_CAT_Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_REL_ProyectoSitio> tbl_REL_ProyectoSitio { get; set; }
    }
}
