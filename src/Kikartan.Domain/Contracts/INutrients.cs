using System;

namespace Kikartan.Domain.Contracts
{
    public interface INutrients
    {
        // TODO: Use when https://github.com/mono/mono/issues/15833 is fixed
        //Guid Guid => Guid.NewGuid();
        Guid Guid { get; }
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
