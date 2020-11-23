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
    /// Interaction logic for PatientInfo.xaml
    /// </summary>
    public partial class PatientInfo : Window
    {
        Controller.PatientController patientController = new Controller.PatientController();
        public PatientInfo()
        {
            InitializeComponent();

            
            int patientId = Appointments.interv.PatientId;
            Patient patient = patientController.ViewPatientProfile(patientId);
            
            //nadji pacijenta na osnovu id-ja i vrati objekat pacijenta
            DataContext = patient;
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();
        }
    }
}
