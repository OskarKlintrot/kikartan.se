using Kikartan.Domain.Contracts;

namespace Kikartan.Domain
{
    public class Nutrients : INutrients
    {
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

        public int Energy { get; }

        public int Carbohydrate { get; }

        public int Fat { get; }

        public int SaturatedFat { get; }

        public int Fiber { get; }

        public int Protein { get; }

        public bool Vegan { get; }
    }
}
