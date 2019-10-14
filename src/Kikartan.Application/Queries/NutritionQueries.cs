using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Kikartan.Application.Queries.Contracts;
using Kikartan.Domain.Contracts;

namespace Kikartan.Application.Queries
{
    public class NutritionQueries : INutritionQueries
    {
        private readonly Food[] _foods;

        public NutritionQueries(IFoodRepository foodRepository)
        {
            // TODO: Not sure why I have to retrive these immediately here
            _foods = foodRepository
                .GetFoods()
                .Select(x => new Food(
                    x.Id,
                    x.Name,
                    x.Max,
                    x.Step,
                    new Nutrients(
                        amount: x.Nutrients.AmountInGram,
                        energy: x.Nutrients.Energy,
                        fat: x.Nutrients.Fat,
                        saturatedFat: x.Nutrients.SaturatedFat,
                        carbohydrate: x.Nutrients.Carbohydrate,
                        fiber: x.Nutrients.Fiber,
                        protein: x.Nutrients.Protein,
                        vegan: x.Nutrients.Vegan)))
                .ToArray();
        }

        public IReadOnlyCollection<Food> GetFoods()
        {
            return new ReadOnlyCollection<Food>(_foods);
        }

        public Nutrients GetNutrientsSummery(IDictionary<Guid, int> amountOfFoods)
        {
            var foodNutrients = _foods
                .Where(x => amountOfFoods.ContainsKey(x.Id))
                .Select(x => x.Nutrients.ChangeAmount(amountOfFoods[x.Id]))
                .ToArray();

            var energy = foodNutrients
                .Aggregate(0, (x, y) => x + y.Energy);

            var carbohydrate = foodNutrients
                .Aggregate(0M, (x, y) => x + y.Carbohydrate);

            var fat = foodNutrients
                .Aggregate(0M, (x, y) => x + y.Fat);

            var saturatedFat = foodNutrients
                .Aggregate(0M, (x, y) => x + y.SaturatedFat);

            var fiber = foodNutrients
                .Aggregate(0M, (x, y) => x + y.Fiber);

            var protein = foodNutrients
                .Aggregate(0M, (x, y) => x + y.Protein);

            var amount = foodNutrients
                .Aggregate(0, (x, y) => x + y.AmountInGram);

            var vegan = _foods
                .Where(x => amountOfFoods.TryGetValue(x.Id, out var value) && value > 0)
                .All(x => x.Nutrients.Vegan);

            return new Nutrients(
                amount: amount,
                energy: energy,
                fat: fat,
                saturatedFat: saturatedFat,
                carbohydrate: carbohydrate,
                fiber: fiber,
                protein: protein,
                vegan: vegan);
        }
    }
}
