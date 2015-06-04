using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class MatchManager
    {
        public IEnumerable<string> GetMatchesOrderedByDate()
        {
            IMatchManager matchManager = new MatchStubManager();
            List<IMatch> matches = matchManager.GetMatches();
            IEnumerable<string> matchQuery = 
                from match in matches
                where match.MatchDate > DateTime.Now
                orderby match.MatchDate ascending
                select match.ToString();
            return matchQuery;
        }

        public string GetAvailablePlaces()
        {
            IMatchManager matchManager = new MatchStubManager();
            List<IMatch> matches = matchManager.GetMatches();
            List<ISpectator> spectators = new List<ISpectator>();

            IMatch match = matches[0];

            var placeQuery =
                from m in matches
                where m == match
                select m.Stadium.PlacesNumber - m.Spectators.Count;
            foreach (int placeNumber in placeQuery)
            {
                return placeNumber.ToString();
            }
            return "";
        }
    }
}
