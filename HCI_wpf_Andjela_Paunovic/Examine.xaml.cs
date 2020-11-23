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
    /// Interaction logic for Examine.xaml
    /// </summary>
    public partial class Examine : Window
    {
        Controller.PatientController patientController = new Controller.PatientController();

        public Examine()
        {
            InitializeComponent();
            int patientId = Appointments.interv.PatientId;
            Patient patient = patientController.ViewPatientProfile(patientId);
            DataContext = patient;
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Appointment list page
            Appointments appoints = new Appointments();
            appoints.Show();
            this.Close();
        }

        private void ScheduleOperation(object sender, RoutedEventArgs e)
        {
            //Schedule operation
            ScheduleOperation oper = new ScheduleOperation();
            oper.Show();
            this.Close();
        }

        private void therClick(object sender, RoutedEventArgs e)
        {
            Therapies therapy = new Therapies();
            therapy.Show();
            this.Close();
        }

        private void healthInfoClick(object sender, RoutedEventArgs e)
        {
            PatientInfo pi = new PatientInfo();
            pi.Show();
            this.Close();
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            AddExamination add = new AddExamination();
            add.Show();
            this.Close();
        }

        //EARLIER EXAMINATIONS
        private void earlierClick(object sender, RoutedEventArgs e)
        {


            EarlierExaminations exams = new EarlierExaminations();
            exams.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //uvecaj brojac odsutnosti kod pacijenta
            int patientId = Appointments.interv.PatientId;
            patientController.NoteAbsence(patientId);

            Appointments apps = new Appointments();
            apps.Show();
            this.Close();
        }
    }
}
