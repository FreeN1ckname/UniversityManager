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
    /// Логика взаимодействия для GroupEditorWindow.xaml
    /// </summary>
    public partial class GroupEditorWindow : Window
    {
        UniversityEntities _context;
        Group _group;
        bool groupWasNull = false;

        public GroupEditorWindow(UniversityEntities context, Group group)
        {
            InitializeComponent();

            _context = context;
            _group = group;

            yearFormationPicker.SelectedDate = new DateTime(2001, 1, 1);
            listSpecialties.ItemsSource = context.Specialties.ToList();

            if (_group == null)
            {
                _group = new Group();
                groupWasNull = true;
                deleteButton.Visibility = Visibility.Hidden;

                return;
            }

            nameBox.Text = _group.Name;
            yearFormationPicker.Text = _group.YearFormation.ToString("d");
            listSpecialties.SelectedItem = _group.Specialty;
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckFields())
                return;

            _group.Name = nameBox.Text;
            _group.YearFormation = yearFormationPicker.SelectedDate.Value.Year;
            var specialties = listSpecialties.SelectedItem as Specialty;
            _group.SpecialtyId = specialties.Id;


            if (groupWasNull)
                _context.Groups.Add(_group);
            else
                _context.Entry(_group).State = EntityState.Modified;

            _context.SaveChanges();

            DialogResult = true;
        }

        private void rejectButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            _context.Entry(_group).State = EntityState.Deleted;
            _context.SaveChanges();

            DialogResult = true;
        }

        private bool CheckFields()
        {
            if (nameBox.Text == null ||
                yearFormationPicker == null ||
                listSpecialties.SelectedItem == null)
            {
                MessageBox.Show("Все поля должны быть заполнены! Повторите попытку.");
                return false;
            }

            return true;
        }
    }
}
