using Models;
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

namespace UniversityManager.Views
{
    /// <summary>
    /// Interaction logic for DisciplinesWindow.xaml
    /// </summary>
    public partial class DisciplinesWindow : Window
    {
        UniversityEntities _context;

        public DisciplinesWindow(UniversityEntities context)
        {
            InitializeComponent();

            _context = context;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listDisciplines.ItemsSource = _context.TeacherDisciplines.ToList();
        }

        private void addDiscipline_Click(object sender, RoutedEventArgs e)
        {
            TeacherDiscipline discipline = null;
            Discipline currentDiscipline = null;

            var editor = new DisciplineEditorWindow(_context, discipline, currentDiscipline);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listDisciplines.ItemsSource = _context.TeacherDisciplines.ToList();

            ShowDialog();
        }

        private void listDisciplines_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listDisciplines.SelectedItem == null)
                return;

            var discipline = listDisciplines.SelectedItem as TeacherDiscipline;
            var currentDiscipline = discipline.Discipline;

            var editor = new DisciplineEditorWindow(_context, discipline, currentDiscipline);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listDisciplines.ItemsSource = _context.TeacherDisciplines.ToList();

            ShowDialog();
        }
    }
}
