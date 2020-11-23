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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Controller.DoctorController;


namespace HCI_wpf_Andjela_Paunovic
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Controller.DoctorController docController = new Controller.DoctorController();
        
        public Login()
        {
            InitializeComponent();

        }

        public static Doctor loggedDoctor;
 
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //saved logged doctor
            loggedDoctor = docController.LoginDoctor(TextBox1.Text, TextBox2.Password.ToString());
            
            if (loggedDoctor != null)
            {
                ///Successful login
                Wizard wiz = new Wizard();
                wiz.Show();
                this.Close();
            }
            else
            {
                InvalidLogin invalidLogin = new InvalidLogin();
                invalidLogin.Show();
                this.Close();
            }
        }

        private void forgottenPassword(object sender, RoutedEventArgs e)
        {
            ForgottenPassword forgottenPassword = new ForgottenPassword();
            forgottenPassword.Show();
            this.Close();
        }
    }
}
