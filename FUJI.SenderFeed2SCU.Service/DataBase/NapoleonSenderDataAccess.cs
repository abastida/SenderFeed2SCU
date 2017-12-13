using FUJI.SenderFeed2SCU.Service.Extensions;
using FUJI.SenderFeed2SCU.Service.Feed2Service;
using System;
using System.Collections.Generic;
using System.Linq;
//using FUJI.SenderFeed2SCU.Service.DataBase;

namespace FUJI.SenderFeed2SCU.Service.DataBase
{
    public class NapoleonSenderDataAccess
    {
        //public static NAPOLEONEntities NapoleonDA;
        public static NapoleonServiceClient NapoleonDA = new NapoleonServiceClient();

        //DataBase

        public List<ClienteF2CResponseVNA> getEstudiosEnviar()
        {
            List<ClienteF2CResponseVNA> lstReturn = new List<ClienteF2CResponseVNA>();
            //ClienteF2CResponseVNA response = new ClienteF2CResponseVNA();
            try
            {
                ClienteF2CRequest request = new ClienteF2CRequest();              

                try
                {
                    using (DataBase.NAPOLEONEntities3 dbNap = new DataBase.NAPOLEONEntities3())
                    {                       
                        var query = dbNap.stp_getEstudiosEnviarVNA().ToList();
                        if (query != null)
                        {
                            if (query.Count > 0)
                            {
                                foreach (var item in query)
                                {
                                    ClienteF2CResponseVNA mdl = new ClienteF2CResponseVNA();
                                    mdl.intEstudioID = (int)item.intEstudioID;
                                    mdl.id_Sitio = (int)item.id_Sitio;
                                    mdl.vchAETitle = item.vchAETitle;
                                    mdl.vchPathServidor = item.vchPathFile;                                                                     
                                    lstReturn.Add(mdl);
                                }
                            }
                        }                    
                    }
                }
                catch (Exception eSU)
                {
                    //valido = false;
                    //mensaje = eSU.Message;
                    Log.EscribeLog("Existe un error en getEstudiosEnviar: " + eSU.Message);
                }
               
               // Log.EscribeLog("Archivos a enviar: " + response.lstReturn.Count().ToString());
            }
            catch (Exception e)
            {
                //response.message = e.Message;
                //response.valido = false;
                Log.EscribeLog("Existe un error en getEstudiosEnviar: " + e.Message);
            }
            return lstReturn;
        }

        public bool updateEstatus(int intDetEstudioID)
        {
            bool bandera_Actualizar = false;
            try
            {
                using (DataBase.NAPOLEONEntities3 dbNap = new DataBase.NAPOLEONEntities3())
                {
                    var db_estudio = dbNap.tbl_DET_Estudio
                        .Where(w => w.intEstudioID == intDetEstudioID)
                        .ToList();

                    if (db_estudio != null)
                    {
                        foreach (var x in db_estudio)
                        {
                            try
                            {
                                x.intEstatusID = 3;
                                dbNap.SaveChanges();
                                bandera_Actualizar = true;
                                Log.EscribeLog("Se actualizo con exito estudio " + x.intEstudioID + "y Detalle estudio " + x.intDetEstudioID);
                            }

                            catch(Exception ex)
                            {
                                Log.EscribeLog("Existe un error en updateEstatus: " + ex.Message);
                            }
                        }                                                                    
                    }                                             
                }
            }
            catch (Exception eLT)
            {
                Log.EscribeLog("Existe un error en getModalidadAgenda: " + eLT.Message, 3, user);
            }
            return bandera_Actualizar;
            //ClienteF2CResponse response = new ClienteF2CResponse();
            //try
            //{
            //    ClienteF2CRequest request = new ClienteF2CRequest();
            //    request.intDetEstudioID = intDetEstudioID;
            //    //request.intDetEstudioIDSpecified = true;
            //    request.Token = Security.Encrypt(id_Sitio + "|" + vchClaveSitio);
            //    request.id_Sitio = id_Sitio;
            //    //request.id_SitioSpecified = true;
            //    request.vchClaveSitio = vchClaveSitio;
            //    response = NapoleonDA.updateEstatus(request);
            //}
            //catch (Exception eup)
            //{
            //    Log.EscribeLog("Existe un error en updateEstatus:" + eup.Message);
            //}
            //return response;
        }


        //public ClienteF2CResponse updateEstatus(int intDetEstudioID, int id_Sitio, string vchClaveSitio)
        //{
        //    ClienteF2CResponse response = new ClienteF2CResponse();
        //    try
        //    {
        //        ClienteF2CRequest request = new ClienteF2CRequest();
        //        request.intDetEstudioID = intDetEstudioID;
        //        //request.intDetEstudioIDSpecified = true;
        //        request.Token = Security.Encrypt(id_Sitio + "|" + vchClaveSitio);
        //        request.id_Sitio = id_Sitio;
        //        //request.id_SitioSpecified = true;
        //        request.vchClaveSitio = vchClaveSitio;
        //        response = NapoleonDA.updateEstatus(request);
        //    }
        //    catch (Exception eup)
        //    {
        //        Log.EscribeLog("Existe un error en updateEstatus:" + eup.Message);
        //    }
        //    return response;
        //}

        public static void setService(int id_Servicio, string vchClaveSitio)
        {
            try
            {
                ClienteF2CRequest request = new ClienteF2CRequest();
                request.id_Sitio = id_Servicio;
                //request.id_SitioSpecified = true;
                request.vchClaveSitio = vchClaveSitio;
                request.Token = Security.Encrypt(id_Servicio + "|" + vchClaveSitio);
                request.tipoServicio = 4;
                //request.tipoServicioSpecified = true;
                NapoleonDA.setService(request);
            }
            catch (Exception eSS)
            {
                Log.EscribeLog("Existe un error en setService: " + eSS.Message);
                //throw eSS;
            }
        }
    }
}
