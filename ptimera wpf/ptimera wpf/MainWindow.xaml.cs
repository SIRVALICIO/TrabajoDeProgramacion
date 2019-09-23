using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ptimera_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string usuario = "Juan Paloma";
        static string contraseña = "pepega";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            form_login_main.Close();
            //System.Windows.Application.Current.Shutdown(); 
        }

        private void Button_validar_Click(object sender, RoutedEventArgs e)
        {
            
            if (TexBox_Usuario.Text.Equals(usuario) && TexBox_contraseña.Text.Equals(contraseña))
            {
                MessageBox.Show("Ingreso exitoso");

                Window2 ventana_proyectos = new Window2();

                //this.Hide();

                //ventana_proyectos.ShowDialog();
                ventana_proyectos.Show();
                //this.Show();
                this.Close();
            }
            
            else if(string.IsNullOrWhiteSpace(TexBox_contraseña.Text) || string.IsNullOrWhiteSpace(TexBox_Usuario.Text))
            {
                MessageBox.Show("Información inválida: ingreso de información nulo");
            }
            else
            {
                MessageBox.Show("Campos completados de manera incorrecta");
            }
           
            
           
        }

        private void TexBox_Usuario_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TexBox_Usuario.Text = "";

        }

        private void TexBox_contraseña_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TexBox_contraseña.Text = "";
        }

        private void Button_salir_Click(object sender, RoutedEventArgs e)
        {
             form_login_main.Close();
        }

        
    }
}
