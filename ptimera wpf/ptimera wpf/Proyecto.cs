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
        private string indiceCompletaion;
        private string fechaInicio;
        private string fechaFinalizacion;
        private string presupuesto;
        private string empresaSolicitadora;
        private string pagoPorParteUpb;
        private string pagoPorParteEmpresa;
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

        public string IndiceDeCompletición
        {
            get { return indiceCompletaion; }
            set
            {
                if (value == null)
                    indiceCompletaion = "";
                else
                    indiceCompletaion = value;
            }
        }

        public string FechaInicio
        {
            get {
                return fechaInicio;
            }
            set
            {
                if (value == null)
                    fechaInicio = "";
                else
                    fechaInicio = value;
            }
        }

        public string FechaFinalización
        {
            get { return fechaFinalizacion; }
            set
            {
                if (value == null)
                    fechaFinalizacion = "";
                else
                    fechaFinalizacion = value;
            }
        }

        public string Presupuesto
        {
            get { return presupuesto; }
            set { 
  
                if (value == null) {

                    presupuesto = "";
                } 
                else
                { presupuesto = value; }
               
                
            }
        }
        public string EmpresaSolicitadora
        {
            get { return empresaSolicitadora; }
            set {
                if (value == null)
                {
                    presupuesto = "";
                }
                else
                {
                empresaSolicitadora = value;
                }
            }
        }



        public string PagoPorParteUPB
        {
            get { return pagoPorParteUpb; }
            set
            {
                if (value == null) { pagoPorParteUpb = "0"; }

                else{

                    pagoPorParteUpb = value;
                }
            }
        }

        public string PagoPorParteEmpresa
        {
            get { return pagoPorParteEmpresa; }
            set
            {
                if (value == null) { pagoPorParteEmpresa = "0"; }

                else { 
                pagoPorParteEmpresa = value;
                }
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
        public void GuardarInfo()
        {

        }
    }
}