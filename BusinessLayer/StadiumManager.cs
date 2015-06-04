using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class StadiumManager
    {
        public IList<string> GetStadiums()
        {
            IStadiumManager stadiumManager = new StadiumStubManager();
            List<IStadium> stadiums = stadiumManager.GetStadiums();
            List<string> stringStadiums = new List<string>();
            foreach (IStadium stadium in stadiums)
            {
                stringStadiums.Add(stadium.ToString());
            }
            return stringStadiums;
        }
    }
}
