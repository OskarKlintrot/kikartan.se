using System;
using System.Collections.Generic;
using Kikartan.Domain.Contracts;

namespace Kikartan.Application.Services.Contracts
{
    public interface INutritionCalculatorService
    {
        IReadOnlyCollection<IFood> GetFoods();
        INutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods);
    }
}