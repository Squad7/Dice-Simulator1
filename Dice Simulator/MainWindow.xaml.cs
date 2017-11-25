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


namespace Dice_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Changes MainFrame to the Dice 1 page & Displays BackButton
        private void DiceButton1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dice_1();
            BackButton.Visibility = Visibility;
            MainFrame.Visibility = Visibility.Visible;
            
        }

        //Changes MainFrame to the Dice 2 page & Displays BackButton
        private void DiceButton2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dice_2();
            BackButton.Visibility = Visibility;
            MainFrame.Visibility = Visibility.Visible;

        }

        //Changes MainFrame back to landing page
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility;
            MainFrame.Visibility = Visibility.Hidden;
        }

    }
}
