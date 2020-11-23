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
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class Appointments : Window
    {
        Controller.InterventionController interventionController = new Controller.InterventionController();

        public ObservableCollection<Intervention> interventionList = new ObservableCollection<Intervention>();

        public Appointments()
        {
            InitializeComponent();

            int doctorId = Login.loggedDoctor.ID;
            interventionList = interventionController.ViewScheduledInterventions(doctorId);
            appointList.ItemsSource = interventionList;
        }

        public static Intervention interv;
        private void ListViewItem_onClick(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                interv = (Intervention)item.Content;


                Examine examine = new Examine();
                examine.Show();
                this.Close();
            }
        }

        private void medClick(object sender, RoutedEventArgs e)
        {
            ///Medication list page
            MedicationList medPage = new MedicationList();
            medPage.Show();
            this.Close();
        }

        private void appClick(object sender, RoutedEventArgs e)
        {
            //Appointment list page
            Appointments appoints = new Appointments();
            appoints.Show();
            this.Close();
        }

        private void profClick(object sender, RoutedEventArgs e)
        {
            ///Profile page
            Profile prof = new Profile();
            prof.Show();
            this.Close();
        }

        private void queClick(object sender, RoutedEventArgs e)
        {
            ///Questions list
            Questions que = new Questions();
            que.Show();
            this.Close();
        }

        private void logOutClick(object sender, RoutedEventArgs e)
        {
            // Configure the message box to be displayed
            string messageBoxText = "Are you sure you want to quit?";
            string caption = "";
            MessageBoxButton button = MessageBoxButton.YesNo;

            // Display message box
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button);

            // Process message box results
            switch (result)
            {
                case MessageBoxResult.Yes:
                    // User pressed Yes button
                    Login login = new Login();
                    login.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    // User pressed No button
                    MedicationList medPage = new MedicationList();
                    medPage.Show();
                    this.Close();
                    break;

            }
        }

        private void feedbackClick(object sender, RoutedEventArgs e)
        {
            ///Feedback page
            LeaveFeedback feedback = new LeaveFeedback();
            feedback.Show();
            this.Close();
        }

        private void openClick(object sender, RoutedEventArgs e)
        {
            Open.Visibility = Visibility.Collapsed;
            Close.Visibility = Visibility.Visible;
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            Open.Visibility = Visibility.Visible;
            Close.Visibility = Visibility.Collapsed;

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Show examination options
            Examine examine = new Examine();
            examine.Show();
            this.Close();
        }

    }
}

