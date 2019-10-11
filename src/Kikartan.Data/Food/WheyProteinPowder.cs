using Kikartan.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        public Guid Guid => Guid.NewGuid();
        public string Name { get; }
        public int Energy { get; }
        public int Carbohydrate { get; }
        public int Fat { get; }
        public int SaturatedFat { get; }
        public int Fiber { get; }
        public int Protein { get; }
        public bool Vegan { get; }
    }
}
