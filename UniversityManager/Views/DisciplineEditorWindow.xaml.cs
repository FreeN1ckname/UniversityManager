using Models;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для DisciplineEditorWindow.xaml
    /// </summary>
    public partial class DisciplineEditorWindow : Window
    {
        UniversityEntities _context;
        TeacherDiscipline _discipline;
        Discipline _currentDiscipline;
        bool disciplineWasNull = false;
        bool currentDisciplineWasNull = false;

        public DisciplineEditorWindow(UniversityEntities context, TeacherDiscipline discipline, Discipline currentDiscipline)
        {
            InitializeComponent();

            _context = context;
            _discipline = discipline;
            _currentDiscipline = currentDiscipline;

            startAcademicYearPicker.SelectedDate = new DateTime(2001, 1, 1);
            endAcademicYearPicker.SelectedDate = new DateTime(2001, 1, 1);
            totalHoursBox.Text = "0";

            listGroups.ItemsSource = context.Groups.ToList();
            listTeachers.ItemsSource = context.Teachers.ToList();

            if (_discipline == null)
            {
                _discipline = new TeacherDiscipline();
                disciplineWasNull = true;

                _currentDiscipline = new Discipline();
                currentDisciplineWasNull = true;

                deleteButton.Visibility = Visibility.Hidden;

                return;
            }

            nameBox.Text = _discipline.Discipline.Name;
            codeBox.Text = _discipline.Discipline.Code;
            totalHoursBox.Text = _discipline.TotalHours.ToString();
            startAcademicYearPicker.Text = _discipline.AcademicYearStart.ToString("d");
            endAcademicYearPicker.Text = _discipline.AcademicYearEnd.ToString("d");

            listGroups.SelectedItem = _discipline.Group;
            listTeachers.SelectedItem = _discipline.Teacher;
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckFields())
                return;

            _currentDiscipline.Name = nameBox.Text;
            _currentDiscipline.Code = codeBox.Text;

            if (currentDisciplineWasNull)
                _context.Disciplines.Add(_currentDiscipline);
            else
                _context.Entry(_currentDiscipline).State = EntityState.Modified;

            var disciplineId = _context.SaveChanges();

            _discipline.DisciplineId = disciplineId;

            if (int.TryParse(totalHoursBox.Text, out int totalHours))
            {
                _discipline.TotalHours = totalHours;
            }
            else
            {
                MessageBox.Show("Некорректное значение! \n" +
                    "Введите количество часов в целочисленном формате.");
                return;
            }    

            _discipline.AcademicYearStart = startAcademicYearPicker.SelectedDate.Value.Year;
            _discipline.AcademicYearEnd = endAcademicYearPicker.SelectedDate.Value.Year;
            _discipline.GroupId = (listGroups.SelectedItem as Group).Id;
            _discipline.TeacherId = (listTeachers.SelectedItem as Teacher).Id;

            if (disciplineWasNull)
                _context.TeacherDisciplines.Add(_discipline);
            else
                _context.Entry(_discipline).State = EntityState.Modified;

            _context.SaveChanges();

            DialogResult = true;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            _context.Entry(_discipline).State = EntityState.Deleted;
            _context.SaveChanges();

            DialogResult = true;
        }

        private void rejectButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private bool CheckFields()
        {
            if (nameBox.Text == null ||
                codeBox == null ||
                listGroups.SelectedItem == null ||
                listTeachers.SelectedItem == null ||
                startAcademicYearPicker.Text == null ||
                endAcademicYearPicker.Text == null)
            {
                MessageBox.Show("Все поля должны быть заполнены! Повторите попытку.");
                return false;
            }

            return true;
        }
    }
}
