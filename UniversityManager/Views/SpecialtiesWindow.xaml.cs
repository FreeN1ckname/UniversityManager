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
    /// Interaction logic for SpecialtiesWindow.xaml
    /// </summary>
    public partial class SpecialtiesWindow : Window
    {
        UniversityEntities _context;

        public SpecialtiesWindow(UniversityEntities context)
        {
            InitializeComponent();

            _context = context;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listSpecialties.ItemsSource = _context.Specialties.ToList();
        }

        private void addSpecialty_Click(object sender, RoutedEventArgs e)
        {
            Specialty specialty = null;
            var editor = new SpecialtyEditorWindow(_context, specialty);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listSpecialties.ItemsSource = _context.Specialties.ToList();

            ShowDialog();
        }

        private void listSpecialties_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listSpecialties.SelectedItem == null)
                return;

            var specialty = listSpecialties.SelectedItem as Specialty;
            var editor = new SpecialtyEditorWindow(_context, specialty);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listSpecialties.ItemsSource = _context.Specialties.ToList();

            ShowDialog();
        }
    }
}
