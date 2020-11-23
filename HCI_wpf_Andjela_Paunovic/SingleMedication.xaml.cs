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
    /// Interaction logic for SingleMedication.xaml
    /// </summary>
    public partial class SingleMedication : Window
    {
        Controller.MedicationController medicationController = new Controller.MedicationController();
        public SingleMedication()
        {
            InitializeComponent();

            DataContext = MedicationList.med;
        }
       
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var backWindow = new MedicationList();
            backWindow.Show();
            this.Close();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            medicationController.ApproveMedication(MedicationList.med.Id);
            var approveWindow = new SingleMedication();
            approveWindow.Show();
            this.Close();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MedicationList medPage = new MedicationList();
            medPage.Show();
            this.Close();
        }
    }
}
