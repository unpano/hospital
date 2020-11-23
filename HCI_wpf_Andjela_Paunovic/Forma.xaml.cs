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
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Forma : Window
    {
        Controller.FormController formController = new Controller.FormController();

        public Forma()
        {
            InitializeComponent();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddExamination add = new AddExamination();
            add.Show();
            this.Close();
        }

        private void Placeholder_Click(object sender, RoutedEventArgs e)
        {
            Form form = new Form();
            form.ReportOrPrescription = Prescription.reportOrPrescription;
            form.InterventionId = AddExamination.intervId;
            form.Description = TextArea.Text;
            if ((String)kombo.SelectedItem == "Specialist")
                form.FFormType = FormType.Specialist;
            else if ((String)kombo.SelectedItem == "LabTesting")
                form.FFormType = FormType.LabTesting;
            else form.FFormType = FormType.StationaryTreatment;

            formController.AddForm(form);

            AddExamination add = new AddExamination();
            add.Show();
            this.Close();
        }
    }
}
