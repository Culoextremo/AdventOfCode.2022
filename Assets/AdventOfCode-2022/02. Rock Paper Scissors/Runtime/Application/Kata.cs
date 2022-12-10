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
            var league = DeserializeLeague(allText);

            Debug.Log("02. RockPaperScissors 1/2 Result : " + league.Result);
        }

        static League DeserializeLeague(string allText)
        {
            var serializedMatches = allText.Split(Environment.NewLine);
            var league = new League();
            var matchDeserializer = new MatchDeserializer();
            foreach (var serializedMatch in serializedMatches)
            {
                league.Add(matchDeserializer.Deserialize(serializedMatch));
            }

            return league;
        }
    }
}