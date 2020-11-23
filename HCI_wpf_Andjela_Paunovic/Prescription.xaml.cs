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
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Window
    {
        public Prescription()
        {
            InitializeComponent();
        }


        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddExamination add = new AddExamination();
            add.Show();
            this.Close();
        }

        private void prescribeMedication(object sender, RoutedEventArgs e)
        {
            AddTherapy addtherapy = new AddTherapy();
            addtherapy.Show();
            this.Close();
        }

        public static int reportOrPrescription;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            reportOrPrescription = 0;

            Forma form = new Forma();
            form.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            reportOrPrescription = 1;

            Forma form = new Forma();
            form.Show();
            this.Close();
        }
    }
}
