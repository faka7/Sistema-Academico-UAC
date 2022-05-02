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

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();
        CapaNegocio.Docente docente = new CapaNegocio.Docente();
        CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Paginas.Alumno1 alumno1 = new Paginas.Alumno1();
            alumno1.Show();
            
            
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Paginas.Docente docente = new Paginas.Docente();
            docente.Show();
            
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Paginas.Administrativo1 administrativo = new Paginas.Administrativo1();
            administrativo.Show();

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
