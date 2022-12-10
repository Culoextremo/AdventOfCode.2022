using System.Collections.Generic;
using System.Linq;
using RGV.DesignByContract.Runtime;

namespace AdventOfCode2022.RucksackReorganization.Runtime.Domain.AdventOfCode_2022._03._Rucksack_Reorganization.Runtime.Domain
{
    public class Group
    {
        public Item Badge { get; }
        public int TotalValue { get; }
        public Group(IEnumerable<Rucksack> rucksacks)
        {
            Contract.Require(rucksacks).Not.Null();
            Contract.Require(rucksacks).Not.Empty();
            
            TotalValue = rucksacks.Sum(x => x.RepeatedItem);
            
            Badge = rucksacks
                .Select(x => x.Items)
                .Aggregate((xs, ys) => xs.Intersect(ys))
                .First();
        }
    }
}