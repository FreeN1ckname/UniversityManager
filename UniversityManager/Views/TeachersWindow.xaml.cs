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
using Models;

namespace UniversityManager.Views
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        UniversityEntities _context;

        public TeachersWindow(UniversityEntities context)
        {
            InitializeComponent();

            _context = context;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listTeachers.ItemsSource = _context.Teachers.ToList();
        }

        private void listTeachers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listTeachers.SelectedItem == null)
                return;

            var teacher = listTeachers.SelectedItem as Teacher;
            var editor = new TeacherEditorWindow(_context, teacher);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listTeachers.ItemsSource = _context.Teachers.ToList();

            ShowDialog();
        }

        private void addTeacher_Click(object sender, RoutedEventArgs e)
        {
            Teacher teacher = null;
            var editor = new TeacherEditorWindow(_context, teacher);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listTeachers.ItemsSource = _context.Teachers.ToList();

            ShowDialog();
        }
    }
}
