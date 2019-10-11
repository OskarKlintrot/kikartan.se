using System;
using Kikartan.Domain.Contracts;

namespace Kikartan.Data.Food
{
    public class WheyProteinPowder : INutrients
    {
        public WheyProteinPowder()
        {
            Name = "WheyProteinPowder";
            Energy = 384;
            Carbohydrate = 8;
            Fat = 6;
            SaturatedFat = 4;
            Fiber = 0;
            Protein = 74;
            Vegan = false;

            Guid = Guid.NewGuid();
            Max = 150;
            Step = 5;
        }

        public Guid Guid { get; }
        public string Name { get; }
        public int Energy { get; }
        public int Carbohydrate { get; }
        public int Fat { get; }
        public int SaturatedFat { get; }
        public int Fiber { get; }
        public int Protein { get; }
        public bool Vegan { get; }

        public int Max { get; }
        public int Step { get; }
    }
}
