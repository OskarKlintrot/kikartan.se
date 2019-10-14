using System;

namespace Kikartan.Domain
{
    public class Food
    {
        public Food(
            Guid id,
            string name,
            int max,
            int step,
            Nutrients nutrients)
        {
            Name = name;
            Id = id;
            Max = max;
            Step = step;

            Nutrients = nutrients;
        }

        public Guid Id { get; }
        public string Name { get; }
        public int Max { get; }
        public int Step { get; }

        public Nutrients Nutrients { get; }
    }
}
