using System.Collections.Generic;
using System.Linq;
using AdventOfCode2022.RockPaperScissors.Runtime.Domain;

namespace AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._02._Rock_Paper_Scissors.Runtime.Domain
{
    public class League 
    {
        readonly IList<Match> matches = new List<Match>();

        public void Add(Match match)
        {
            matches.Add(match);
        }
        
        public int Result => matches.Sum(x => x.Score);
    }
}