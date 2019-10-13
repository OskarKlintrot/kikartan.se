using System.Collections.Generic;
using Kikartan.Domain;
using Kikartan.Domain.Contracts;

namespace Kikartan.Infrastructure
{
    public class FoodRepository : IFoodRepository
    {
        public IEnumerable<Food> GetFoods()
        {
            yield return new Food(
                name: "WheyProteinPowder",
                max: 150,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 384,
                    carbohydrate: 8,
                    fat: 6,
                    saturatedFat: 4,
                    fiber: 0,
                    protein: 74,
                    vegan: false));
        }
    }
}
