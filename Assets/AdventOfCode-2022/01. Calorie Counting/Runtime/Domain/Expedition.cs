using System.Collections.Generic;
using System.Linq;
using AdventOfCode2022.CalorieCounting.Runtime.Domain;

namespace AdventOfCode2022.CalorieCounting.Runtime.Domain
{
    public class Expedition
    {
        readonly List<Elf> elves;

        public Expedition(IEnumerable<Elf> elves)
        {
            this.elves = elves.ToList();
        }

        public int MostNutritiousStash => elves.Max(x => x.StoredCalories);

        public int TopNutritiousStashes(int topSize) => 
            elves.OrderByDescending(x => x.StoredCalories)
                .Take(topSize)
                .Sum(x => x.StoredCalories);
    }
}