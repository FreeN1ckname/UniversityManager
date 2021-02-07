using Microsoft.Win32;
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
using UniversityManager.Converters;

namespace UniversityManager.Views
{
    /// <summary>
    /// Interaction logic for StudentEditorWindow.xaml
    /// </summary>
    public partial class StudentEditorWindow : Window
    {
        Student _student;
        bool studentWasNull = false;

        UniversityEntities _context;

        public StudentEditorWindow(UniversityEntities context, Student student)
        {
            InitializeComponent();

            _context = context;
            _student = student;

            birthdayPicker.SelectedDate = new DateTime(2001,1,1);
            listGenders.ItemsSource = new List<string> {"М", "Ж" };
            listGroups.ItemsSource = context.Groups.ToList();

            if (_student == null)
            {
                _student = new Student();
                studentWasNull = true;
                deleteButton.Visibility = Visibility.Hidden;

                return;
            }

            image.Source = new BitmapImage(new Uri(student.Photo, UriKind.RelativeOrAbsolute));
            nameBlock.Text = _student.Name;
            surnameBlock.Text = _student.Surname;
            birthdayPicker.Text = _student.Birthday.ToString("d");

            listGenders.SelectedItem = _student.Gender;
            listGroups.SelectedItem = _student.Group;
        }

        private bool CheckFields()
        {
            if (nameBlock.Text == null ||
                surnameBlock == null ||
                listGroups.SelectedItem == null ||
                image.Source == null ||
                birthdayPicker.SelectedDate == null)
            {
                MessageBox.Show("Все поля должны быть заполнены! Повторите попытку.");
                return false;
            }

            return true;
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckFields())
                return;

            _student.Name = nameBlock.Text;
            _student.Surname = surnameBlock.Text;
            _student.Gender = listGenders.Text;
            _student.Birthday = birthdayPicker.SelectedDate.Value;
            var group = listGroups.SelectedItem as Group;
            _student.GroupId = group.Id;
            _student.Photo = image.Source.ToString();


            if (studentWasNull)
                _context.Students.Add(_student);
            else
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

        private void image_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void image_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void changePhotoButton_Click(object sender, RoutedEventArgs e)
        {
            var dialogPhoto = new OpenFileDialog();

            if (dialogPhoto.ShowDialog() == true)
            {
                var converter = new ImageConverter(dialogPhoto.FileName);
                converter.LoadImage();
                var photoPath = converter.GetRelativePath();

                image.Source = new BitmapImage(new Uri(photoPath, UriKind.RelativeOrAbsolute));
            }
        }
    }
}
