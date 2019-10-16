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
                    energy: 125,
                    fat: 0.6M,
                    saturatedFat: 0,
                    carbohydrate: 14.6M,
                    fiber: 9,
                    protein: 10.6M,
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

            yield return new Food(
                id: new Guid("83d40c33-e977-44d9-906f-44dd4d60c34c"),
                name: "Cheese17",
                max: 200,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 280,
                    fat: 17,
                    saturatedFat: 11.1M,
                    carbohydrate: 1.5M,
                    fiber: 0,
                    protein: 30.3M,
                    vegan: false));

            yield return new Food(
                id: new Guid("7427ab3d-35eb-41d8-b781-412df67e7329"),
                name: "Cheese26",
                max: 200,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 337,
                    fat: 26,
                    saturatedFat: 17,
                    carbohydrate: 1.4M,
                    fiber: 0,
                    protein: 24.9M,
                    vegan: false));

            yield return new Food(
                id: new Guid("eb1459d0-97e8-4883-8c64-4b37fd3b5b33"),
                name: "Cheese31",
                max: 200,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 386,
                    fat: 31,
                    saturatedFat: 20.3M,
                    carbohydrate: 1.4M,
                    fiber: 0,
                    protein: 26.2M,
                    vegan: false));

            yield return new Food(
                id: new Guid("cb219f0f-c657-449d-a537-a83c799b760b"),
                name: "RolledOats",
                max: 200,
                step: 10,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 370,
                    fat: 7,
                    saturatedFat: 1.3M,
                    carbohydrate: 60,
                    fiber: 8.5M,
                    protein: 12,
                    vegan: true));

            yield return new Food(
                id: new Guid("c31a7ae2-da46-4c13-8ed2-920bb9115795"),
                name: "WhiteBread",
                max: 200,
                step: 10,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 288,
                    fat: 1.9M,
                    saturatedFat: 0.4M,
                    carbohydrate: 54,
                    fiber: 5.7M,
                    protein: 10,
                    vegan: true));

            yield return new Food(
                id: new Guid("bb809cd8-0cad-4234-90af-c7c859d842df"),
                name: "BrownBread",
                max: 200,
                step: 10,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 261,
                    fat: 3.1M,
                    saturatedFat: 0.6M,
                    carbohydrate: 47.3M,
                    fiber: 3.4M,
                    protein: 8.42M,
                    vegan: true));

            yield return new Food(
                id: new Guid("e54aecae-ce1f-4f7c-8605-1f97e8ea3909"),
                name: "GreenPeas",
                max: 200,
                step: 10,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 69,
                    fat: 0.4M,
                    saturatedFat: 0.1M,
                    carbohydrate: 8.9M,
                    fiber: 4.4M,
                    protein: 5.2M,
                    vegan: true));

            yield return new Food(
                id: new Guid("bf66aa28-6f5c-484b-83d4-0b1d717d8a73"),
                name: "Peanuts",
                max: 100,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 610,
                    fat: 51,
                    saturatedFat: 7.4M,
                    carbohydrate: 7.9M,
                    fiber: 9.5M,
                    protein: 26.7M,
                    vegan: true));

            yield return new Food(
                id: new Guid("c6a0c127-5883-460f-9b5f-c8759f9dd6d7"),
                name: "Almonds",
                max: 100,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 609,
                    fat: 7.2M,
                    saturatedFat: 4.9M,
                    carbohydrate: 13.4M,
                    fiber: 7.2M,
                    protein: 20.0M,
                    vegan: true));

            yield return new Food(
                id: new Guid("3c5b8afa-1475-47b1-bf57-aef4ef799206"),
                name: "hazelnuts",
                max: 100,
                step: 5,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 656,
                    fat: 62M,
                    saturatedFat: 4.9M,
                    carbohydrate: 9.4M,
                    fiber: 6,
                    protein: 13,
                    vegan: true));

            yield return new Food(
                id: new Guid("fd597bcd-dd7d-40f8-bb9c-947c652dba24"),
                name: "egg",
                max: 500,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 137,
                    fat: 9.7M,
                    saturatedFat: 2.3M,
                    carbohydrate: 0.4M,
                    fiber: 0,
                    protein: 12.3M,
                    vegan: false));

            yield return new Food(
                id: new Guid("d0268e1d-63be-4539-9669-e61e677ff6a3"),
                name: "tofu",
                max: 300,
                step: 50,
                nutrients: new Nutrients(
                    amount: 100,
                    energy: 160,
                    fat: 9.4M,
                    saturatedFat: 1.4M,
                    carbohydrate: 1.6M,
                    fiber: 0,
                    protein: 18M,
                    vegan: true));
        }
    }
}
