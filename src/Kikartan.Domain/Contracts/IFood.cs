using System;

namespace Kikartan.Domain.Contracts
{
    public interface IFood
    {
        // TODO: Use when https://github.com/mono/mono/issues/15833 is fixed
        //Guid Guid => Guid.NewGuid();
        Guid Guid { get; }
        string Name { get; }

        // TODO: These should not belong in Domain
        int Max { get; }
        int Step { get; }

        INutrients Nutrients { get; }
    }
}
