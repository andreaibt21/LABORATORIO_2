using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades

{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanoMb;
      
        #region CONSTRUCTOR
        /// <summary>
        /// Constructor de la i
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="tamanoMb"></param>
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanoMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanoMb = tamanoMb;
        }
        #endregion
     
        #region PROPIEDADES


        /// <summary>
        /// Retorna el tipo de sistema Operativo 
        /// </summary>
        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
          
        }

        /// <summary>
        /// firma de la propiedad Tamano
        /// </summary>
        protected virtual int TamanoMb { get; }

        #endregion


        #region METODOS

        /// <summary>
        /// El metodo recibirá una lista de aplicaciones y devolverá la instancia de la aplicación que más tamaño tenga.
        /// </summary>
        /// <param name="listApp"></param>
        public static implicit operator Aplicacion( List<Aplicacion> listApp)
        {
            Aplicacion appMasGrande = null;
            if (listApp is not null)
            {
                foreach (Aplicacion app in listApp)
                {
                    if (appMasGrande == null ||  app.tamanoMb > appMasGrande.tamanoMb)
                    {                      
                        appMasGrande = app;  
                    }
                }
            }
            return appMasGrande;

        }
     
        
        /// <summary>
        /// El método ObtenerInformacionApp retornará los datos de la aplicación utilizando StringBuilder.
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Sistema Operativa: {this.SistemaOperativo} ");
            sb.AppendLine($"Tamano de Mb: {this.TamanoMb} ");
            
            return sb.ToString();
        }

        /// <summary>
        /// La sobrecarga del operador == buscará si una aplicación existe en la lista recibida
        /// por parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listApp">Lista de aplicaciones</param>
        /// <param name="app"> aplicacion de referencia</param>
        /// <returns> Devolverá true si ya existe.</returns>
        public static bool operator ==(List<Aplicacion> listApp, Aplicacion app)
        {
            if ( listApp is not null && app is not null )
            {
                foreach (Aplicacion item in listApp)
                {
                    if (item.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            return false;   
              
        }


        /// <summary>
        /// La sobrecarga del operador != buscará si una aplicación existe en la lista recibida
        /// por parámetro comparando por su nombre. 
        /// </summary>
        /// <param name="listApp">Lista de aplicaciones</param>
        /// <param name="app"> aplicacion de referencia</param>
        /// <returns> Devolverá false si ya existe.</returns>
        public static bool operator !=(List<Aplicacion> listApp, Aplicacion app)
        {
            return !(listApp == app);
        }
        /// <summary>
        /// La sobrecarga del operador + añadirá una aplicación a la lista de aplicaciones pasada por 
        /// parámetro siempre y cuando sea no exista previamente. Reutilizar código.
        /// </summary>
        /// <param name="listApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator +(List<Aplicacion> listApp, Aplicacion app)
        {
                if( listApp != app)
            {
                 listApp.Add(app);
                return true;

            }
            return false;
        }

        /// <summary>
        /// El método ToString devolverá el nombre de la aplicación.
        /// </summary>
        /// <returns> retorna el nombre de la app</returns>
        public override string ToString()
        {
            return this.nombre;
        }


        #endregion

    }
}
