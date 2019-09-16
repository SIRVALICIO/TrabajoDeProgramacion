using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Window2()
        {
            InitializeComponent();
        }

       
        private void Button_Salir_ventana_Proyectos_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow salir_ventana = new MainWindow();
            salir_ventana.Show();
            this.Close();

        }

     
      
        private void Button_Crear_Click(object sender, RoutedEventArgs e)
        {
            WindowInfo Crear_proyecto = new WindowInfo();
            //this.Hide();
            Crear_proyecto.Show();
            //Crear_proyecto.Show();
            this.Close();
        }

        private void Button_cerrar_Click(object sender, RoutedEventArgs e)
        {
            form_opciones_archivos_main.Close();
        }
    }
}
