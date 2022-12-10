using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode_2022;
using AdventOfCode2022.RockPaperScissors.Tests.AdventOfCode_2022._03._Rucksack_Reorganization.Runtime.Domain;
using UnityEngine;

namespace AdventOfCode2022.RucksackReorganization.Runtime.Domain
{
    public class Kata : MonoBehaviour
    {
        void Start()
        {
            var allText = Resources.Load<KataInput>("RucksackReorganizationInput").Text;
            var storage = DeserializeStorage(allText);
            ShowFirstPartResult(storage);
        }

        void ShowFirstPartResult(Storage storage) => 
            Debug.Log("03. Rucksack Reorganization 1/2 Result : " + storage.TotalPriority);

        static Storage DeserializeStorage(string allText)
        {
            var serializedExpedition = allText.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var rucksacks = new List<Rucksack>();
            foreach (var serializedElf in serializedExpedition)
            {
                var elf = DeserializeRucksack(serializedElf);
                rucksacks.Add(elf);
            }

            var storage = new Storage(rucksacks);
            return storage;
        }

        static Rucksack DeserializeRucksack(string serializedRucksack)
        {
            var items = serializedRucksack.Select(item => DeserializeItem(item)).ToList();

            return new Rucksack(items);
        }

        static Item DeserializeItem(char item)
        {
            var priority = item < 91 ? item - 38 : item - 96;
            return new Item(priority);
        }
    }
}
