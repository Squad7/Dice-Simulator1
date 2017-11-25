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
    /// Interaction logic for Dice_1.xaml
    /// </summary>
    public partial class Dice_1 : Page
    {
        public Dice_1()
        {
            InitializeComponent();
        }

        //Generates a random number which connects to a case and displays text and image dice for Dice 2
        private void GetAnswer(int Rand)
        {
            switch (Rand)
            {
                case 0:
                    DiceResultNUM.Text = "1";
                    DiceResultIMG.Source = new BitmapImage(new Uri("Resources/Dice num 1.png", UriKind.Relative));
                     break;

                case 1:
                    DiceResultNUM.Text = "2";
                    DiceResultIMG.Source = new BitmapImage(new Uri("Resources/Dice num 2.png", UriKind.Relative));
                    break;

                case 2:
                    DiceResultNUM.Text = "3";
                    DiceResultIMG.Source = new BitmapImage(new Uri("Resources/Dice num 3.png", UriKind.Relative));
                    break;

                case 3:
                    DiceResultNUM.Text = "4";
                    DiceResultIMG.Source = new BitmapImage(new Uri("Resources/Dice num 4.png", UriKind.Relative));
                    break;

                case 4:
                    DiceResultNUM.Text = "5";
                    DiceResultIMG.Source = new BitmapImage(new Uri("Resources/Dice num 5.png", UriKind.Relative));
                    break;

                case 5:
                    DiceResultNUM.Text = "6";
                    DiceResultIMG.Source = new BitmapImage(new Uri("Resources/Dice num 6.png", UriKind.Relative));
                    break;
            }

        }

        //Generates a random number
        private int Randomizer(int range)
        {

            Random ranObject = new Random();

            int ranNum = ranObject.Next(range);

            return ranNum;
        }

        //Generates random dice answer when clicked
        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            //Runs GetAnswer with the range of 6 for the Randomizor 
            GetAnswer(Randomizer(6));
        }
    }
}
