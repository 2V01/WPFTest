using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskWindows
{
    public partial class TaskWindowSec : Window
    {
        public string ViewModel { get; set; }
        public TaskWindowSec()
        {
            InitializeComponent();

        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
