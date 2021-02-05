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
    /// Interaction logic for StudentEditorWindow.xaml
    /// </summary>
    public partial class StudentEditorWindow : Window
    {
        Student _student;

        UniversityEntities _context;

        public StudentEditorWindow(UniversityEntities context, Student student)
        {
            InitializeComponent();

            _context = context;
            _student = student;

            image.Source = new BitmapImage(new Uri(student.Photo, UriKind.Relative));
            nameBlock.Text = _student.Name;
            surnameBlock.Text = _student.Surname;
            birthdayPicker.Text = _student.Birthday.ToString("d");

            listGenders.ItemsSource = new List<string> {"М", "Ж" };
            listGenders.SelectedItem = _student.Gender;

            listGroups.ItemsSource = context.Groups.ToList();
            listGroups.SelectedItem = _student.Group;
        }


        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            _student.Name = nameBlock.Text;
            _student.Surname = surnameBlock.Text;
            _student.Gender = listGenders.Text;
            _student.Birthday = birthdayPicker.SelectedDate.Value;
            var group = listGroups.SelectedItem as Group;
            _student.GroupId = group.Id;

            _context.Entry(_student).State = EntityState.Modified;
            _context.SaveChanges();

            DialogResult = true;
        }

        private void rejectButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            _context.Entry(_student).State = EntityState.Deleted;
            _context.SaveChanges();

            DialogResult = true;
        }
    }
}
