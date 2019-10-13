using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kikartan.Domain.Contracts;
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

        [Inject] protected Toolbelt.Blazor.I18nText.I18nText I18nText { get; private set; }
        [Inject] protected INutrionCalculatorService NutrionCalculatorService { get; private set; }

        protected decimal Protein()
        {
            return ProteinRatio * targetBw;
        }

        protected IReadOnlyCollection<IFood> Foods => NutrionCalculatorService.GetFoods();
        protected INutrients NutrientsSummerized => NutrionCalculatorService.GetNutrientsSummery(AmountOfFoods);

        protected override async Task OnInitializedAsync()
        {
            I18NutrientFacts = await I18nText.GetTextTableAsync<I18nText.NutrientFacts>(this);
            I18Labels = await I18nText.GetTextTableAsync<I18nText.Labels>(this);
            I18Foods = await I18nText.GetTextTableAsync<I18nText.Foods>(this);

            foreach (var food in Foods)
            {
                AmountOfFoods.Add(food.Guid, 0);
            }
        }
    }
}
