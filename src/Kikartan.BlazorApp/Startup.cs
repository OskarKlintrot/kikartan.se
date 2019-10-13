using Kikartan.Application.Services;
using Kikartan.Application.Services.Contracts;
using Kikartan.Domain.Contracts;
using Kikartan.Infrastructure;
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

            services
                .AddSingleton<IFoodRepository, FoodRepository>()
                .AddSingleton<INutritionCalculatorService, NutritionCalculatorService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
