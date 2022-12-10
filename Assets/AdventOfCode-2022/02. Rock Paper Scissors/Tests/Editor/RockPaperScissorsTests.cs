using System.Collections.Generic;
using AdventOfCode2022.RockPaperScissors.Runtime.Domain;
using AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._02._Rock_Paper_Scissors.Runtime.Domain;
using FluentAssertions;
using NUnit.Framework;
using static AdventOfCode2022.RockPaperScissors.Runtime.Domain.Shape;

namespace AdventOfCode2022.RockPaperScissors.Tests
{
    public class RockPaperScissorsTests
    {
        [Test]
        public void RockVsScissors()
        {
            var sut = new Match(Rock, Scissors);

            sut.Result
                .Should().Be(7);
        }

        [Test]
        public void ScissorsVsRock()
        {
            var sut = new Match(Scissors, Rock);

            sut.Result
                .Should().Be(3);
        }
        
        [Test]
        public void RockVsPaper()
        {
            var sut = new Match(Rock, Paper);

            sut.Result
                .Should().Be(1);
        }

        [Test]
        public void RockVsRock()
        {
            var sut = new Match(Rock, Rock);

            sut.Result
                .Should().Be(4);
        }

        [Test]
        public void PaperVsRock()
        {
            var sut = new Match(Paper, Rock);

            sut.Result
                .Should().Be(8);
        }
        
        [Test]
        public void ScissorsVsPaper()
        {
            var sut = new Match(Scissors, Paper);

            sut.Result
                .Should().Be(9);
        }

        [Test]
        public void LeagueResult()
        {
            var sut = new League();
            sut.Add(new Match(Rock, Paper));
            sut.Add(new Match(Paper, Scissors));
            sut.Add(new Match(Scissors, Paper));

            sut.Result
                .Should().Be(12);
        }
    }
}