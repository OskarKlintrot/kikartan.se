using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
