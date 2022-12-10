using System.Collections.Generic;
using System.Linq;
using RGV.DesignByContract.Runtime;

namespace AdventOfCode2022.RucksackReorganization.Runtime.Domain
{
    public class Rucksack
    {
        readonly Item[] firstCompartment;
        readonly Item[] secondCompartment;

        public IEnumerable<Item> Items => firstCompartment.Concat(secondCompartment);
        public Rucksack(IEnumerable<Item> items)
        {
            Contract.Require(items.Count() % 2).Zero();

            firstCompartment = items.Take(items.Count() / 2).ToArray();
            secondCompartment = items.Skip(items.Count() / 2).ToArray();
        }

        public Item RepeatedItem => firstCompartment.First(x => secondCompartment.Contains(x));
    }
}