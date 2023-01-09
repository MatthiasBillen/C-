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

namespace werkpleklerenoef1
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
        string[] kaart;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // if()
            {
                StandEnable();
            }
        }
        private bool StandEnable()
        {
            BtnHit.IsEnabled = false;
            BtnDeel.IsEnabled = false;
            return true;
        }

        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {
            RandomKaarten();
        }
        string[,] kaarten;
        int[] nummers;
        private void Kaarten()
        {
            nummers = new int[12];
            nummers[0] = 1;
            nummers[1] = 2;
            nummers[2] = 3;
            nummers[3] = 4;
            nummers[4] = 5;
            nummers[5] = 6;
            nummers[6] = 7;
            nummers[7] = 8;
            nummers[8] = 9;
            nummers[9] = 10;
            kaarten = new string[4, 4];
            kaarten[0, 0] = "spade";
            kaarten[1, 0] = "hart";
            kaarten[2, 0] = "claaver";
            kaarten[3, 0] = "ruit";
            kaarten[3, 1] = "boer";
            kaarten[3, 2] = "koningin";
            kaarten[3, 3] = "koning";
        }
        private void RandomKaarten()
        {

            Kaarten();
            Random random = new System.Random();
            random.Next(1, 13);
            int krt = random.Next(1, 13);


            for (int i = 0; i < 2; i++)
            {
                TxtBlox1.Text = string[Kaarten, i];
            }
            //Kaarten(krt);


        }

    }
}

