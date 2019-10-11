using System;

namespace Kikartan.Domain.Contracts
{
    public interface INutrients
    {
        Guid Guid => Guid.NewGuid();
        string Name { get; }
        int Energy { get; }
        int Carbohydrate { get; }
        int Fat { get; }
        int SaturatedFat { get; }
        int Fiber { get; }
        int Protein { get; }
        bool Vegan { get; }
    }
}
