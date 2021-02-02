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
using Models;

namespace UniversityManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void viewStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();

            var studentsWindow = new StudentsWindow();
            studentsWindow.ShowDialog();

            ShowDialog();
        }

        private void viewTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();

            var teacherWindow = new TeachersWindow();
            teacherWindow.ShowDialog();

            ShowDialog();
        }
    }
}
