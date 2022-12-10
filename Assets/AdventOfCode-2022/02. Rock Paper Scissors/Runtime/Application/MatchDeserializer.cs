using AdventOfCode2022.RockPaperScissors.Runtime.Domain;

namespace AdventOfCode2022.RockPaperScissors.Runtime.Application
{
    public interface MatchDeserializer
    {
        Match Deserialize(string serializedMatch);
    }
}