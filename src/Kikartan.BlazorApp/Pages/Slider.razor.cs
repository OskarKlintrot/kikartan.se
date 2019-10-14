using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kikartan.Application.Queries;
using Kikartan.Application.Queries.Contracts;
using Microsoft.AspNetCore.Components;

namespace Kikartan.BlazorApp.Pages
{
    public class SliderBase : ComponentBase
    {
        protected int proteinRatioDiscrete = 16;
        protected int targetBw = 75;

        protected decimal ProteinRatio => proteinRatioDiscrete / 10M;

        protected I18nText.NutrientFacts I18NutrientFacts { get; private set; } = new I18nText.NutrientFacts();
        protected I18nText.Labels I18Labels { get; private set; } = new I18nText.Labels();
        protected I18nText.Foods I18Foods { get; private set; } = new I18nText.Foods();

        protected readonly IDictionary<Guid, int> AmountOfFoods = new Dictionary<Guid, int>();

#pragma warning disable RCS1170 // Use read-only auto-implemented property.
        [Inject] protected Toolbelt.Blazor.I18nText.I18nText I18nText { get; private set; }
        [Inject] protected INutritionQueries NutritionQueries { get; private set; }
#pragma warning restore RCS1170 // Use read-only auto-implemented property.

        protected decimal Protein()
        {
            return ProteinRatio * targetBw;
        }

        protected IReadOnlyCollection<Food> GetFoods() => NutritionQueries.GetFoods();
        protected Nutrients SummerizeNutrients() => NutritionQueries.GetNutrientsSummery(AmountOfFoods);

        protected override async Task OnInitializedAsync()
        {
            I18NutrientFacts = await I18nText.GetTextTableAsync<I18nText.NutrientFacts>(this);
            I18Labels = await I18nText.GetTextTableAsync<I18nText.Labels>(this);
            I18Foods = await I18nText.GetTextTableAsync<I18nText.Foods>(this);

            foreach (var food in GetFoods())
            {
                AmountOfFoods.Add(food.Guid, 0);
            }
        }
    }
}
