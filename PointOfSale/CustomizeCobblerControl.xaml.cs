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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void Peach_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.Fruit = FruitFilling.Peach;
                Cobbler.Text = cobbler.ToString();
            }
        }

        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.Fruit = FruitFilling.Cherry;
                Cobbler.Text = cobbler.ToString();
            }
        }

        private void Blueberry_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.Fruit = FruitFilling.Blueberry;
                Cobbler.Text = cobbler.ToString();
            }
        }
    }
}
