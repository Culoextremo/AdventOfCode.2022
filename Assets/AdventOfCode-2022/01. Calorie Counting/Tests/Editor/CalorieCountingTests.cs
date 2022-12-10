using System.Collections.Generic;
using AdventOfCode2022.CalorieCounting.Runtime.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2022.CalorieCounting.Tests.Editor
{
    public class CalorieCountingTests
    {
        [Test]
        public void SingleMeal()
        {
            var sut = new Elf();
            sut.Store(new Meal(500));

            sut.StoredCalories
                .Should().Be(500);
        }

        [Test]
        public void MultipleMeals()
        {
            var sut = new Elf();
            sut.Store(new Meal(500));
            sut.Store(new Meal(1000));

            sut.StoredCalories
                .Should().Be(1500);
        }

        [Test]
        public void MostNutritiousStash()
        {
            var someElf = new Elf();
            someElf.Store(new Meal(1000));
            var otherElf = new Elf();
            otherElf.Store(new Meal(200));
            otherElf.Store(new Meal(300));
            var expedition = new Expedition(new List<Elf>(){ someElf, otherElf });

            expedition.MostNutritiousStash
                .Should().Be(1000);
        }
        
        [Test]
        public void TopNutritiousStashes()
        {
            var elves = new List<Elf>() {new(), new(), new()};
            elves[0].Store(new Meal(100));
            elves[1].Store(new Meal(50));
            elves[2].Store(new Meal(20));

            var expedition = new Expedition(elves);

            expedition.TopNutritiousStashes(2)
                .Should().Be(150);
        }
    }
}