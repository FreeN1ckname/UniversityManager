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
        UniversityEntities _context;

        public MainWindow(UniversityEntities context)
        {
            InitializeComponent();

            _context = context;
        }

        private void ShowWindow(Window window)
        {
            Hide();

            window.ShowDialog();

            ShowDialog();
        }

        private void viewStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            var studentsWindow = new StudentsWindow(_context);
            ShowWindow(studentsWindow);
        }

        private void viewTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            var teacherWindow = new TeachersWindow(_context);
            ShowWindow(teacherWindow);
        }

        private void viewDisciplinesButton_Click(object sender, RoutedEventArgs e)
        {
            var disciplineWindow = new DisciplinesWindow(_context);
            ShowWindow(disciplineWindow);
        }

        private void viewGroupsButton_Click(object sender, RoutedEventArgs e)
        {
            var groupsWindow = new GroupsWindow(_context);
            ShowWindow(groupsWindow);
        }

        private void viewSpecialtiesButton_Click(object sender, RoutedEventArgs e)
        {
            var specialtiesWindow = new SpecialtiesWindow(_context);
            ShowWindow(specialtiesWindow);
        }
    }
}
