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
    }
}
