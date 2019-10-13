using System;
using System.Collections.Generic;

namespace Kikartan.Domain.Contracts
{
    public interface INutrionCalculatorService
    {
        IReadOnlyCollection<IFood> GetFoods();
        INutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods);
    }
}