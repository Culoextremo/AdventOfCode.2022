using System;
using static AdventOfCode2022.RockPaperScissors.Runtime.Domain.Shape;

namespace AdventOfCode2022.RockPaperScissors.Runtime.Domain
{
    public class Match
    {
        public Match(Shape player, Shape rival)
        {
            Score = player.ScoreValue;
            if (PlayerWins(player, rival))
            {
                Score += 6;
            }

            if (player.Equals(rival))
            {
                Score += 3;
            }
        }

        public Match(Shape rival, Result result) : this(DesiredPlay(rival, result), rival) { }

        static Shape DesiredPlay(Shape rival, Result result)
        {
            return result switch
            {
                Result.Draw => rival,
                Result.Win => VictoriousPlayAgainst(rival),
                Result.Lose => LoserPlayAgainst(rival),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        static Shape LoserPlayAgainst(Shape shape) => VictoriousPlayAgainst(VictoriousPlayAgainst(shape));

        static Shape VictoriousPlayAgainst(Shape rival)
        {
            if (rival.Equals(Rock))
                return Paper;
            if (rival.Equals(Paper))
                return Scissors;
            return Rock;
        }

        static bool PlayerWins(Shape player, Shape rival)
        {
            return (player.Equals(Rock) && rival.Equals(Scissors))
                   || (player.Equals(Paper) && rival.Equals(Rock))
                   || (player.Equals(Scissors) && rival.Equals(Paper));
        }

        public int Score { get; }
    }
}