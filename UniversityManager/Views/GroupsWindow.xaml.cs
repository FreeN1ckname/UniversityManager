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
    /// Interaction logic for GroupsWindow.xaml
    /// </summary>
    public partial class GroupsWindow : Window
    {
        UniversityEntities _context;

        public GroupsWindow(UniversityEntities context)
        {
            InitializeComponent();

            _context = context;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listGroups.ItemsSource = _context.Groups.ToList();
        }

        private void addGroup_Click(object sender, RoutedEventArgs e)
        {
            Group group = null;
            var editor = new GroupEditorWindow(_context, group);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listGroups.ItemsSource = _context.Groups.ToList();

            ShowDialog();
        }

        private void listGroups_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listGroups.SelectedItem == null)
                return;

            var group = listGroups.SelectedItem as Group;
            var editor = new GroupEditorWindow(_context, group);

            Hide();
            editor.ShowDialog();

            if (editor.DialogResult == true)
                listGroups.ItemsSource = _context.Groups.ToList();

            ShowDialog();
        }
    }
}
