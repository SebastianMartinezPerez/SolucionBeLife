using BibliotecaClases;
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
    /// Lógica de interacción para CrearCliente.xaml
    /// </summary>
    public partial class CrearCliente : Window
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void TxtRut_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtRazon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TileActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!validar())
                {
                    return;
                }

                ColeccionClientes misClientes = (ColeccionClientes)Application.Current.Resources["misClientes"];
                Cliente cli = misClientes.BuscarCliente(txtRut.Text);

                cli.NombreContacto = txtNombre.Text;
                cli.RazonSocial = txtRazon.Text;
                cli.Direccion = txtDireccion.Text;
                cli.IdTipoEmpresa = (TipoEmpresa)cmbTipoEmpresa.SelectedValue;
                cli.Telefono = int.Parse(txtTelefono.Text);
                cli.IdActividadEmpresa = (Actividad)cmbActividadEmpresa.SelectedValue;
                cli.Mail = txtMail.Text;

                MessageBox.Show("Cliente Modificado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente no se encuentra registrado.");
            }
        }

        private bool validar()
        {
            throw new NotImplementedException();
        }

        private void TileLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TileAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (!validar())
            {
                return;
            }

            ColeccionClientes misClientes = (ColeccionClientes)Application.Current.Resources["misClientes"];
            Cliente buscarCliente = new Cliente();
            buscarCliente = misClientes.BuscarCliente(txtRut.Text);
            if (buscarCliente != null)
            {
                MessageBox.Show("Ya existe cliente con ese Rut.");
                return;
            }

            Cliente cli = new Cliente();

            cli.Rut = txtRut.Text;
            cli.NombreContacto = txtNombre.Text;
            cli.RazonSocial = txtRazon.Text;
            cli.Direccion = txtDireccion.Text;
            cli.IdTipoEmpresa = (TipoEmpresa)cmbTipoEmpresa.SelectedValue;
            cli.Telefono = int.Parse(txtTelefono.Text);
            cli.Activi = (Actividad)cmbActividadEmpresa.SelectedValue;
            cli.Mail = txtMail.Text;

            misClientes.Add(cli);
            MessageBox.Show("El cliente fue registrado.");
            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRazon.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cmbTipoEmpresa.SelectedIndex = -1;
            txtTelefono.Text = string.Empty;
            cmbActividadEmpresa.SelectedIndex = -1;
            txtMail.Text = string.Empty;
        }

        private void TileRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
