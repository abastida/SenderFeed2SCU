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
    
    public partial class tbl_RegistroSitio
    {
        public int id_RegistroSitio { get; set; }
        public Nullable<int> id_Sitio { get; set; }
        public string vchNombreCliente { get; set; }
        public string vchEmail { get; set; }
        public string vchNumeroContacto { get; set; }
        public string vchVendedor { get; set; }
        public string vchClaveActivacion { get; set; }
        public string vchpassword { get; set; }
        public Nullable<bool> bitActivo { get; set; }
    
        public virtual tbl_ConfigSitio tbl_ConfigSitio { get; set; }
    }
}
