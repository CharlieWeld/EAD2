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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            myButton.Click += MyButton_Click;
            myButton.Click += MyButton_Click1;
        }

        private void MyButton_Click1(object sender, RoutedEventArgs e)
        {
            myLabel2.Content = "Label 2 is displayed";
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "You Pressed the Button";
        }

        private void Transferr(object sender, MouseEventArgs e)
        {
            myLabel2.Content = textBox.Text;
        }
    }
}
