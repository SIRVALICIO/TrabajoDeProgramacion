using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ptimera_wpf
{
    public class Proyecto

    {
        private String nombreProyecto;
        private String areaProyecto;
        private String actividadProyecto;
        private String indiceCompletaion;
        private DateTime fechaInicio;
        private DateTime fechaFinalizacion;
        private DateTime fechaModificacion;
        private long presupuesto;
        private String empresaSolicitadora;
        private long pagoPorParteUpb;
        private long pagoPorParteEmpresa;
        private String descripcionProyecto;
        private String investigador;



        public String NombreProyecto
        {
            get { return nombreProyecto; }
            set
            {
                if (value == null)
                    nombreProyecto = "";
                else
                    nombreProyecto = value;
            }
        }

        public String AreaProyecto
        {
            get
            {
                return areaProyecto;
            }
            set
            {
                if (value == null)
                    areaProyecto = "";
                else
                    areaProyecto = value;
            }
        }

        public String ActividadProyecto
        {
            get { return actividadProyecto; }
            set
            {
                if (value == null)
                    actividadProyecto = "";
                else
                    actividadProyecto = value;
            }
        }

        public String IndiceDeCompletición
        {
            get { return indiceCompletaion; }
            set
            {
                    indiceCompletaion = value;
            }
        }

        public DateTime FechaInicio
        {
            get {
                return fechaInicio;
            }
            set
            {

                    fechaInicio = value;
            }
        }

        public DateTime FechaFinalización
        {
            get { return fechaFinalizacion; }
            set
            {
                
                    fechaFinalizacion = value;
            }
        }


        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public long Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
               
                
            
        }
        public String EmpresaSolicitadora
        {
            get { return empresaSolicitadora; }
            set {
                if (value == null)
                {
                    empresaSolicitadora = "";
                }
                else
                {
                empresaSolicitadora = value;
                }
            }
        }



        public long PagoPorParteUPB
        {
            get { return pagoPorParteUpb; }
            set
            {
               

                    pagoPorParteUpb = value;
                
            }
        }

        public long PagoPorParteEmpresa
        {
            get { return pagoPorParteEmpresa; }
            set
            {
                 
                pagoPorParteEmpresa = value;
                
            }
        }


        public String DescripciónProyecto
        {
            get { return descripcionProyecto; }
            set
            {
                if (value==null) {
                    descripcionProyecto = "";
                }
                else { 
                descripcionProyecto = value;
               }
            }
        }

        public String Investigador
        {
            get { return investigador; }
            set
            {
                if (value==null)
                {
                    investigador = "";
                }
                else { 
                investigador = value;

                }
            }

        }

        public Login Login
        {
            get => default;
            set
            {
            }
        }

        public Login Login1
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        {
            return this.nombreProyecto;



        }
        
    }
}