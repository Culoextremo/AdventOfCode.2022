namespace AdventOfCode2022.CalorieCounting.Runtime.Domain
{
    public struct Meal
    {
        readonly int calories;
        public Meal(int calories) => this.calories = calories;

        public static implicit operator int(Meal meal) => meal.calories;
    }
}