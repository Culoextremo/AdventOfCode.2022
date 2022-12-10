namespace AdventOfCode2022.RockPaperScissors.Runtime.Domain
{
    public struct Shape
    {
        Shape(int scoreValue)
        {
            ScoreValue = scoreValue;
        }

        public int ScoreValue { get; }

        public static Shape Rock => new(scoreValue: 1);
        public static Shape Paper => new(scoreValue: 2);
        public static Shape Scissors => new(scoreValue: 3);
    }
}