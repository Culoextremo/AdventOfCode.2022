using System.Collections.Generic;
using System.Linq;
using AdventOfCode2022.RucksackReorganization.Runtime.Domain;
using AdventOfCode2022.RucksackReorganization.Runtime.Domain.AdventOfCode_2022._03._Rucksack_Reorganization.Runtime.Domain;
using RGV.DesignByContract.Runtime;

namespace AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._03._Rucksack_Reorganization.Runtime.Domain
{
    public class Storage
    {
        public int TotalPriority => groups.Sum(x => x.TotalValue);
        public int TotalBadgesPriority => groups.Sum(x => x.Badge);

        readonly Group[] groups;
        public Storage(IEnumerable<Rucksack> rucksacks, int groupSize = 1)
        {
            Contract.Require(rucksacks).Not.Null();
            Contract.Require(rucksacks).Not.Empty();
            
            groups = new Group[groupSize];
            
            groups = rucksacks
                .Select((x, index) => new { Key = index / groupSize, Value = x })
                .GroupBy(x => x.Key, x => x.Value)
                .Select(x => new Group(x))
                .ToArray();
        }
    }
}