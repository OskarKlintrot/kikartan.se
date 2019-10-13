using System;
using Kikartan.Domain;
using Kikartan.Domain.Contracts;

namespace Kikartan.Data.Food
{
    public class WheyProteinPowder : IFood
    {
        public WheyProteinPowder()
        {
            Name = "WheyProteinPowder";
            Guid = Guid.NewGuid();
            Max = 150;
            Step = 5;

            Nutrients = new Nutrients(
                energy: 384,
                carbohydrate: 8,
                fat: 6,
                saturatedFat: 4,
                fiber: 0,
                protein: 74,
                vegan: false);
        }

        public Guid Guid { get; }
        public string Name { get; }
        public int Max { get; }
        public int Step { get; }

        public INutrients Nutrients { get; }
    }
}
