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

namespace HCI_wpf_Andjela_Paunovic
{
    /// <summary>
    /// Interaction logic for Wizard.xaml
    /// </summary>
    public partial class Wizard : Window
    {
        public Wizard()
        {
            InitializeComponent();
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            MedicationList medPage = new MedicationList();
            medPage.Show();
            this.Close();
        }

        private void nextClick(object sender, RoutedEventArgs e)
        {
            Wizard1 wiz1 = new Wizard1();
            wiz1.Show();
            this.Close();
        }
    }
}
