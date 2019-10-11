using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Kikartan.BlazorApp.Pages
{
    public class SliderBase : ComponentBase
    {
        protected int proteinRatioDiscrete = 16;
        protected int targetBw = 75;

        protected decimal ProteinRatio => proteinRatioDiscrete / 10M;

        protected I18nText.NutrientFacts NutrientFacts { get; private set; } = new I18nText.NutrientFacts();
        protected I18nText.Labels Labels { get; private set; } = new I18nText.Labels();
        protected I18nText.Foods Foods { get; private set; } = new I18nText.Foods();

        protected readonly IDictionary<Guid, int> AmountOfFoods = new Dictionary<Guid, int>();

        [Inject] protected Toolbelt.Blazor.I18nText.I18nText I18nText { get; private set; }
        [Inject] protected IEnumerable<Domain.Contracts.INutrients> FoodNutrients { get; private set; }

        protected decimal Protein()
        {
            return ProteinRatio * targetBw;
        }

        protected override async Task OnInitializedAsync()
        {
            NutrientFacts = await I18nText.GetTextTableAsync<I18nText.NutrientFacts>(this);
            Labels = await I18nText.GetTextTableAsync<I18nText.Labels>(this);
            Foods = await I18nText.GetTextTableAsync<I18nText.Foods>(this);

            foreach (var food in FoodNutrients)
            {
                AmountOfFoods.Add(food.Guid, 0);
            }
        }

        protected Domain.Contracts.INutrients GetNutrients()
        {
            var foodNutrients = FoodNutrients
                .Where(x => AmountOfFoods.ContainsKey(x.Guid))
                .ToArray();

            var energy = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Energy * AmountOfFoods[y.Guid]) / 100);

            var carbohydrate = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Carbohydrate * AmountOfFoods[y.Guid]) / 100);

            var fat = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Fat * AmountOfFoods[y.Guid]) / 100);

            var saturatedFat = foodNutrients
                .Aggregate(0, (x, y) => x + (y.SaturatedFat * AmountOfFoods[y.Guid]) / 100);

            var fiber = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Fiber * AmountOfFoods[y.Guid]) / 100);

            var protein = foodNutrients
                .Aggregate(0, (x, y) => x + (y.Protein * AmountOfFoods[y.Guid]) / 100);

            var vegan = FoodNutrients
                .Where(x => AmountOfFoods.TryGetValue(x.Guid, out var value) && value > 0)
                .All(x => x.Vegan);

            return new Summary(
                energy,
                carbohydrate,
                fat,
                saturatedFat,
                fiber,
                protein,
                vegan);
        }

        private class Summary : Domain.Contracts.INutrients
        {
            public Summary(
                int energy,
                int carbohydrate,
                int fat,
                int saturatedFat,
                int fiber,
                int protein,
                bool vegan)
            {
                Energy = energy;
                Carbohydrate = carbohydrate;
                Fat = fat;
                SaturatedFat = saturatedFat;
                Fiber = fiber;
                Protein = protein;
                Vegan = vegan;
            }

            public Guid Guid => throw new NotImplementedException();
            public string Name => throw new NotImplementedException();
            public int Energy { get; }
            public int Carbohydrate { get; }
            public int Fat { get; }
            public int SaturatedFat { get; }
            public int Fiber { get; }
            public int Protein { get; }
            public bool Vegan { get; }

            public int Max => throw new NotImplementedException();

            public int Step => throw new NotImplementedException();
        }
    }
}
