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
    /// Interaction logic for StudentEditorWindow.xaml
    /// </summary>
    public partial class StudentEditorWindow : Window
    {
        Student _student;

        public StudentEditorWindow(Student student)
        {
            InitializeComponent();

            _student = student;

            image.Source = new BitmapImage(new Uri(student.Photo, UriKind.Relative));
            nameBlock.Text = _student.Name;
            surnameBlock.Text = _student.Surname;
            birthdayBlock.Text = _student.Birthday.ToString("d");
            listGenders.ItemsSource = new List<string> {"М", "Ж" };
        }
    }
}
