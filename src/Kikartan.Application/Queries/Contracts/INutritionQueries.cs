using System;
using System.Collections.Generic;
using Kikartan.Domain;

namespace Kikartan.Application.Queries.Contracts
{
    public interface INutritionQueries
    {
        IReadOnlyCollection<Food> GetFoods();
        Nutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods);
    }
}