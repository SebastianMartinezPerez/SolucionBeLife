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
// Libreria de metro
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using BibliotecaClases;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
            ColeccionClientes misClientes = new ColeccionClientes();
            Application.Current.Resources["misClientes"] = misClientes;
            ContratoCollection Contratos = new ContratoCollection();
            Application.Current.Resources["Contratos"] = Contratos;
            clientePrueba();
        }

        private void clientePrueba()
        {
            ColeccionClientes misClientes = (ColeccionClientes)Application.Current.Resources["misClientes"];
            Cliente Jorge = new Cliente()
            { Rut = "123-4", NombreContacto = "Jorge", RazonSocial = "Algo que hacer", Direccion = "La luna 1134", IdTipoEmpresa = TipoEmpresa.Limitada, Activi = Actividad.Alimentos, Mail = "jorgeelloco@gmail", Telefono = "5582" };
            misClientes.Add(Jorge);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            AdmContrato AdmC = new AdmContrato();
            AdmC.ShowDialog();
        }

        private void btnContrato_Click(object sender, RoutedEventArgs e)
        {
             WpfContrato contra= new WpfContrato();
            contra.Show();
        }

        private void TileListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            ListadoClientes listClientes = new ListadoClientes();
            listClientes.ShowDialog();
        }

        private void TileAdmContrato_Click(object sender, RoutedEventArgs e)
        {
            AdministrarClientes AdmClientes = new AdministrarClientes();
            AdmClientes.ShowDialog();
        }
    }
}
