using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Models;
using UniversityManager.Views;

namespace UniversityManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


        }

        [STAThread]
        static void Main()
        {
            App app = new App();
            var context = new UniversityEntities();
            MainWindow window = new MainWindow(context);
            app.Run(window);
        }
    }
}
