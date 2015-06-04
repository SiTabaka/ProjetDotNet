using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfArtistesViewer.ViewModel;

namespace QuidditchWP
{
    public class Catcher : ViewModelBase
    {
        public Catcher(String nName)
        {
            Name = nName;
        }

        private String _name;
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
