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
    /// Lógica de interacción para Administrativo1.xaml
    /// </summary>
    public partial class Administrativo1 : Window
    {
        public Administrativo1()
        {
            InitializeComponent();
        }
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();
        //Segundo


        //Primero

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            administrativo.Cargo = txtCargo.Text.Trim();
            administrativo.Horario = txtHorario.Text.Trim();
            administrativo.Sueldo = txtSueldo.Text.Trim();
            administrativo.TipoContrato = txtTipoC.Text.Trim();

            MessageBox.Show("Los datos del objeto alumno fueron registrados correctamente");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cargo: " + administrativo.Cargo + "\nHorario: " + administrativo.Horario
                + "\nSueldo: " + administrativo.Sueldo + "\nTipo de contrato: " + administrativo.TipoContrato);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Gestionar());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Elaborar());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Asistir());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Existir());
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Actualizar());
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Agregar());
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Buscar());
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Eliminar());
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Listar());
        }
    }
 }
