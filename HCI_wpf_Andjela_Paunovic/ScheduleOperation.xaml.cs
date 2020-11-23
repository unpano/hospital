using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Interaction logic for ScheduleOperation.xaml
    /// </summary>
    public partial class ScheduleOperation : Window
    {
        Controller.InterventionController interventionController = new Controller.InterventionController();

        ObservableCollection<Doctor> _doctors = new ObservableCollection<Doctor>();
        ObservableCollection<Specialization> _specializations = new ObservableCollection<Specialization>();
        public ObservableCollection<Specialization> Specializations

        {
            get { return _specializations; }
            set { _specializations = value; }
        }

        private Specialization _specialization;
        public Specialization ShowSpec
        {
            get { return _specialization; }
            set { _specialization = value; }
        }

        public ObservableCollection<Doctor> Doctors

        {
            get { return _doctors; }
            set { _doctors = value; }
        }

        private Doctor _doctor;
        public Doctor ShowDoctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }
        public ScheduleOperation()
        {
            InitializeComponent();
            DataContext = this;

            String[] foundRecordSpec;
            String[] linesSpec = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/specializations.csv");

            for (int i = 1; i < linesSpec.Length; i++)
            {

                Specialization spec = new Specialization();
                foundRecordSpec = linesSpec[i].Split(',');
                spec.SpecName = foundRecordSpec[1];

                Specializations.Add(spec);
            }

            String[] foundRecordDoc;
            String[] linesDoc = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/doctors.csv");

            for (int i = 1; i < linesDoc.Length; i++)
            {
                //Na osnovu unete specijalizacije treba da se izlistaju odredjeni doktori
                Doctor doc = new Doctor();
                foundRecordDoc = linesDoc[i].Split(',');
                doc.FirstName = foundRecordDoc[0] + " " + foundRecordDoc[1] + " " + foundRecordDoc[2];

                Doctors.Add(doc);
            }
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();
        }

        //funkciju za update liste doktora pozivam ako je selektovana specijalizacija u comboBox-u
        private void updateDoctors(Specialization spec)
        {
            for (int i = Doctors.Count - 1; i >= 0; i--)
            {

                Doctors.RemoveAt(i);

            }
            String[] foundRecordDoc;
            String[] linesDoc = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/doctors.csv");

            for (int i = 1; i < linesDoc.Length; i++)
            {
                Doctor doc = new Doctor();
                foundRecordDoc = linesDoc[i].Split(',');
                if (spec.SpecName == foundRecordDoc[12])
                {
                    doc.FirstName = foundRecordDoc[0] + " " + foundRecordDoc[1] + " " + foundRecordDoc[2];
                    Doctors.Add(doc);
                }

            }
        }
        private void submitClick(object sender, RoutedEventArgs e)
        {
            DateTime start = (DateTime)date.SelectedDate;
            String interventionType = (String)interventionComboBox.SelectedItem;
            Doctor doctor = (Doctor)doctorComboBox.SelectedItem;
            String doctorName = doctor.FirstName;
            //prilikom zakazivanja pregleda treba proslediti i id pacijenta
            int patientId = Appointments.interv.PatientId;
            Intervention createdIntervention = interventionController.CreateIntervention(start, doctorName,interventionType,patientId);
            Intervention scheduledIntervention = interventionController.ScheduleIntervention(createdIntervention);

            ///Medication list page
            MedicationList medPage = new MedicationList();
            medPage.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (specComboBox.SelectedItem != null)
            {
                updateDoctors((Specialization)specComboBox.SelectedItem);
            }
        }
    }
}
