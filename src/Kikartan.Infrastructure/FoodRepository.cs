using System;
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
                id: new Guid("3b5958dc-aedd-4015-b362-3470dbfe2d60"),
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

            yield return new Food(
                id: new Guid("7e7d2575-ab04-43ec-b88f-0604dbb8ce90"),
                name: "MixedBeans",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 98,
                    carbohydrate: 12,
                    fat: 1.1M,
                    saturatedFat: 0.5M,
                    fiber: 6.3M,
                    protein: 6.6M,
                    vegan: false));
        }
    }
}
