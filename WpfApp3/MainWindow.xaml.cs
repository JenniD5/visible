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

namespace WpfApp3
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

        private void Btncalcular_Click(object sender, RoutedEventArgs e)
        {
            btnlimpiar.Visibility = Visibility.Visible;
        }

        private void Cbfiguras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbfiguras.SelectedIndex)
            {
                case 0://para el circulo
                    txtradio.Visibility = Visibility.Visible;
                    lblradio.Visibility = Visibility.Visible;
                    txtaltura.Visibility = Visibility.Hidden;
                    lblaltura.Visibility = Visibility.Hidden;
                    txtbase.Visibility = Visibility.Hidden;
                    lblbase.Visibility = Visibility.Hidden;
                    break;
                case 1://para el triangulo
                    txtaltura.Visibility = Visibility.Visible;
                    lblaltura.Visibility = Visibility.Visible;
                    txtbase.Visibility = Visibility.Visible;
                    lblbase.Visibility = Visibility.Visible;
                    txtradio.Visibility = Visibility.Hidden;
                    lblradio.Visibility = Visibility.Hidden;

                    break;
                default:
                    break;
            }
        }

        private void Btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtbase.Text = "";
            txtradio.Text = "";
            txtaltura.Text = "";
            lblresultado.Text = "";


        }
    }
}
