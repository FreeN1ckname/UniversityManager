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
    /// Interaction logic for SpecialtyEditorWindow.xaml
    /// </summary>
    public partial class SpecialtyEditorWindow : Window
    {
        Specialty _specialty;
        bool specialtyWasNull = false;
        UniversityEntities _context;

        public SpecialtyEditorWindow(UniversityEntities context, Specialty specialty)
        {
            InitializeComponent();

            _specialty = specialty;
            _context = context;

            if (_specialty == null)
            {
                _specialty = new Specialty();
                specialtyWasNull = true;
                deleteButton.Visibility = Visibility.Hidden;

                return;
            }

            nameBox.Text = _specialty.Name;
            codeBox.Text = _specialty.Code;
            infoBox.Text = _specialty.Info;
        }

        private bool CheckFields()
        {
            if (nameBox.Text == null ||
                codeBox == null ||
                infoBox == null)
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

            _specialty.Name = nameBox.Text;
            _specialty.Code = codeBox.Text;
            _specialty.Info = infoBox.Text;

            if (specialtyWasNull)
                _context.Specialties.Add(_specialty);
            else
                _context.Entry(_specialty).State = EntityState.Modified;

            _context.SaveChanges();

            DialogResult = true;
        }

        private void rejectButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            _context.Entry(_specialty).State = EntityState.Deleted;
            _context.SaveChanges();

            DialogResult = true;
        }
    }
}
