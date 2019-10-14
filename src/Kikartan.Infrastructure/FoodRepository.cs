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
                    fat: 6,
                    saturatedFat: 4,
                    carbohydrate: 8,
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
                    fat: 1.1M,
                    saturatedFat: 0.5M,
                    carbohydrate: 12,
                    fiber: 6.3M,
                    protein: 6.6M,
                    vegan: true));

            yield return new Food(
                id: new Guid("76db5d72-f338-47fe-bb8e-02f29958fcd6"),
                name: "Matvete",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 98,
                    fat: 1.1M,
                    saturatedFat: 0,
                    carbohydrate: 17,
                    fiber: 4,
                    protein: 3.1M,
                    vegan: true));

            yield return new Food(
                id: new Guid("2cc2ea07-3d0b-46ac-9898-a7d9c92b6ce2"),
                name: "SoyBeans",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 140,
                    fat: 7.5M,
                    saturatedFat: 1.8M,
                    carbohydrate: 3.2M,
                    fiber: 6,
                    protein: 12,
                    vegan: true));

            yield return new Food(
                id: new Guid("38a23111-046f-4bc7-a973-ba871b149450"),
                name: "RedLentils",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 101,
                    fat: 0.4M,
                    saturatedFat: 0,
                    carbohydrate: 17.5M,
                    fiber: 1.9M,
                    protein: 7.6M,
                    vegan: true));

            yield return new Food(
                id: new Guid("766075fc-e9b8-47cf-90fa-77c1d50d34bf"),
                name: "WhiteRiceUncooked",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 356,
                    fat: 0.7M,
                    saturatedFat: 0.1M,
                    carbohydrate: 75M,
                    fiber: 0.2M,
                    protein: 8.5M,
                    vegan: true));

            yield return new Food(
                id: new Guid("fa3db90b-62b8-4d86-9bba-3bb550285da7"),
                name: "BrownRiceUncooked",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 365,
                    fat: 3,
                    saturatedFat: 0.6M,
                    carbohydrate: 76.1M,
                    fiber: 4.2M,
                    protein: 9.4M,
                    vegan: true));

            yield return new Food(
                id: new Guid("a11d6901-4e4c-4402-9694-2a9180d539a9"),
                name: "PastaUncooked",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 360,
                    fat: 1.2M,
                    saturatedFat: 0.1M,
                    carbohydrate: 75M,
                    fiber: 3.1M,
                    protein: 12.5M,
                    vegan: true));

            yield return new Food(
                id: new Guid("2c10162b-7156-4e55-9a58-9dfccdd3c3d1"),
                name: "Kvarg",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 60,
                    fat: 0.2M,
                    saturatedFat: 0.1M,
                    carbohydrate: 3.5M,
                    fiber: 0,
                    protein: 11,
                    vegan: false));
        }
    }
}
