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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        CapaNegocio.Persona persona = new CapaNegocio.Persona();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            //Asignar las propiedades al objeto persona
            
            persona.Nombres = txtNombre.Text.Trim();
            persona.Codigo = txtCodigo.Text.Trim();
            persona.Apellidos = txtApellido.Text.Trim();
            persona.Domicilio = txtDomicilio.Text.Trim();
            persona.Correo = txtCorreo.Text.Trim();

            //Asignar lugar de nacimiento al objeto
            if (cboLugarNacimiento.SelectedIndex >= 1)
            {
                persona.LugarNac = cboLugarNacimiento.Text;
            }

            else MessageBox.Show("Seleccione una ciudad correcta");

            persona.FechaNac = dtpFechaNac.DisplayDate;

            if (cboLugarNacimiento.SelectedIndex >= 1)
            {

                MessageBox.Show("Los datos de la persona fueron registrados correctamente");
            }

           
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            //Llamar a la siguiente pagina
            Mantenimiento.Window1 window1 = new Mantenimiento.Window1();
            //Emparentar formulario con el principal
            window1.Show();

        }

        private void cboLugarNacimiento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        
    }
}
