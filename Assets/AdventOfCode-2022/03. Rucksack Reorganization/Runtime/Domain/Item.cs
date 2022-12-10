namespace AdventOfCode2022.RucksackReorganization.Runtime.Domain
{
    public struct Item
    {
        readonly int priority;
        public Item(int priority) => this.priority = priority;

        public static implicit operator int(Item meal) => meal.priority;
    }
}