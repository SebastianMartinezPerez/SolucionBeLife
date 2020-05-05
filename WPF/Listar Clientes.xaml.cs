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

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Listar_Clientes.xaml
    /// </summary>
    public partial class Listar_Clientes : Window
    {
        public Listar_Clientes()
        {
            InitializeComponent();
            ListarClientes();
            foreach (Actividad activi in Enum.GetValues(typeof(Actividad)))
            {
                cmbActividadEmpresa.Items.Add(activi);
            }
            foreach (TipoEmpresa tipoemp in Enum.GetValues(typeof(TipoEmpresa)))
            {
                cmbTipoEmpresa.Items.Add(tipoemp);
            }
        }

        private void ListarClientes()
        {
            ColeccionClientes Clientes = (ColeccionClientes)Application.Current.Resources["misClientes"];
            dgListaClientes.ItemsSource = clientes;
            dgListaClientes.Items.Refresh();
        }

        private void TileBuscarRut_Click(object sender, RoutedEventArgs e)
        {
            ColeccionClientes misClientes = (ColeccionClientes)Application.Current.Resources["misClientes"];
            dgListaClientes.ItemsSource = misClientes.BuscarPorRut(txtRut.Text);
            dgListaClientes.Items.Refresh();
        }

        private void TileBuscarActividad_Click(object sender, RoutedEventArgs e)
        {
            ColeccionClientes misClientes = (ColeccionClientes)Application.Current.Resources["misClientes"];
            dgListaClientes.ItemsSource = misClientes.BuscarPorRut(txtRut.Text);
            dgListaClientes.Items.Refresh();
        }
    }
}
