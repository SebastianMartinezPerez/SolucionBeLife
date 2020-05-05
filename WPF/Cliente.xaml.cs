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
// Librerias metro
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using BibliotecaClases;
using Controlador;
namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Cliente.xaml
    /// </summary>
    public partial class Cliente : MetroWindow
    {
        
        public Cliente()
        {
            InitializeComponent();
            cboSexo.ItemsSource =
                new DaoSexo().ReadAll();
            cboSexo.Items.Refresh();

        }

        private void txtNombres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string rut = txtRut.Text;
            string apellido = txtApellido.Text;
            string nombres = txtNombres.Text;
            

        }
    }
}
