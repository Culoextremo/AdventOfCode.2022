using System;
using AdventOfCode2022.RockPaperScissors.Runtime.Domain;

namespace AdventOfCode2022.RockPaperScissors.Runtime.Application
{
    public class ExpectedResultMatchDeserializer : MatchDeserializer
    {
        public Match Deserialize(string serializedMatch)
        {
            var serializedShapes = serializedMatch.Split(' ');
            return new Match(DeserializeShape(serializedShapes[0][0]), DeserializeResult(serializedShapes[1][0]));
        }

        static Shape DeserializeShape(char serializedShape)
        {
            return serializedShape switch
            {
                'A' => Shape.Rock,
                'B' => Shape.Paper,
                'C' => Shape.Scissors,
                _ => throw new ArgumentException()
            };
        }
        
        static Result DeserializeResult(char serializedShape)
        {
            return serializedShape switch
            {
                'X' => Result.Lose,
                'Y' => Result.Draw,
                'Z' => Result.Win,
                _ => throw new ArgumentException()
            };
        }
    }
}