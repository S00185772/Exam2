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

namespace Exam2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward
    }
    
    public partial class MainWindow : Window
    {
        public List<Player> allPlayers = new List<Player>();
        public List<Player> selectedPlayers = new List<Player>();
        public  Random rnd = new Random();
        int spaces = 11;
        DateTime today = new DateTime(2019, 12, 11);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Player p1 = new Player("John", "Ross", Position.Goalkeeper, new DateTime(1998, 6, 2), 21);
            Player p2 = new Player("Ross", "Ross", Position.Goalkeeper, new DateTime(1998, 6, 2), 21);

            Player p3 = new Player("John", "West", Position.Defender, new DateTime(1993, 6, 2), 27);
            Player p4 = new Player("Ana", "Cross", Position.Defender, new DateTime(1991, 6, 2), 29);
            Player p5 = new Player("Westfield", "Upper", Position.Defender, new DateTime(1994, 6, 2), 26);
            Player p6 = new Player("Jordan", "Wallet", Position.Defender, new DateTime(1998, 6, 2), 21);
            Player p7 = new Player("Case", "phone", Position.Defender, new DateTime(1996, 6, 2), 24);
            Player p8 = new Player("Phone", "Screen", Position.Defender, new DateTime(1991, 1, 2), 29);

            Player p9 = new Player("Adam", "Cole", Position.Midfielder, new DateTime(1998, 6, 2), 21);
            Player p10 = new Player("Chole", "Mia", Position.Midfielder, new DateTime(1991, 6, 9), 29);
            Player p11 = new Player("Ryan", "Co", Position.Midfielder, new DateTime(1991, 1, 30), 29);
            Player p12 = new Player("Grace", "Doyle", Position.Midfielder, new DateTime(1998, 6, 2), 21);
            Player p13 = new Player("Emma", "Lynch", Position.Midfielder, new DateTime(1996, 6, 2), 24);
            Player p14 = new Player("Noah", "Walsh", Position.Midfielder, new DateTime(1994, 6, 10), 26);

            Player p15 = new Player("Rogue","Launcher",Position.Forward, new DateTime(1991, 8, 2), 29);
            Player p16 = new Player("Tyrone", "White", Position.Forward, new DateTime(1996, 2, 2), 24);
            Player p17 = new Player("George", "Proud", Position.Forward, new DateTime(1998, 5, 2), 21);
            Player p18 = new Player("Ricardo", "Loco", Position.Forward, new DateTime(1994, 6, 10), 26);

            allPlayers.Add(p1);
            allPlayers.Add(p2);
            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);
            allPlayers.Add(p6);
            allPlayers.Add(p7);
            allPlayers.Add(p8);
            allPlayers.Add(p9);
            allPlayers.Add(p10);
            allPlayers.Add(p11);
            allPlayers.Add(p12);
            allPlayers.Add(p13);
            allPlayers.Add(p14);
            allPlayers.Add(p15);
            allPlayers.Add(p16);
            allPlayers.Add(p17);
            allPlayers.Add(p18);
            








        }

        private void LbxAllPlayers_Loaded(object sender, RoutedEventArgs e)
        {
            lbxAllPlayers.ItemsSource = allPlayers;

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPlayer = lbxAllPlayers.SelectedItem as Player;

            if (spaces > 0)
            {
                if (selectedPlayer != null)
                {
                    allPlayers.Remove(selectedPlayer);
                    selectedPlayers.Add(selectedPlayer);

                    lbxAllPlayers.ItemsSource = null;
                    lbxAllPlayers.ItemsSource = allPlayers;

                    lbxSelectedPlayers.ItemsSource = null;
                    lbxSelectedPlayers.ItemsSource = selectedPlayers;
                    spaces -= 1;

                }
            }
            TblkSpace.Text = spaces.ToString();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPlayer = lbxSelectedPlayers.SelectedItem as Player;

            if (selectedPlayer != null)
            {
                allPlayers.Add(selectedPlayer);
                selectedPlayers.Remove(selectedPlayer);

                lbxAllPlayers.ItemsSource = null;
                lbxAllPlayers.ItemsSource = allPlayers;

                lbxSelectedPlayers.ItemsSource = null;
                lbxSelectedPlayers.ItemsSource = selectedPlayers;

                spaces += 1;
            }
        }

        private void TblkSpace_Loaded(object sender, RoutedEventArgs e)
        {
            TblkSpace.Text = spaces.ToString();
        }

        private void CbFormation_Initialized(object sender, EventArgs e)
        {
            string[] f = { "4-4-2", "4-3-3", "4-5-1" };

           
            CbFormation.ItemsSource = f ;
            
        }
    }
}

