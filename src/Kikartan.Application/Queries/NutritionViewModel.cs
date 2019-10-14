using System;

namespace Kikartan.Application.Queries
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

    public class Nutrients
    {
        public int AmountInGram { get; }
        public int Energy { get; }
        public int Carbohydrate { get; }
        public int Fat { get; }
        public int SaturatedFat { get; }
        public int Fiber { get; }
        public int Protein { get; }
        public bool Vegan { get; }

        public Nutrients(
            int amount,
            int energy,
            int carbohydrate,
            int fat,
            int saturatedFat,
            int fiber,
            int protein,
            bool vegan)
        {
            AmountInGram = amount;
            Energy = energy;
            Carbohydrate = carbohydrate;
            Fat = fat;
            SaturatedFat = saturatedFat;
            Fiber = fiber;
            Protein = protein;
            Vegan = vegan;
        }

        public Nutrients ChangeAmount(int gram)
        {
            var factor = gram / Convert.ToDecimal(AmountInGram);

            return new Nutrients(
                gram,
                decimal.ToInt32(Energy * factor),
                decimal.ToInt32(Carbohydrate * factor),
                decimal.ToInt32(Fat * factor),
                decimal.ToInt32(SaturatedFat * factor),
                decimal.ToInt32(Fiber * factor),
                decimal.ToInt32(Protein * factor),
                Vegan);
        }
    }

}
