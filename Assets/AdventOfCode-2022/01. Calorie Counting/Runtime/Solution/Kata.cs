using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCode_2022;
using AdventOfCode2022.CalorieCounting.Runtime.Domain;
using UnityEditor;
using UnityEngine;

namespace AdventOfCode2022.CalorieCounting.Runtime.Application
{
    public class Kata : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("01. CalorieCounting 1/2 Result : "+ CalcResult());
        }

        int CalcResult()
        {
            var allText = Resources.Load<KataInput>("CalorieCountingInput").Text;
            var expedition = DeserializeExpedition(allText);

            return expedition.MostNutritiousStash;
        }

        static Expedition DeserializeExpedition(string allText)
        {
            var serializedExpedition = allText.Split(
                new string[] {Environment.NewLine + Environment.NewLine},
                StringSplitOptions.RemoveEmptyEntries);

            var elves = new List<Elf>();
            foreach (var serializedElf in serializedExpedition)
            {
                var elf = DeserializeElf(serializedElf);
                elves.Add(elf);
            }

            var expedition = new Expedition(elves);
            return expedition;
        }

        static Elf DeserializeElf(string serializedElf)
        {
            var elf = new Elf();
            var serializedMeals = serializedElf.Split(Environment.NewLine);
            foreach (var meal in serializedMeals)
            {
                elf.Store(DeserializeMeal(meal));
            }

            return elf;
        }

        static Meal DeserializeMeal(string meal)
        {
            var calories = int.Parse(meal);
            return new Meal(calories);
        }
    }
}