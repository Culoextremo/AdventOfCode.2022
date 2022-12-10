using System;
using AdventOfCode_2022;
using AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._02._Rock_Paper_Scissors.Runtime.Domain;
using UnityEngine;

namespace AdventOfCode2022.RockPaperScissors.Runtime.Application
{
    public class Kata : MonoBehaviour
    {
        void Start()
        {
            var allText = Resources.Load<KataInput>("RockPaperScissorsInput").Text;

            PrintFirstPartResult(allText);
            PrintSecondPartResult(allText);
        }

        static void PrintFirstPartResult(string allText)
        {
            var league = DeserializeLeague(allText, new ShapesMatchDeserializer());
            Debug.Log("02. RockPaperScissors 1/2 Result : " + league.Result);
        }
        
        static void PrintSecondPartResult(string allText)
        {
            var league = DeserializeLeague(allText, new ExpectedResultMatchDeserializer());
            Debug.Log("02. RockPaperScissors 2/2 Result : " + league.Result);
        }

        static League DeserializeLeague(string allText, MatchDeserializer matchDeserializer)
        {
            var serializedMatches = allText.Split(Environment.NewLine);
            var league = new League();
            foreach (var serializedMatch in serializedMatches)
            {
                league.Add(matchDeserializer.Deserialize(serializedMatch));
            }

            return league;
        }
    }
}