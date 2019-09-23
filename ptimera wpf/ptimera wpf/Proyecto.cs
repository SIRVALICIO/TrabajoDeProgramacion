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
                actividadProyecto = value;
            }
        }

        public string IndiceDeCompletición
        {
            get { return indiceCompletaion; }
            set
            {
                indiceCompletaion = value;
            }
        }

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                fechaInicio = value;
            }
        }

        public string FechaFinalización
        {
            get { return fechaFinalizacion; }
            set
            {
                fechaFinalizacion = value;
            }
        }

        public string Presupuesto
        {
            get { return presupuesto; }
            set
            {
                presupuesto = value;
            }
        }

        public string EmpresaSolicitadora
        {
            get { return empresaSolicitadora; }
            set
            {
                empresaSolicitadora = value;
            }
        }

        public string PagoPorParteUPB
        {
            get { return pagoPorParteUpb; }
            set
            {
                pagoPorParteUpb = value;
            }
        }

        public string PagoPorParteEmpresa
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
                descripcionProyecto = value;
            }
        }

        public string Investigador
        {
            get { return investigador; }
            set
            {
                investigador = value;
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