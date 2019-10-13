using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Kikartan.Application.Services.Contracts;
using Kikartan.Domain;
using Kikartan.Domain.Contracts;

namespace Kikartan.Application.Services
{
    public class NutritionCalculatorService : INutritionCalculatorService
    {
        private readonly IEnumerable<IFood> _food;

        public NutritionCalculatorService(IEnumerable<IFood> foodNutrients)
        {
            _food = foodNutrients;
        }

        public IReadOnlyCollection<IFood> GetFoods()
        {
            return new ReadOnlyCollection<IFood>(_food.ToList());
        }

        public INutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods)
        {
            var foodNutrients = _food
                .Where(x => amountOfFoods.ContainsKey(x.Guid))
                .Select(x => x.Nutrients.For(amountOfFoods[x.Guid]))
                .ToArray();

            var energy = foodNutrients
                .Aggregate(0, (x, y) => x + y.Energy);

            var carbohydrate = foodNutrients
                .Aggregate(0, (x, y) => x + y.Carbohydrate);

            var fat = foodNutrients
                .Aggregate(0, (x, y) => x + y.Fat);

            var saturatedFat = foodNutrients
                .Aggregate(0, (x, y) => x + y.SaturatedFat);

            var fiber = foodNutrients
                .Aggregate(0, (x, y) => x + y.Fiber);

            var protein = foodNutrients
                .Aggregate(0, (x, y) => x + y.Protein);

            var vegan = _food
                .Where(x => amountOfFoods.TryGetValue(x.Guid, out var value) && value > 0)
                .All(x => x.Nutrients.Vegan);

            return new Nutrients(
                energy,
                carbohydrate,
                fat,
                saturatedFat,
                fiber,
                protein,
                vegan);
        }
    }
}
