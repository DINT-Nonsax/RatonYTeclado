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

namespace RatonYTeclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            RightButton_textBox.Background = Brushes.Green;
        }
        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            RightButton_textBox.Background = Brushes.White;
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LeftButton_textBox.Background = Brushes.Green;
        }
        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LeftButton_textBox.Background = Brushes.White;
        }

        private void TextBox_1_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco_textBox.Text = "TextBox 1";
        }

        private void TextBox_2_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco_textBox.Text = "TextBox 2";
        }

        private void TextBox_3_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco_textBox.Text = "TextBox 3";
        }

        private void TextBox_1_LostFocus(object sender, RoutedEventArgs e)
        {
            Foco_textBox.Text = "";
        }

        private void TextBox_2_LostFocus(object sender, RoutedEventArgs e)
        {
            Foco_textBox.Text = "";
        }

        private void TextBox_3_LostFocus(object sender, RoutedEventArgs e)
        {   
            Foco_textBox.Text = "";
        }

        private void TextBox_1_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseOver_textBox.Text = "TextBox 1";
        }

        private void TextBox_2_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseOver_textBox.Text = "TextBox 2";
        }

        private void TextBox_3_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseOver_textBox.Text = "TextBox 3";
        }

        private void TextBox_1_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseOver_textBox.Text = "";
        }

        private void TextBox_2_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseOver_textBox.Text = "";
        }

        private void TextBox_3_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseOver_textBox.Text = "";
        }

        private void TextBox_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.E || e.Key == Key.A || e.Key == Key.I || e.Key == Key.O || e.Key == Key.U)
                textBox_3.IsReadOnly = true;
            else
                textBox_3.IsReadOnly = false;

        }

        private void TextBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                textBox_2.Text = "AIUDA!!!!";
        }
    }
}
