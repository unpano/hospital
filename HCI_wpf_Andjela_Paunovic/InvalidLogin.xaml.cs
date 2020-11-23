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
    /// Interaction logic for InvalidLogin.xaml
    /// </summary>
    public partial class InvalidLogin : Window
    {
        Controller.DoctorController docController = new Controller.DoctorController();
        public InvalidLogin()
        {
            InitializeComponent();

        }



        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Doctor doc = docController.LoginDoctor(TextBox1.Text, TextBox2.Password.ToString());

            if (doc != null)
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

