﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NAPOLEONEntities3 : DbContext
    {
        public NAPOLEONEntities3()
            : base("name=NAPOLEONEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_CAT_Estatus> tbl_CAT_Estatus { get; set; }
        public virtual DbSet<tbl_CAT_Extensiones> tbl_CAT_Extensiones { get; set; }
        public virtual DbSet<tbl_CAT_Feed2Version> tbl_CAT_Feed2Version { get; set; }
        public virtual DbSet<tbl_CAT_Modalidad> tbl_CAT_Modalidad { get; set; }
        public virtual DbSet<tbl_CAT_Proyecto> tbl_CAT_Proyecto { get; set; }
        public virtual DbSet<tbl_CAT_TipoUsuario> tbl_CAT_TipoUsuario { get; set; }
        public virtual DbSet<tbl_CAT_Usuarios> tbl_CAT_Usuarios { get; set; }
        public virtual DbSet<tbl_ConfigSitio> tbl_ConfigSitio { get; set; }
        public virtual DbSet<tbl_ConfigSitio_AUD> tbl_ConfigSitio_AUD { get; set; }
        public virtual DbSet<tbl_DET_Estudio> tbl_DET_Estudio { get; set; }
        public virtual DbSet<tbl_DET_Estudio_AUD> tbl_DET_Estudio_AUD { get; set; }
        public virtual DbSet<tbl_DET_ServicioSitio> tbl_DET_ServicioSitio { get; set; }
        public virtual DbSet<tbl_MST_Estudio> tbl_MST_Estudio { get; set; }
        public virtual DbSet<tbl_MST_PrioridadEstudio> tbl_MST_PrioridadEstudio { get; set; }
        public virtual DbSet<tbl_RegistroSitio> tbl_RegistroSitio { get; set; }
        public virtual DbSet<tbl_REL_ProyectoSitio> tbl_REL_ProyectoSitio { get; set; }
        public virtual DbSet<tbl_REL_SitioModalidad> tbl_REL_SitioModalidad { get; set; }
    
        public virtual ObjectResult<stp_getEstudio_Result> stp_getEstudio(Nullable<int> intEstatusID, Nullable<int> id_Sitio, Nullable<int> intModalidadID, Nullable<int> intProyectoID)
        {
            var intEstatusIDParameter = intEstatusID.HasValue ?
                new ObjectParameter("intEstatusID", intEstatusID) :
                new ObjectParameter("intEstatusID", typeof(int));
    
            var id_SitioParameter = id_Sitio.HasValue ?
                new ObjectParameter("id_Sitio", id_Sitio) :
                new ObjectParameter("id_Sitio", typeof(int));
    
            var intModalidadIDParameter = intModalidadID.HasValue ?
                new ObjectParameter("intModalidadID", intModalidadID) :
                new ObjectParameter("intModalidadID", typeof(int));
    
            var intProyectoIDParameter = intProyectoID.HasValue ?
                new ObjectParameter("intProyectoID", intProyectoID) :
                new ObjectParameter("intProyectoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_getEstudio_Result>("stp_getEstudio", intEstatusIDParameter, id_SitioParameter, intModalidadIDParameter, intProyectoIDParameter);
        }
    
        public virtual ObjectResult<stp_getEstudioMontebello_Result> stp_getEstudioMontebello(Nullable<int> id_Sitio, Nullable<int> intModalidadID, Nullable<System.DateTime> datInicio, Nullable<System.DateTime> datFinal)
        {
            var id_SitioParameter = id_Sitio.HasValue ?
                new ObjectParameter("id_Sitio", id_Sitio) :
                new ObjectParameter("id_Sitio", typeof(int));
    
            var intModalidadIDParameter = intModalidadID.HasValue ?
                new ObjectParameter("intModalidadID", intModalidadID) :
                new ObjectParameter("intModalidadID", typeof(int));
    
            var datInicioParameter = datInicio.HasValue ?
                new ObjectParameter("datInicio", datInicio) :
                new ObjectParameter("datInicio", typeof(System.DateTime));
    
            var datFinalParameter = datFinal.HasValue ?
                new ObjectParameter("datFinal", datFinal) :
                new ObjectParameter("datFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_getEstudioMontebello_Result>("stp_getEstudioMontebello", id_SitioParameter, intModalidadIDParameter, datInicioParameter, datFinalParameter);
        }
    
        public virtual ObjectResult<stp_getEstudioPDF_Result> stp_getEstudioPDF(Nullable<int> intEstudioID)
        {
            var intEstudioIDParameter = intEstudioID.HasValue ?
                new ObjectParameter("intEstudioID", intEstudioID) :
                new ObjectParameter("intEstudioID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_getEstudioPDF_Result>("stp_getEstudioPDF", intEstudioIDParameter);
        }
    
        public virtual ObjectResult<stp_getEstudiosEnviar_Result> stp_getEstudiosEnviar(Nullable<int> id_Sitio)
        {
            var id_SitioParameter = id_Sitio.HasValue ?
                new ObjectParameter("id_Sitio", id_Sitio) :
                new ObjectParameter("id_Sitio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_getEstudiosEnviar_Result>("stp_getEstudiosEnviar", id_SitioParameter);
        }
    
        public virtual ObjectResult<stp_getEstudiosEnviarVNA_Result> stp_getEstudiosEnviarVNA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_getEstudiosEnviarVNA_Result>("stp_getEstudiosEnviarVNA");
        }
    
        public virtual ObjectResult<stp_getPrioridadSucursalModalidad_Result> stp_getPrioridadSucursalModalidad(Nullable<int> id_sitio, Nullable<int> intProyecto)
        {
            var id_sitioParameter = id_sitio.HasValue ?
                new ObjectParameter("id_sitio", id_sitio) :
                new ObjectParameter("id_sitio", typeof(int));
    
            var intProyectoParameter = intProyecto.HasValue ?
                new ObjectParameter("intProyecto", intProyecto) :
                new ObjectParameter("intProyecto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_getPrioridadSucursalModalidad_Result>("stp_getPrioridadSucursalModalidad", id_sitioParameter, intProyectoParameter);
        }
    
        public virtual ObjectResult<string> stp_getPromedioEnvio(Nullable<System.DateTime> fIni, Nullable<System.DateTime> fFin, Nullable<int> sucOID, Nullable<int> intProyectoID)
        {
            var fIniParameter = fIni.HasValue ?
                new ObjectParameter("fIni", fIni) :
                new ObjectParameter("fIni", typeof(System.DateTime));
    
            var fFinParameter = fFin.HasValue ?
                new ObjectParameter("fFin", fFin) :
                new ObjectParameter("fFin", typeof(System.DateTime));
    
            var sucOIDParameter = sucOID.HasValue ?
                new ObjectParameter("sucOID", sucOID) :
                new ObjectParameter("sucOID", typeof(int));
    
            var intProyectoIDParameter = intProyectoID.HasValue ?
                new ObjectParameter("intProyectoID", intProyectoID) :
                new ObjectParameter("intProyectoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("stp_getPromedioEnvio", fIniParameter, fFinParameter, sucOIDParameter, intProyectoIDParameter);
        }
    
        public virtual int stp_setPrioridades(Nullable<int> idEstudio, Nullable<int> intDireccion, Nullable<int> intSecuenciaActual)
        {
            var idEstudioParameter = idEstudio.HasValue ?
                new ObjectParameter("idEstudio", idEstudio) :
                new ObjectParameter("idEstudio", typeof(int));
    
            var intDireccionParameter = intDireccion.HasValue ?
                new ObjectParameter("intDireccion", intDireccion) :
                new ObjectParameter("intDireccion", typeof(int));
    
            var intSecuenciaActualParameter = intSecuenciaActual.HasValue ?
                new ObjectParameter("intSecuenciaActual", intSecuenciaActual) :
                new ObjectParameter("intSecuenciaActual", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_setPrioridades", idEstudioParameter, intDireccionParameter, intSecuenciaActualParameter);
        }
    
        public virtual int stp_setPrioridadesSucMod(Nullable<int> intREL_SitioModID, Nullable<bool> activar)
        {
            var intREL_SitioModIDParameter = intREL_SitioModID.HasValue ?
                new ObjectParameter("intREL_SitioModID", intREL_SitioModID) :
                new ObjectParameter("intREL_SitioModID", typeof(int));
    
            var activarParameter = activar.HasValue ?
                new ObjectParameter("Activar", activar) :
                new ObjectParameter("Activar", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_setPrioridadesSucMod", intREL_SitioModIDParameter, activarParameter);
        }
    
        public virtual int stp_setPrioridadesSucModAcomodar(Nullable<int> intREL_SitioModID, Nullable<int> intDireccion, Nullable<int> intSecuenciaActual)
        {
            var intREL_SitioModIDParameter = intREL_SitioModID.HasValue ?
                new ObjectParameter("intREL_SitioModID", intREL_SitioModID) :
                new ObjectParameter("intREL_SitioModID", typeof(int));
    
            var intDireccionParameter = intDireccion.HasValue ?
                new ObjectParameter("intDireccion", intDireccion) :
                new ObjectParameter("intDireccion", typeof(int));
    
            var intSecuenciaActualParameter = intSecuenciaActual.HasValue ?
                new ObjectParameter("intSecuenciaActual", intSecuenciaActual) :
                new ObjectParameter("intSecuenciaActual", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_setPrioridadesSucModAcomodar", intREL_SitioModIDParameter, intDireccionParameter, intSecuenciaActualParameter);
        }
    
        public virtual int stp_updatePrioridadesSucMod(Nullable<int> intREL_SitioModID, Nullable<bool> activar)
        {
            var intREL_SitioModIDParameter = intREL_SitioModID.HasValue ?
                new ObjectParameter("intREL_SitioModID", intREL_SitioModID) :
                new ObjectParameter("intREL_SitioModID", typeof(int));
    
            var activarParameter = activar.HasValue ?
                new ObjectParameter("Activar", activar) :
                new ObjectParameter("Activar", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_updatePrioridadesSucMod", intREL_SitioModIDParameter, activarParameter);
        }
    }
}