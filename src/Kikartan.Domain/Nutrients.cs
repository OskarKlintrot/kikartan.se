using System;

namespace Kikartan.Domain
{
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
            decimal carbohydrate,
            decimal fat,
            decimal saturatedFat,
            decimal fiber,
            decimal protein,
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
                Fat * factor,
                SaturatedFat * factor,
                Fiber * factor,
                Protein * factor,
                Vegan);
        }
    }
}
