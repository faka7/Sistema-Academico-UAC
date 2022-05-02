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

namespace CapaPresentacion.Paginas
{
    /// <summary>
    /// Lógica de interacción para Alumno1.xaml
    /// </summary>
    public partial class Alumno1 : Window
    {
        public Alumno1()
        {
            InitializeComponent();
        }
        static CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();
       

        private void btnVerDatos_Click(object sender, RoutedEventArgs e)
        {
            //Traer los atributos del objeto
            MessageBox.Show("Escuela: " + alumno.Escuela + "\nCondicion: " + alumno.Condicion + "\nSeguro: " + alumno.Seguro);
        }

        private void btnTerminarRegistro_Click(object sender, RoutedEventArgs e)
        {
            alumno.Escuela = txtEscuelaP.Text.Trim();
            alumno.Condicion = txtCondicion.Text.Trim();
            alumno.Seguro = txtSeguro.Text.Trim();

            MessageBox.Show("Los datos del objeto alumno fueron registrados correctamente");

        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Asistir());
        }

        private void btnEstudiar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Actualizar());
        }


        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Existir());

        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Agregar());
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Buscar());
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Eliminar());
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Listar());

        }
    }
}
