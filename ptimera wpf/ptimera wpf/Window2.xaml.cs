using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ptimera_wpf
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private List<Proyecto> proyectos;
        public static Regex RegexValores = new Regex("^\\D");
        public static Regex Desripcion = new Regex("^\\w*$");

        public static Regex RegexLetras = new Regex(" ^[a - zA - Z\\s] * $");
        public static Regex negativo = new Regex("^[-]*$");
        public static Regex RegexPorcentaje = new Regex("^[%]*$");

        public Window2()
        {
            InitializeComponent();
            
            string read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Proyectos.txt");
            if (read.Equals("")) { proyectos=new List<Proyecto>(); }
            else
            {
                proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(read);
            }
            initializeVariables();
        }
        private void initializeVariables()
        {

            fillComboBoxes();
            fillComboBoxesOrden();
            #region
            string read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Proyectos.txt");

            if (read == null || read == "")
            {
                proyectos = new List<Proyecto>();
              

            }
            else

                #endregion
                ListBox_Archivos.ItemsSource = proyectos;

            TextBox_Peresupuesto3ros.Text = "0";
            TextBox_presupuestoEmpresa.Text = "0";


        }

        private void TextBox_titulo_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBox_titulo.Text))
            {
                MessageBox.Show("El campo está vacío, por favor, llénelo");

            }
            else if (RegexLetras.IsMatch(TextBox_titulo.Text))
            {
                MessageBox.Show("El nombre del proyecto debe de estar en caracteres alfabéticos, por favor, corriga el campo");

            }
        }



        private void TextBox_investigador_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBox_investigador.Text))
            {
                MessageBox.Show("El campo está vacío, por favor, llénelo");

            }
            else if (RegexLetras.IsMatch(TextBox_investigador.Text))
            {
                MessageBox.Show("El nombre de usuario solo puede contener letras y espacios, por favor, vuelva a llenar el campo");

            }

        }

        private void TextBox_area_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBox_area.Text))
            {
                MessageBox.Show("El campo está vacío, por favor llénelo");

            } else if (RegexLetras.IsMatch(TextBox_area.Text))
            {
                MessageBox.Show("El area del proyecto debe estar completo, por favor corríjalo");

            }
        }



        private void TexBox_Porcentaje_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TexBox_Porcentaje.Text))
            {
                MessageBox.Show("El campo esta vacio");
            }
            else if (RegexValores.IsMatch(TexBox_Porcentaje.Text) || negativo.IsMatch(TexBox_Porcentaje.Text))
            {
                MessageBox.Show("El valor debe ser porcentual, por lo cual, no puede ser negativo");
            }
            else if (!RegexPorcentaje.IsMatch(TexBox_Porcentaje.Text)) { 
            {
                TexBox_Porcentaje.Text = TexBox_Porcentaje.Text + "%";
            }
            }
        }

        private void TextBox_Empresa_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!Desripcion.IsMatch(TextBox_Empresa.Text)) {
                MessageBox.Show("El nombre no tiene caracteres válidos para ser considerado como un nombre de empresa");

            }
            else if (string.IsNullOrEmpty(TextBox_Empresa.Text))
            {
                TextBox_Empresa.Text = "aún por determinar";

            }
        }



        private void TextBox_presupuestoEmpresa_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(TextBox_presupuestoEmpresa.Text))
            {
                TextBox_presupuestoEmpresa.Text = "0";
            }
            else if (RegexValores.IsMatch(TextBox_presupuestoEmpresa.Text) || negativo.IsMatch(TextBox_presupuestoEmpresa.Text))
            {
                MessageBox.Show("EL presupuesto solo puede ser de caracter numérico positivo");
            }
        }
    

        private void TextBox_Peresupuesto3ros_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Peresupuesto3ros.Text))
            {
                TextBox_Peresupuesto3ros.Text = "0";
            }
            else if (RegexValores.IsMatch(TextBox_Peresupuesto3ros.Text) || negativo.IsMatch(TextBox_Peresupuesto3ros.Text))
            {
                MessageBox.Show("EL presupuesto solo puede ser de carácter numerico positivo");
            }
            /*
            double PreEmpresas = Convert.ToDouble(TextBox_presupuestoEmpresa.Text);
            double Pre3ros = Convert.ToDouble(TextBox_Peresupuesto3ros.Text);
            double total = Pre3ros + PreEmpresas;
            TextBox_Presupuesto.Text = total.ToString();
            */
        }

        private void TextBox_actividades_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_actividades.Text)){
                TextBox_actividades.Text = "Actividades aún por definir";
            }
            else if (!Desripcion.IsMatch(TextBox_actividades.Text))
            {
                MessageBox.Show("Los caracteres ingresados no son validos, Vuélvalos a llenar");
            }
            /*
            double PreEmpresas = Convert.ToDouble(TextBox_presupuestoEmpresa.Text);
            double Pre3ros = Convert.ToDouble(TextBox_Peresupuesto3ros.Text);
            double total= Pre3ros + PreEmpresas;
            TextBox_Presupuesto.Text = total.ToString();
            */
        }

        private void TextBox_descripcion_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_descripcion.Text))
            {
                MessageBox.Show("Deben definirse actividades antes de proceder");
            }

            else if (!Desripcion.IsMatch(TextBox_descripcion.Text))
            {
                MessageBox.Show("Los caracteres ingresados no son validos, Por favor, llénelos");
            }
        }
        private void guardarEmpleados()
        {

           
            string save = JsonConvert.SerializeObject(proyectos);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Proyectos.txt",save);


        }


        private void fillListBox()
        {
            ListBox_Archivos.ItemsSource = null;
            ListBox_Archivos.ItemsSource = proyectos;
            
        }
        private void fillComboBoxes()
        {
          
            List<string> modes = new List<string>();
            modes.Add("Consulta");
            modes.Add("Editar");
            modes.Add("Agregar");
            modes.Add("Eliminar");
            ComboBox_Elecciones.Items.Clear();
            for (int i = 0; i < modes.Count; i++)
            {
                ComboBox_Elecciones.Items.Add(modes[i].ToString());
            }
            ComboBox_Elecciones.SelectedIndex = 0;
        }
        


        private void modoConsulta()
        {
            #region
           // string read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Proyectos.txt");
            //proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(read);
            #endregion
            TextBox_titulo.IsReadOnly = true;
            TextBox_titulo.IsEnabled = false;
            TextBox_investigador.IsReadOnly = true;
            TextBox_investigador.IsEnabled = false;
            TextBox_area.IsReadOnly = true;
            TextBox_area.IsEnabled = false;
            DatePicker_inicio.IsEnabled = false;
            DatePicker_entrega.IsEnabled = false;
            TexBox_Porcentaje.IsReadOnly= true;
            TexBox_Porcentaje.IsEnabled = false;
            ListBox_Archivos.IsEnabled= true;
            TextBox_Empresa.IsReadOnly = true;
            TextBox_Empresa.IsEnabled = false;
            TextBox_Presupuesto.IsReadOnly = true;
            TextBox_Presupuesto.IsEnabled = false;
            TextBox_presupuestoEmpresa.IsReadOnly= true;
            TextBox_presupuestoEmpresa.IsEnabled = false;
            TextBox_Peresupuesto3ros.IsReadOnly = true;
            TextBox_Peresupuesto3ros.IsEnabled = false;
            TextBox_descripcion.IsReadOnly = true;
            TextBox_descripcion.IsEnabled = false;
            TextBox_actividades.IsReadOnly = true;
            TextBox_actividades.IsEnabled = false;
            DatePickerModificacion.IsEnabled = false;
            ButtonCambio.Content = "nada";



            
            ButtonCambio.Visibility = Visibility.Hidden;
        }
        private void modoEditar()
        {
            #region
            //string read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Proyectos.txt");
            //proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(read);
            #endregion
            TextBox_titulo.IsReadOnly = false;
            TextBox_investigador.IsReadOnly = false;
            TextBox_area.IsReadOnly = false;
            DatePicker_inicio.IsEnabled = true;
            DatePicker_entrega.IsEnabled =true ;
            TexBox_Porcentaje.IsReadOnly = false;
            ListBox_Archivos.IsEnabled = true;
            TextBox_Empresa.IsReadOnly = false;
            TextBox_Presupuesto.IsReadOnly = true;
            TextBox_presupuestoEmpresa.IsReadOnly = false;
            TextBox_Peresupuesto3ros.IsReadOnly = false;
            TextBox_descripcion.IsReadOnly = false;
            TextBox_actividades.IsReadOnly = false;
            
            
            ButtonCambio.Content = "Sobre-Escribir";
            ButtonCambio.Visibility = Visibility.Visible;
            ButtonCambio.IsEnabled = true;


        }
        private void modoAgregar()
        {
            #region
            //string read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Proyectos.txt");
            //proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(read);
            #endregion
            TextBox_titulo.IsReadOnly = false;
            TextBox_titulo.IsEnabled = true;
            TextBox_investigador.IsReadOnly = false;
            TextBox_investigador.IsEnabled = true;
            TextBox_area.IsReadOnly = false;
            TextBox_area.IsEnabled = true;
            DatePicker_inicio.IsEnabled = true;
            DatePicker_entrega.IsEnabled = true;
            TexBox_Porcentaje.IsReadOnly = false;
            TexBox_Porcentaje.IsEnabled = true;
            ListBox_Archivos.IsEnabled = true;
            TextBox_Empresa.IsReadOnly = false;
            TextBox_Empresa.IsEnabled = true;
            TextBox_Presupuesto.IsReadOnly = true;
            TextBox_Presupuesto.IsEnabled = false;
            TextBox_presupuestoEmpresa.IsEnabled = true;
            TextBox_presupuestoEmpresa.IsReadOnly = false;
            TextBox_Peresupuesto3ros.IsReadOnly = false;
            TextBox_Peresupuesto3ros.IsEnabled = true; ;
            TextBox_descripcion.IsReadOnly = false;
            TextBox_descripcion.IsEnabled = true;
            TextBox_actividades.IsReadOnly = false;
            TextBox_actividades.IsEnabled = true;
            ButtonCambio.Content = "Guardar";
            ButtonCambio.Visibility = Visibility.Visible;
            ButtonCambio.IsEnabled = true;
            


            limpiar();
            

        }
        private void modoEliminar()
        {
            TextBox_titulo.IsReadOnly = true;
            TextBox_titulo.IsEnabled = false;
            TextBox_investigador.IsReadOnly = true;
            TextBox_investigador.IsEnabled = false;
            TextBox_area.IsReadOnly = true;
            TextBox_area.IsEnabled = false;
            DatePicker_inicio.IsEnabled= false;
            DatePicker_entrega.IsEnabled = false;
            TexBox_Porcentaje.IsReadOnly = true;
            TexBox_Porcentaje.IsEnabled = false;
            ListBox_Archivos.IsEnabled = true;
            TextBox_Empresa.IsReadOnly = true;
            TextBox_Empresa.IsEnabled = false;
            TextBox_Presupuesto.IsReadOnly = true;
            TextBox_Presupuesto.IsEnabled = false;
            TextBox_presupuestoEmpresa.IsReadOnly = true;
            TextBox_presupuestoEmpresa.IsEnabled = false;
            TextBox_Peresupuesto3ros.IsReadOnly = true;
            TextBox_Peresupuesto3ros.IsEnabled = false;
            TextBox_descripcion.IsReadOnly = true;
            TextBox_descripcion.IsEnabled = false;
            TextBox_actividades.IsReadOnly = true;
            TextBox_actividades.IsEnabled = false;
       
            ButtonCambio.Content= "Eliminar";
            ButtonCambio.Visibility = Visibility.Visible;
            ButtonCambio.IsEnabled = true;

        }
        private void limpiar()
        {

            TextBox_titulo.Text = "";
            TextBox_investigador.Text = "";
            TextBox_area.Text = "";
            DatePicker_inicio.Text = "";
            DatePicker_entrega.Text = "";
            TexBox_Porcentaje.Text = "";
            TextBox_Empresa.Text = "";
            TextBox_Presupuesto.Text = "";
            TextBox_presupuestoEmpresa.Text = "";
            TextBox_Peresupuesto3ros.Text = "";
            TextBox_descripcion.Text = "";
            TextBox_actividades.Text = "";
            DatePickerModificacion.Text = "";
        }



        private void fillComboBoxesOrden()
        {

            List<string> modes = new List<string>();
            modes.Add("Area");
            modes.Add("Nombre");
            modes.Add("Mayor presupuesto");
            modes.Add("Menor presupuesto");
            
            modes.Add("Más reciente");
            modes.Add("Más antiguo");
            modes.Add("Modificado REcientemente");

            ComboBoxesOrden.Items.Clear();
            for (int i = 0; i < modes.Count; i++)
            {
                ComboBoxesOrden.Items.Add(modes[i].ToString());
            }
            ComboBoxesOrden.SelectedIndex = 0;
        }





       
        private void cargarEmpleadoSeleccionado()
        {


            limpiar();

           

            if (ListBox_Archivos.SelectedIndex > -1  && !ButtonCambio.Content.Equals("Guardar")) { 
            Proyecto proyectoTemporal = proyectos.ElementAt(ListBox_Archivos.SelectedIndex);
            TextBox_titulo.Text = proyectoTemporal.NombreProyecto.ToString();
            TextBox_investigador.Text = proyectoTemporal.Investigador.ToString();
            TextBox_area.Text = proyectoTemporal.AreaProyecto.ToString();
            DatePicker_inicio.Text =proyectoTemporal.FechaInicio.ToString();
            DatePicker_entrega.Text = proyectoTemporal.FechaFinalización.ToString();
            TexBox_Porcentaje.Text = proyectoTemporal.IndiceDeCompletición.ToString();
            TextBox_Empresa.Text = proyectoTemporal.EmpresaSolicitadora.ToString();
            TextBox_Presupuesto.Text = proyectoTemporal.Presupuesto.ToString();
            TextBox_presupuestoEmpresa.Text = proyectoTemporal.PagoPorParteEmpresa.ToString();
            TextBox_Peresupuesto3ros.Text = proyectoTemporal.PagoPorParteUPB.ToString();
            TextBox_descripcion.Text = proyectoTemporal.DescripciónProyecto.ToString();
            TextBox_actividades.Text = proyectoTemporal.ActividadProyecto.ToString();
            DatePickerModificacion.Text = proyectoTemporal.FechaModificacion.ToString();

            }
        

        }

        private void True(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void ButtonCambio_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_titulo.Text) || string.IsNullOrWhiteSpace(TextBox_investigador.Text) || string.IsNullOrWhiteSpace(TextBox_area.Text) || string.IsNullOrEmpty(TexBox_Porcentaje.Text) || string.IsNullOrEmpty(TextBox_Empresa.Text)|| string.IsNullOrEmpty(TextBox_presupuestoEmpresa.Text)|| string.IsNullOrEmpty(TextBox_Peresupuesto3ros.Text)|| string.IsNullOrEmpty(TextBox_actividades.Text)|| string.IsNullOrEmpty(TextBox_descripcion.Text)) {
            }
            else if (Convert.ToDateTime(DatePicker_inicio.Text) > Convert.ToDateTime(DatePicker_entrega.Text))
            {
                MessageBox.Show("La fecha de entrega es mucho antes a la de inicio, por favor, corrija el campo.");
                return;

            }else

            { if (ButtonCambio.Content.Equals("Eliminar") && ListBox_Archivos.SelectedIndex>-1)
            {
                proyectos.RemoveAt(ListBox_Archivos.SelectedIndex);
                guardarEmpleados();
                
                
                fillListBox();
                
            }else if (ButtonCambio.Content.Equals("Guardar"))

            {
               
                double PreEmpresas = Convert.ToDouble(TextBox_presupuestoEmpresa.Text);
                double Pre3ros = Convert.ToDouble(TextBox_Peresupuesto3ros.Text);
                double total = Pre3ros + PreEmpresas;
                TextBox_Presupuesto.Text = total.ToString();
                DatePickerModificacion.Text = DateTime.Now.ToString();
                
                    Proyecto proyectosTemp = new Proyecto();
                    proyectosTemp.IndiceDeCompletición = TexBox_Porcentaje.Text;
                    proyectosTemp.EmpresaSolicitadora = TextBox_Empresa.Text;
                    proyectosTemp.NombreProyecto = TextBox_titulo.Text;
                    proyectosTemp.Investigador = TextBox_investigador.Text;
                    proyectosTemp.AreaProyecto = TextBox_area.Text;
                    proyectosTemp.FechaInicio =Convert.ToDateTime( DatePicker_inicio.Text);
                    proyectosTemp.FechaFinalización = Convert.ToDateTime(DatePicker_entrega.Text);
                    proyectosTemp.FechaModificacion = Convert.ToDateTime(DatePickerModificacion.Text);
                    proyectosTemp.Presupuesto = Convert.ToDouble(TextBox_Presupuesto.Text);
                    proyectosTemp.PagoPorParteEmpresa =Convert.ToDouble( TextBox_presupuestoEmpresa.Text);
                    proyectosTemp.PagoPorParteUPB =Convert.ToDouble( TextBox_Peresupuesto3ros.Text);
                    proyectosTemp.ActividadProyecto = TextBox_actividades.Text;
                    proyectosTemp.DescripciónProyecto = TextBox_descripcion.Text;

                    proyectos.Add(proyectosTemp);

                
                guardarEmpleados();
                    MessageBox.Show("El archivo se ha guardado correctamente");
                
                fillListBox();


            
            }
        
            else if (ButtonCambio.Content.Equals("Sobre-Escribir")) {
                double PreEmpresas = Convert.ToDouble(TextBox_presupuestoEmpresa.Text);
                double Pre3ros = Convert.ToDouble(TextBox_Peresupuesto3ros.Text);
                double total = Pre3ros + PreEmpresas;
                TextBox_Presupuesto.Text = total.ToString();
                DatePickerModificacion.Text = DateTime.Now.ToString();

                Proyecto proyectoTemporal = proyectos.ElementAt(ListBox_Archivos.SelectedIndex);
                proyectoTemporal.NombreProyecto = TextBox_titulo.Text;
                proyectoTemporal.Investigador = TextBox_investigador.Text;
                proyectoTemporal.AreaProyecto = TextBox_area.Text;
                proyectoTemporal.FechaInicio =Convert.ToDateTime( DatePicker_inicio.Text);
                proyectoTemporal.FechaFinalización =Convert.ToDateTime( DatePicker_entrega.Text);
                proyectoTemporal.FechaModificacion = Convert.ToDateTime(DatePickerModificacion.Text);
                proyectoTemporal.IndiceDeCompletición = TexBox_Porcentaje.Text;
                proyectoTemporal.EmpresaSolicitadora = TextBox_Empresa.Text;
                proyectoTemporal.Presupuesto = Convert.ToDouble(TextBox_Presupuesto.Text);
                proyectoTemporal.PagoPorParteEmpresa =Convert.ToDouble( TextBox_presupuestoEmpresa.Text);
                proyectoTemporal.PagoPorParteUPB =Convert.ToDouble(TextBox_Peresupuesto3ros.Text);
                proyectoTemporal.DescripciónProyecto = TextBox_descripcion.Text;
                proyectoTemporal.ActividadProyecto = TextBox_actividades.Text;

                    guardarEmpleados();


                fillListBox();
            
        }
        }
        }


        private void ListBox_Archivos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cargarEmpleadoSeleccionado();
        }

        private void ComboBox_Elecciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            fillListBox();
            switch (ComboBox_Elecciones.SelectedIndex)
            {
                case 0:
                    {
                        modoConsulta();
                    }
                    break;
                case 1:
                    {
                        modoEditar();
                    }
                    break;
                case 2:
                    {
                        modoAgregar();
                    }
                    break;
                case 3:
                    {
                        modoEliminar();
                    }
                    break;

            }
        }

        private void ComboBoxesOrden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (ComboBoxesOrden.SelectedIndex)
            {
                case 0:
                    {
                        OrdenArea();
                    }
                    break;
                case 1:
                    {
                        OrdenPresupuestoMayor();
                    }
                    break;
                case 2:
                    {
                        OrdenPresupuestoMenor();
                    }
                    break;
                case 3:
                    {
                        OrdenNombre();
                    }
                    break;
                  
                case 4:
                    {
                        OrdenFechaReciente();
                    }
                    break;
                case 5:
                    {
                        OrdenFechaViejo();
                           
                    }
                    break;
                case 6:
                    {
                        ordenModificacion();
                    }
                    break;
                    



            }

        }

        private void ordenModificacion()
        {
            proyectos = proyectos.OrderBy(x => x.FechaModificacion).ToArray().ToList();
            fillListBox();
        }
        
       private void OrdenArea() {
            proyectos = proyectos.OrderBy(x => x.AreaProyecto).ToList();
            fillListBox();
            
        }



      private void OrdenPresupuestoMayor()
       {

            proyectos = proyectos.OrderBy(x => x.Presupuesto).Reverse().ToArray().ToList();

            fillListBox();


        }
       private void OrdenPresupuestoMenor()
       {
           


            proyectos = proyectos.OrderBy(x => x.Presupuesto).ToArray().ToList();
            fillListBox();

        }
        private void OrdenNombre()
       {
            proyectos = proyectos.OrderBy(x => x.NombreProyecto).ToArray().ToList();
            fillListBox();
       }

       private void OrdenFechaReciente()
           
       {
           proyectos = proyectos.OrderBy(x => x.FechaInicio).Reverse().ToArray().ToList();

            fillListBox();
       }
       private void OrdenFechaViejo()
       {
            proyectos = proyectos.OrderBy(x => x.FechaInicio).ToArray().ToList();
            fillListBox();
       }

        private void ButtonAyuda_Click(object sender, RoutedEventArgs e)
       {
           Ventana_de_ayuda ayuda = new Ventana_de_ayuda();
           ayuda.Show();
       }
    }




}
