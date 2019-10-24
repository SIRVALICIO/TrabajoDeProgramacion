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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ptimera_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Login> login = new List<Login>();
       

        public MainWindow()
        {
            InitializeComponent();
            string read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Datos.txt");
            if (!read.Equals(""))
            {
             login = JsonConvert.DeserializeObject<List<Login>>(read);


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            form_login_main.Close();
            //System.Windows.Application.Current.Shutdown(); 
        }

        private void Button_validar_Click(object sender, RoutedEventArgs e)
        {
            int cont = 0;
           
           foreach(Login i in login)
            {
                if(TexBox_Usuario.Text.Equals(i.usuario) && PasswordBoxContraseña.Password.Equals(i.contraseña))
                {
                    Window2 nueva = new Window2();
                    nueva.Show();
                    this.Close();
                    break;

                }
                cont++;
                if (cont.Equals(login.Count))
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
              
                

            }

            
            
           
        }

        private void TexBox_Usuario_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TexBox_Usuario.Text = "";

        }

      

        private void Button_salir_Click(object sender, RoutedEventArgs e)
        {
             form_login_main.Close();
        }

        private void PasswordBoxContraseña_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
