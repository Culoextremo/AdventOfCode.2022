using System.Collections.Generic;
using AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._03._Rucksack_Reorganization.Runtime.Domain;
using AdventOfCode2022.RucksackReorganization.Runtime.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2022.RucksackReorganization.Tests.Editor
{
    public class RucksackTests
    {
        [Test]
        public void RepeatedItem()
        {
            var sut = new Rucksack(new List<Item>()
                { 
                    new(1), new(3), 
                    new(1), new(2)
                });
            sut.RepeatedItem.Should().Be(new Item(1));
        }

        [Test]
        public void RepeatedItemsSum()
        {
            var sut = new Storage(new List<Rucksack>()
            {
                new Rucksack(new List<Item>()
                {
                    new(1), new(3),
                    new(1), new(2)
                }),

                new Rucksack(new List<Item>()
                {
                    new(2), new(3),
                    new(1), new(2)
                })
            });
            
            sut.TotalPriority.Should().Be(3);
        }
    }
}