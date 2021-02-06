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
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        UniversityEntities _context;

        public StudentsWindow(UniversityEntities context)
        {
            InitializeComponent();

            _context = context;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listStudents.ItemsSource = _context.Students.ToList();
        }

        private void listStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listStudents.SelectedItem == null)
                return;

            var student = listStudents.SelectedItem as Student;
            var editor = new StudentEditorWindow(_context, student);

            Hide();
            editor.ShowDialog();

            if(editor.DialogResult == true)
                listStudents.ItemsSource = _context.Students.ToList();

            ShowDialog();
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = null;
            var editor = new StudentEditorWindow(_context, student);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listStudents.ItemsSource = _context.Students.ToList();

            ShowDialog();
        }
    }
}
