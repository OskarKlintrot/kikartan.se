using Kikartan.Domain.Contracts;

namespace Kikartan.Domain
{
    public class Nutrients : INutrients
    {
        public int Energy { get; }
        public int Carbohydrate { get; }
        public int Fat { get; }
        public int SaturatedFat { get; }
        public int Fiber { get; }
        public int Protein { get; }
        public bool Vegan { get; }

        public Nutrients(
            int energy,
            int carbohydrate,
            int fat,
            int saturatedFat,
            int fiber,
            int protein,
            bool vegan)
        {
            Energy = energy;
            Carbohydrate = carbohydrate;
            Fat = fat;
            SaturatedFat = saturatedFat;
            Fiber = fiber;
            Protein = protein;
            Vegan = vegan;
        }

        public INutrients For(int gram)
        {
            var factor = gram / 100M;

            return new Nutrients(
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
