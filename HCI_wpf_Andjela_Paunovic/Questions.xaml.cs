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
using static HCI_wpf_Andjela_Paunovic.QuestionList;

namespace HCI_wpf_Andjela_Paunovic
{
    /// <summary>
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Window
    {
        public ObservableCollection<Question> questions = new ObservableCollection<Question>();

        public Questions()
        {
            InitializeComponent();

            DataContext = this.GetApp();
        }

        public ObservableCollection<Question> GetApp()
        {
            questions.Add(new Question() { dateTime = "12.05.2020 07:34", questionContent = "Is it good for me to drink a lot of water while running. I have...", questionTitle = "Drinking water while running" });
            questions.Add(new Question() { dateTime = "13.06.2020 08:02", questionContent = "Can You tell me if it is good to exercise and what would you recommend me, because...", questionTitle = "Exercising" });
            questions.Add(new Question() { dateTime = "13.06.2020 08:37", questionContent = "I read somewhere, but I need proffesional opinion...", questionTitle = "Medication Imulben" });
            questions.Add(new Question() { dateTime = "14.06.2020 13:50", questionContent = "I have trouble with sleeping, I feel my head is going to explode...", questionTitle = "Headache" });
            questions.Add(new Question() { dateTime = "17.06.2020 18:00", questionContent = "I have trouble walking down the stairs. Ma legs ache me all the time. Cna you recomment me therapy or exercise...", questionTitle = "Legs" });
            questions.Add(new Question() { dateTime = "22.07.2020 15:13", questionContent = "A lot of bad things happend to me these days. I feel like I need a break...", questionTitle = "Relax" });
            questions.Add(new Question() { dateTime = "28.12.2020 13:50", questionContent = "I have trouble with sleeping, I feel my head is going to explode...", questionTitle = "Headache" });
            questions.Add(new Question() { dateTime = "29.12.2020 07:34", questionContent = "Is it good for me to drink a lot of water while running. I have...", questionTitle = "Drinking water while running" });


            return questions;
        }

        private void ReplyClick(object sender, RoutedEventArgs e)
        {
            ///Reply page
            Reply reply = new Reply();
            reply.Show();
            this.Close();
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

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
