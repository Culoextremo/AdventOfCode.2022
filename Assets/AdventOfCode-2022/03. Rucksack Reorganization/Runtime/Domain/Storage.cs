using System.Collections.Generic;
using System.Linq;
using AdventOfCode2022.RucksackReorganization.Runtime.Domain;
using RGV.DesignByContract.Runtime;

namespace AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._03._Rucksack_Reorganization.Runtime.Domain
{
    public class Storage
    {
        public int TotalPriority { get; }
        
        public Storage(IEnumerable<Rucksack> rucksacks)
        {
            Contract.Require(rucksacks).Not.Null();
            Contract.Require(rucksacks).Not.Empty();
            
            TotalPriority = rucksacks.Sum(x => x.RepeatedItem);
        }
    }
}