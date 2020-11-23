using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for EarlierExaminations.xaml
    /// </summary>
    public partial class EarlierExaminations : Window
    {
        Controller.InterventionController interventionController = new Controller.InterventionController();

        public ObservableCollection<Intervention> interventionList = new ObservableCollection<Intervention>();

        public EarlierExaminations()
        {
            InitializeComponent();

            //prosledi id pacijenta
            int patientId = Appointments.interv.PatientId;
            interventionList = interventionController.ViewEarlierInterventions(patientId);
            earlierExaminationList.ItemsSource = interventionList;
        }

        public static Intervention intervention;
        private void ListViewItem_onClick(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                //prikazi sacuvane podatke 
                intervention = (Intervention)item.Content;

                ExaminationShow examShow = new ExaminationShow();
                examShow.Show();
                this.Close();
            }
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ExaminationShow exam = new ExaminationShow();
            exam.Show();
            this.Close();
        }
    }
}
