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
    /// Interaction logic for LeaveFeedback.xaml
    /// </summary>
    public partial class LeaveFeedback : Window
    {
        Controller.FeedbackController feedbackController = new Controller.FeedbackController();
        public LeaveFeedback()
        {
            InitializeComponent();
        }

        private void sendClick(object sender, RoutedEventArgs e)
        {
            String text = TextArea.Text;
            Feedback createdFeedback = feedbackController.CreateFeedback(text);
            Boolean isFeedbackAdded = feedbackController.AddFeedback(createdFeedback);


            // Configure the message box to be displayed
            string messageBoxText = "Thank you for sharing your thoughts with us! :)";
            string caption = "";
            MessageBoxButton button = MessageBoxButton.OK;

            // Display message box
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button);

           
                    MedicationList medPage = new MedicationList();
                    medPage.Show();
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
