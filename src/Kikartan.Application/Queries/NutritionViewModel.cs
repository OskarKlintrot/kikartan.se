using System;

namespace Kikartan.Application.Queries
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

    public class Nutrients
    {
        public int AmountInGram { get; }
        public int Energy { get; }
        public decimal Carbohydrate { get; }
        public decimal Fat { get; }
        public decimal SaturatedFat { get; }
        public decimal Fiber { get; }
        public decimal Protein { get; }
        public bool Vegan { get; }

        public Nutrients(
            int amount,
            int energy,
            decimal fat,
            decimal saturatedFat,
            decimal carbohydrate,
            decimal fiber,
            decimal protein,
            bool vegan)
        {
            AmountInGram = amount;
            Energy = energy;
            Fat = fat;
            SaturatedFat = saturatedFat;
            Carbohydrate = carbohydrate;
            Fiber = fiber;
            Protein = protein;
            Vegan = vegan;
        }

        public Nutrients ChangeAmount(int gram)
        {
            var factor = gram / Convert.ToDecimal(AmountInGram);

            return new Nutrients(
                amount: gram,
                energy: decimal.ToInt32(Energy * factor),
                fat: Fat * factor,
                saturatedFat: SaturatedFat * factor,
                carbohydrate: Carbohydrate * factor,
                fiber: Fiber * factor,
                protein: Protein * factor,
                vegan: Vegan);
        }
    }

}
