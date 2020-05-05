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

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para wpfMenu.xaml
    /// </summary>
    public partial class wpfMenu : MetroWindow
    {
        public wpfMenu()
        {
            InitializeComponent();
        }

        private void TileListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TileAdmContrato1_Click(object sender, RoutedEventArgs e)
        {
            WpfContrato con = new WpfContrato();
            con.Show();
        }

        private void TileAdmCliente1_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
        }
    }
}
