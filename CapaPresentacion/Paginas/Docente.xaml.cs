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
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }

        static CapaNegocio.Docente docente = new CapaNegocio.Docente();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            docente.Especialidad = txtEspecialidad.Text.Trim();
            docente.CantHora = txtCantidadH.Text.Trim();
            docente.Horario = txtHorario.Text.Trim();
            docente.EstadoCivil = txtEstadoC.Text.Trim();

            MessageBox.Show("Los datos del objeto alumno fueron registrados correctamente");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Especialidad: " + docente.Especialidad 
                + "\nCantHora: " + docente.CantHora + "\nHorario: " + docente.Horario              
                + "\nEstadoC: " + docente.EstadoCivil);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Enseñar());
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Actualizar());
        }

       

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Asistir());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Existir());

        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Agregar());
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Buscar());
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Eliminar());
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Listar());
        }
    }
}
