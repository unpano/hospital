using Controller;
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
    /// Interaction logic for AddTherapy.xaml
    /// </summary>
    public partial class AddTherapy : Window
    {
        Controller.TherapyController therapyController = new Controller.TherapyController();
        ObservableCollection<Medication> _medications = new ObservableCollection<Medication>();

        public AddTherapy()
        {
            InitializeComponent();
            DataContext = this;

            String[] foundRecordDoc;
            String[] linesDoc = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/medications.csv");

            for (int i = 1; i < linesDoc.Length; i++)
            {
                //Na osnovu unete specijalizacije treba da se izlistaju odredjeni doktori
                Medication med = new Medication();
                foundRecordDoc = linesDoc[i].Split(',');
                med.Name = foundRecordDoc[1];

                Medications.Add(med);
            }
        }
        public ObservableCollection<Medication> Medications

        {
            get { return _medications; }
            set { _medications = value; }
        }

        private Medication _medication;
        public Medication ShowMedication
        {
            get { return _medication; }
            set { _medication = value; }
        }

        private void submitClick(object sender, RoutedEventArgs e)
        {
            //sacuvaj terapiju
            Therapy therapy = new Therapy();
            therapy.PatientId = Appointments.interv.PatientId;
            therapy.MedicationName = ((Medication)dropMedications.SelectedItem).Name;
            therapy.Dose = Convert.ToInt32(dose.Text);
            therapyController.AddTherapy(therapy);
            AddExamination add = new AddExamination();
            add.Show();
            this.Close();
        }
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddExamination add = new AddExamination();
            add.Show();
            this.Close();
        }
    }
}
