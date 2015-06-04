using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BusinessLayer;

namespace QuidditchWP
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StadiumClicked(object sender, RoutedEventArgs e)
        {
            StadiumWindow stadiumWindow = new StadiumWindow();
            stadiumWindow.Show();
        }
    }

    public class Matchees : ObservableCollection<string>
    {
        public Matchees()
        {
            MatchManager matchManager = new MatchManager();
            IEnumerable<string> listMatch = matchManager.GetMatchesOrderedByDate();
            foreach (string match in listMatch)
            {
                Add(match);
            }
        }
    }
}
