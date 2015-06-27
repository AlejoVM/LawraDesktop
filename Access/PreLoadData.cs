using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Data;

using Options;
using Newtonsoft.Json;
using RestSharp;
using Objects.Tables;

namespace Access
{
    public class PreLoadData : Connection
    {
        private string _ubigeoController = "api/ubigeo";
        private string _tipoDocController = "api/tipodocumento";
        private string _tipoParentController = "api/typeparents";

        private string _exceptionUbigeo;

        public string ExceptionUbigeo
        {
            get { return this._exceptionUbigeo; }
        }

        public DataSet ListUbigeo( DataSet dts )
        {
            Query query = new Query( this._ubigeoController );

            try
            {
                query.SendRequestGET();

                dts.Tables["Departamentos"].Clear();
                dts.Tables["Provincias"].Clear();
                dts.Tables["Distritos"].Clear();

                if( query.ResponseStatusCode != HttpStatusCode.OK )
                {
                    throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Ubigeo" );
                }

                List<Departamentos> departamentos = JsonConvert.DeserializeObject<List<Departamentos>>( query.ResponseContent );

                int countProv = 1, countDist = 1;

                foreach ( Departamentos depItem in departamentos )
                {
                    string[] camposdep = new string[2] { depItem.Id.ToString(), depItem.Departamento};
                    dts.Tables["Departamentos"].Rows.Add(camposdep);

                    foreach ( Provincias proItem in depItem.Provincias )
                    {
                        string[] campospro = new string[4] { countProv.ToString(), camposdep[0], proItem.Id.ToString(), proItem.Provincia };
                        dts.Tables["Provincias"].Rows.Add( campospro );

                        foreach ( Distritos disItem in proItem.Distritos )
                        {
                            string[] camposdis = new string[4] { countDist.ToString(), campospro[0], disItem.Id.ToString(), disItem.Distrito };
                            dts.Tables["Distritos"].Rows.Add( camposdis );
                            countDist++;
                        }

                        countProv++;
                    }
                }

                return dts;

            }catch(Exception e)
            {
                this._exceptionUbigeo = e.Message;
                return null;
            }
        }

        public DataSet ListTipoDocumento( DataSet dts )
        {
            Query query = new Query( this._tipoDocController );

            try
            {
                query.SendRequestGET();

                dts.Tables["tipodocumento"].Clear();

                if ( query.ResponseStatusCode != HttpStatusCode.OK )
                {
                    throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
                }

                List<TipoDocumento> tipo = JsonConvert.DeserializeObject<List<TipoDocumento>>( query.ResponseContent );

                foreach ( TipoDocumento Item in tipo )
                {
                    object[] td = new object[6] 
                    { 
                        Item.Id, 
                        Item.LongName, 
                        Item.ShortName, 
                        Item.Length, 
                        Item.IsNumeric, 
                        Item.IsExactLength 
                    };

                    dts.Tables["tipodocumento"].Rows.Add( td );
                }

                return dts;

            }
            catch ( Exception e )
            {
                this._exceptionUbigeo = e.Message;
                return null;
            }
        }

        public DataSet ListTipoApoderado(DataSet dts) 
        {
            Query query = new Query(this._tipoParentController);

            try
            {
                query.SendRequestGET();

                dts.Tables["tipoapoderado"].Clear();

                if (query.ResponseStatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentNullException("No se ha podido acceder a los datos", "Datos de Tipo de Documentos");
                }

                List<TypeParent> tipo = JsonConvert.DeserializeObject<List<TypeParent>>(query.ResponseContent);

                foreach (TypeParent Item in tipo)
                {
                    object[] td = new object[3] 
                    { 
                        Item.Id, 
                        Item.Name,
                        Item.type
                    };

                    dts.Tables["tipoapoderado"].Rows.Add(td);
                }

                return dts;

            }
            catch (Exception e)
            {
                this._exceptionUbigeo = e.Message;
                return null;
            }
        }
    }
}
