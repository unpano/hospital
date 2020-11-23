using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
    /// Interaction logic for Therapies.xaml
    /// </summary>
    public partial class Therapies : Window
    {
        public ObservableCollection<Therapy> therapyList = new ObservableCollection<Therapy>();
        Controller.TherapyController therapyController = new Controller.TherapyController();

        public Therapies()
        {
            InitializeComponent();

            int patientId = Appointments.interv.PatientId;
            therapyList = therapyController.ViewTherapies(patientId);
            therapies.ItemsSource = therapyList;
            
        }

        private void ListViewItem_onClick(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                Therapy therapy = (Therapy)item.Content;
                //kad kliknem na lek da me pita da li zelim da obrisem
                // Configure the message box to be displayed
                string messageBoxText = "Are you sure you want to remove therapy?";
                string caption = "";
                MessageBoxButton button = MessageBoxButton.YesNo;

                // Display message box
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button);

                // Process message box results
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        // Obrisi terapiju

                        therapyController.RemoveTherapy(therapy);
                        
                        break;
                    case MessageBoxResult.No:
                        break;

                }
                Therapies therapies = new Therapies();
                therapies.Show();
                this.Close();
            }
        }

        private void backClick(object sender, MouseButtonEventArgs e)
        {
            //Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();

        }


    }
}
