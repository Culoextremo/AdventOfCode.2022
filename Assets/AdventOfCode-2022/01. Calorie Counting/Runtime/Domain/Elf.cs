using System.Collections.Generic;
using System.Linq;
using AdventOfCode2022.CalorieCounting.Runtime.Domain;

namespace AdventOfCode2022.CalorieCounting.Runtime.Domain
{
    public class Elf
    {
        readonly List<Meal> meals = new();

        public void Store(Meal meal)
        {
            this.meals.Add(meal);
        }

        public int StoredCalories => meals.Sum(x => x);
    }
}