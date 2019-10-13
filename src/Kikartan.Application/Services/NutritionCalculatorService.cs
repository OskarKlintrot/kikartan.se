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
        private readonly IEnumerable<Food> _food;

        public NutritionCalculatorService(IFoodRepository foodRepository)
        {
            _food = foodRepository.GetFoods().ToArray();
        }

        public IReadOnlyCollection<Food> GetFoods()
        {
            return new ReadOnlyCollection<Food>(_food.ToList());
        }

        public Nutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods)
        {
            var foodNutrients = _food
                .Where(x => amountOfFoods.ContainsKey(x.Guid))
                .Select(x => x.Nutrients.ChangeAmount(amountOfFoods[x.Guid]))
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

            var amount = foodNutrients
                .Aggregate(0, (x, y) => x + y.AmountInGram);

            var vegan = _food
                .Where(x => amountOfFoods.TryGetValue(x.Guid, out var value) && value > 0)
                .All(x => x.Nutrients.Vegan);

            return new Nutrients(
                amount,
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
