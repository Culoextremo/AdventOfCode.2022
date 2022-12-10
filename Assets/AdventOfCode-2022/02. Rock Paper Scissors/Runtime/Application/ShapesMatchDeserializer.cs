using System;
using System.Text.RegularExpressions;
using AdventOfCode2022.RockPaperScissors.Runtime.Domain;
using Match = AdventOfCode2022.RockPaperScissors.Runtime.Domain.Match;

namespace AdventOfCode2022.RockPaperScissors.Runtime.Application
{
    public class ShapesMatchDeserializer : MatchDeserializer
    {
        public Match Deserialize(string serializedMatch)
        {
            var serializedShapes = serializedMatch.Split(' ');
            return new Match(DeserializeShape(serializedShapes[0][0]), DeserializeShape(serializedShapes[1][0]));
        }

        static Shape DeserializeShape(char serializedShape)
        {
            return serializedShape switch
            {
                'A' or 'X' => Shape.Rock,
                'B' or 'Y' => Shape.Paper,
                'C' or 'Z' => Shape.Scissors,
                _ => throw new ArgumentException()
            };
        }
    }
}