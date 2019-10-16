using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ptimera_wpf
{
    public class Proyecto

    {
        private string nombreProyecto;
        private string areaProyecto;
        private string actividadProyecto;
        private Double indiceCompletaion;
        private DateTime fechaInicio;
        private DateTime fechaFinalizacion;
        private double presupuesto;
        private string empresaSolicitadora;
        private Double pagoPorParteUpb;
        private double pagoPorParteEmpresa;
        private string descripcionProyecto;
        private string investigador;
        public string NombreProyecto
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

        public string AreaProyecto
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

        public string ActividadProyecto
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

        public double IndiceDeCompletición
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

        public double Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
               
                
            
        }
        public string EmpresaSolicitadora
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



        public double PagoPorParteUPB
        {
            get { return pagoPorParteUpb; }
            set
            {
               

                    pagoPorParteUpb = value;
                
            }
        }

        public double PagoPorParteEmpresa
        {
            get { return pagoPorParteEmpresa; }
            set
            {
                 
                pagoPorParteEmpresa = value;
                
            }
        }


        public string DescripciónProyecto
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

        public string Investigador
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

        public override string ToString()
        {
            return this.nombreProyecto;



        }
        
    }
}