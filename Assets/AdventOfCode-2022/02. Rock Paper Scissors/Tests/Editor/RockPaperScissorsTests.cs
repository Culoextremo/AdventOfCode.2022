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

            sut.Score
                .Should().Be(7);
        }

        [Test]
        public void ScissorsVsRock()
        {
            var sut = new Match(Scissors, Rock);

            sut.Score
                .Should().Be(3);
        }
        
        [Test]
        public void RockVsPaper()
        {
            var sut = new Match(Rock, Paper);

            sut.Score
                .Should().Be(1);
        }

        [Test]
        public void RockVsRock()
        {
            var sut = new Match(Rock, Rock);

            sut.Score
                .Should().Be(4);
        }

        [Test]
        public void PaperVsRock()
        {
            var sut = new Match(Paper, Rock);

            sut.Score
                .Should().Be(8);
        }
        
        [Test]
        public void ScissorsVsPaper()
        {
            var sut = new Match(Scissors, Paper);

            sut.Score
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

        [Test]
        public void DesiredResultIsDraw()
        {
            var sut = new Match(Rock, Result.Draw);

            sut.Should().BeEquivalentTo(new Match(Rock, Rock));
        }
        
        [Test]
        public void DesiredResultIsWin()
        {
            var sut = new Match(Rock, Result.Win);

            sut.Should().BeEquivalentTo(new Match(Paper, Rock));
        }
        
        [Test]
        public void DesiredResultIsLose()
        {
            var sut = new Match(Rock, Result.Lose);

            sut.Should().BeEquivalentTo(new Match(Scissors, Rock));
        }
    }
}