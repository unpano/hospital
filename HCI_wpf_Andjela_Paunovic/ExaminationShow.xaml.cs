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
    /// Interaction logic for ExaminationShow.xaml
    /// </summary>
    public partial class ExaminationShow : Window
    {
        public ExaminationShow()
        {
            InitializeComponent();

            DataContext = EarlierExaminations.intervention;
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EarlierExaminations exams = new EarlierExaminations();
            exams.Show();
            this.Close();
        }
    }
}
