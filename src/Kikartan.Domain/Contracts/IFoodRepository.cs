using System.Collections.Generic;

namespace Kikartan.Domain.Contracts
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetFoods();
    }
}
