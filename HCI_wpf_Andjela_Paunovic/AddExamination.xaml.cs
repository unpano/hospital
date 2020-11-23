using Model;
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
    /// Interaction logic for AddExamination.xaml
    /// </summary>
    public partial class AddExamination : Window
    {
        Controller.InterventionController interventionController = new Controller.InterventionController();
        public AddExamination()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, MouseButtonEventArgs e)
        {
            //Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();

        }
        public static int intervId;
        private void backClick(object sender, RoutedEventArgs e)
        {
            int patientId = Appointments.interv.PatientId;
            String description = descript.Text;
            intervId = interventionController.AddDescription(patientId,description);
            //Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Prescription pres = new Prescription();
            pres.Show();
            this.Close();
        }

       
    }
}
