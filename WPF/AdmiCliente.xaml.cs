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
using BibliotecaClases;
using MahApps.Metro.Controls;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para AdmiCliente.xaml
    /// </summary>
    public partial class AdmiCliente : Window
    {
        public AdmiCliente()
        {
            InitializeComponent();
            CargarActividad();
            CargarTiposEmpresa();
            cargarDT();
            CargarCliente();
        }

        private void cargarDT()
        {
            Cliente cli = new Cliente();
            dg_AdmiCliente.ItemsSource = cli.LeerClientes();
        }

        // carga de cbx Tipo Empresa
        private void CargarTiposEmpresa()
        {
            List<TipoEmpresa> tips = new TipoEmpresa().LeerTodos();
            tips.Add(new TipoEmpresa() { IdTipoEmpresa = 0, Descripcion = "Seleccione una actividad" });
            cbx_FiltraTipo.ItemsSource = tips;
            cbx_FiltraTipo.DisplayMemberPath = "Descripcion";
            cbx_FiltraTipo.SelectedValuePath = "IdTipoEmpresa";
            cbx_FiltraTipo.SelectedValue = 0;
        }

        // carga de cbx Actividad
        private void CargarActividad()
        {
            List<ActividadEmpresa> admi = new ActividadEmpresa().LeerTodos();
            admi.Add(new ActividadEmpresa() { IdActividadEmpresa = 0, Descripcion = "Seleccione una Actividad" });
            cbx_FiltraActi.ItemsSource = admi;
            cbx_FiltraActi.DisplayMemberPath = "Descripcion";
            cbx_FiltraActi.SelectedValuePath = "IdActividadEmpresa";
            cbx_FiltraActi.SelectedValue = 0;
        }

        //Cargar Cliente
        public void CargarCliente()
        {
            Cliente cli = new Cliente();

            dg_AdmiCliente.ItemsSource = cli.LeerClientes();
        }
        
        private void Btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente();

            dg_AdmiCliente.ItemsSource = cli.RutConsulta(txb_Rut.Text);
        }

        private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente agreCli = new AgregarCliente("", "", "", "", "", "", 0, 0);
            this.Close();
            agreCli.Show();

        }

        private void Txb_Rut_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Cliente cli = new Cliente();

            dg_AdmiCliente.ItemsSource = cli.RutConsulta(txb_Rut.Text);
        }

        private void Btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = (Cliente)dg_AdmiCliente.SelectedItem;
                AgregarCliente Ag = new AgregarCliente(cli.RutCliente, cli.NombreContacto, cli.RazonSocial, cli.MailContacto, cli.Direccion, cli.Telefono, cli.IdTipoEmpresa, cli.IdActividadEmpresa);
                Ag.Show();
                this.Close();
            }
            catch
            { }
        }

        private void Btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (!eSValido())
            {
                return;
            }
            Cliente cli = new Cliente()
            {
                RutCliente = txb_Rut.Text
            };
            MessageBoxResult eliminar = MessageBox.Show("¿Esta seguro de quiere eliminar a este Cliente", "Conformar",
                                         MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (eliminar == MessageBoxResult.Yes)
            {
                if (cli.EliminarCliente())
                {
                    MessageBox.Show("Cliente eliminado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cliente no Pudo ser eliminado", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Rut ingresado Invalido", "Atencion", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private bool eSValido()
        {
            throw new NotImplementedException();
        }

        private void Btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente();

            dg_AdmiCliente.ItemsSource = cli.LeerClientes();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu main = new Menu();
            main.Show();
            this.Close();
        }

        private void Cbx_FiltraActi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cliente cli = new Cliente();

            int id = ((List<ActividadEmpresa>)cbx_FiltraActi.ItemsSource)[cbx_FiltraActi.SelectedIndex].IdActividadEmpresa;
            dg_AdmiCliente.ItemsSource = cli.FiltrarXActividad(id);
        }

        private void Dg_AdmiCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
