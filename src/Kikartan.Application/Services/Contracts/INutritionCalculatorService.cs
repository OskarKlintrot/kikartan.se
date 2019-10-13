using System;
using System.Collections.Generic;
using Kikartan.Domain;

namespace Kikartan.Application.Services.Contracts
{
    public interface INutritionCalculatorService
    {
        IReadOnlyCollection<Food> GetFoods();
        Nutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods);
    }
}