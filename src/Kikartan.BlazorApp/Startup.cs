using Kikartan.Application.Services;
using Kikartan.Application.Services.Contracts;
using Kikartan.Data.Food;
using Kikartan.Domain.Contracts;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace Kikartan.BlazorApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddI18nText<Startup>();

            services.AddSingleton<INutritionCalculatorService, NutritionCalculatorService>();

            AddFoods(services);
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }

        private void AddFoods(IServiceCollection services)
        {
            services.AddSingleton<IFood, WheyProteinPowder>();
        }
    }
}
