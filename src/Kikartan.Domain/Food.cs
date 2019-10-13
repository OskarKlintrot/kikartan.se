using System;

namespace Kikartan.Domain
{
    public class Food
    {
        public Food(
            string name,
            int max,
            int step,
            Nutrients nutrients)
        {
            Name = name;
            Guid = Guid.NewGuid();
            Max = max;
            Step = step;

            Nutrients = nutrients;
        }

        public Guid Guid { get; }
        public string Name { get; }
        public int Max { get; }
        public int Step { get; }

        public Nutrients Nutrients { get; }
    }
}
