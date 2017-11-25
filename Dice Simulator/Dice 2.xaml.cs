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
    /// Interaction logic for Dice_2.xaml
    /// </summary>
    public partial class Dice_2 : Page
    {
        public Dice_2()
        {
            InitializeComponent();
        }

        //Generates a random number which connects to a case and displays text and image dice for Dice 1
        private void GetAnswer(int Rand)
        {
            //Gets random number from randomizor 
            switch (Rand)
            {
                case 0:
                    Dice1Answer.Text = "1";
                    DiceResultIMG21.Source = new BitmapImage(new Uri("Resources/Dice num 1.png", UriKind.Relative));
                    break;

                case 1:
                    Dice1Answer.Text = "2";
                    DiceResultIMG21.Source = new BitmapImage(new Uri("Resources/Dice num 2.png", UriKind.Relative));
                    break;

                case 2:
                    Dice1Answer.Text = "3";
                    DiceResultIMG21.Source = new BitmapImage(new Uri("Resources/Dice num 3.png", UriKind.Relative));
                    break;

                case 3:
                    Dice1Answer.Text = "4";
                    DiceResultIMG21.Source = new BitmapImage(new Uri("Resources/Dice num 4.png", UriKind.Relative));
                    break;

                case 4:
                    Dice1Answer.Text = "5";
                    DiceResultIMG21.Source = new BitmapImage(new Uri("Resources/Dice num 5.png", UriKind.Relative));
                    break;

                case 5:
                    Dice1Answer.Text = "6";
                    DiceResultIMG21.Source = new BitmapImage(new Uri("Resources/Dice num 6.png", UriKind.Relative));
                    break;
            }

        }

        //Generates a random number which connects to a case and displays text and image dice for Dice 2
        private void GetAnswer2(int Rand)
        {
            //Gets random number from randomizor 
            switch (Rand)
            {
                case 0:
                    Dice2Answer.Text = "1";
                    DiceResultIMG22.Source = new BitmapImage(new Uri("Resources/Dice num 1.png", UriKind.Relative));
                    break;

                case 1:
                    Dice2Answer.Text = "2";
                    DiceResultIMG22.Source = new BitmapImage(new Uri("Resources/Dice num 2.png", UriKind.Relative));
                    break;

                case 2:
                    Dice2Answer.Text = "3";
                    DiceResultIMG22.Source = new BitmapImage(new Uri("Resources/Dice num 3.png", UriKind.Relative));
                    break;

                case 3:
                    Dice2Answer.Text = "4";
                    DiceResultIMG22.Source = new BitmapImage(new Uri("Resources/Dice num 4.png", UriKind.Relative));
                    break;

                case 4:
                    Dice2Answer.Text = "5";
                    DiceResultIMG22.Source = new BitmapImage(new Uri("Resources/Dice num 5.png", UriKind.Relative));
                    break;

                case 5:
                    Dice2Answer.Text = "6";
                    DiceResultIMG22.Source = new BitmapImage(new Uri("Resources/Dice num 6.png", UriKind.Relative));
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

        //Generates random dice answer for Dice 1 when clicked
        private void Roll2_Click_1(object sender, RoutedEventArgs e)
        {
            //Runs GetAnswer with the range of 6 for the Randomizor 
            GetAnswer(Randomizer(6));
        }

        //Generates random dice answer for Dice 2 when clicked
        private void Roll2_2_Click(object sender, RoutedEventArgs e)
        {
            //Runs GetAnswer with the range of 6 for the Randomizor 
            GetAnswer2(Randomizer(6));
        }

        //Calculates total from Dice 1 and Dice 2 answer
        private void TotalCalc()
        { 
            //The TotalTextBlock displays the sum of Dice1Answer + Dice2Answer
           TotalTextBlock.Text = (int.Parse(Dice1Answer.Text) + int.Parse(Dice2Answer.Text)).ToString();
        }

        //Displays total number if clicked
        private void TotalButton_Click(object sender, RoutedEventArgs e)
        {
            TotalCalc();
        }
    }
}
