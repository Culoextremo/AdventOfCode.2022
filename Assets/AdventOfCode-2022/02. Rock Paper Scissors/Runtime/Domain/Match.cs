namespace AdventOfCode2022.RockPaperScissors.Runtime.Domain
{
    public class Match
    {
        public Match(Shape player, Shape rival)
        {
            Result = player.ScoreValue;
            if (PlayerWins(player, rival))
            {
                Result += 6;
            }

            if (player.Equals(rival))
            {
                Result += 3;
            }
        }
        static bool PlayerWins(Shape player, Shape rival)
        {
            return (player.Equals(Shape.Rock) && rival.Equals(Shape.Scissors))
                   || (player.Equals(Shape.Paper) && rival.Equals(Shape.Rock))
                   || (player.Equals(Shape.Scissors) && rival.Equals(Shape.Paper));
        }

        public int Result { get; }
    }
}