namespace Kikartan.Domain.Contracts
{
    public interface INutrients
    {
        int Energy { get; }
        int Carbohydrate { get; }
        int Fat { get; }
        int SaturatedFat { get; }
        int Fiber { get; }
        int Protein { get; }
        bool Vegan { get; }
    }
}
