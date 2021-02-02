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
        public TeachersWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var context = new UniversityEntities();

            listTeachers.ItemsSource = context.Teachers.ToList();
        }
    }
}
