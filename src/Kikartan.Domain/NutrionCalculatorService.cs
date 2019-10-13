using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Kikartan.Domain.Contracts;

namespace Kikartan.Domain
{
    public class NutrionCalculatorService : INutrionCalculatorService
    {
        private readonly IEnumerable<IFood> _food;

        public NutrionCalculatorService(IEnumerable<IFood> foodNutrients)
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
                .ToArray();

            var energy = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Nutrients.Energy * amountOfFoods[y.Guid]) / 100);

            var carbohydrate = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Nutrients.Carbohydrate * amountOfFoods[y.Guid]) / 100);

            var fat = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Nutrients.Fat * amountOfFoods[y.Guid]) / 100);

            var saturatedFat = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Nutrients.SaturatedFat * amountOfFoods[y.Guid]) / 100);

            var fiber = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Nutrients.Fiber * amountOfFoods[y.Guid]) / 100);

            var protein = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Nutrients.Protein * amountOfFoods[y.Guid]) / 100);

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
