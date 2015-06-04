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
using System.Windows.Shapes;
using BusinessLayer;

namespace QuidditchWP
{
    public partial class CatcherWindow : Window
    {
        ObservableCollection<Catcher> catchers;

        public CatcherWindow()
        {
            InitializeComponent();
            PlayerManager playerManager = new PlayerManager();
            IEnumerable<string> listCatcher = playerManager.GetCatchers();

            catchers = new ObservableCollection<Catcher>();
            
            foreach (string catcher in listCatcher)
            {
                catchers.Add(new Catcher(catcher));
            }

            this.DataContext = catchers;
        }
    }
}
