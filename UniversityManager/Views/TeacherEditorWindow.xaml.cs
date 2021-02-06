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
    /// Interaction logic for TeacherEditorWindow.xaml
    /// </summary>
    public partial class TeacherEditorWindow : Window
    {
        Teacher _teacher;
        bool teacherWasNull;
        UniversityEntities _context;

        public TeacherEditorWindow(UniversityEntities context, Teacher teacher)
        {
            InitializeComponent();

            _context = context;
            _teacher = teacher;

            startYearPicker.SelectedDate = new DateTime(2001, 1, 1);

            if (_teacher == null)
            {
                _teacher = new Teacher();
                teacherWasNull = true;
                deleteButton.Visibility = Visibility.Hidden;

                return;
            }

            image.Source = new BitmapImage(new Uri(teacher.Photo, UriKind.RelativeOrAbsolute));
            nameBlock.Text = _teacher.Name;
            surnameBlock.Text = _teacher.Surname;
            startYearPicker.Text = _teacher.StartYear.ToString("d");
        }

        private bool CheckFields()
        {
            if (nameBlock.Text == null ||
                surnameBlock == null ||
                image.Source == null ||
                startYearPicker.SelectedDate == null)
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

            _teacher.Name = nameBlock.Text;
            _teacher.Surname = surnameBlock.Text;
            _teacher.StartYear = startYearPicker.SelectedDate.Value.Year;
            _teacher.Photo = image.Source.ToString();


            if (teacherWasNull)
                _context.Teachers.Add(_teacher);
            else
                _context.Entry(_teacher).State = EntityState.Modified;

            _context.SaveChanges();

            DialogResult = true;
        }

        private void rejectButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            _context.Entry(_teacher).State = EntityState.Deleted;
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
