using System.Collections.Generic;

namespace MenuCycle.Data.Generators
{
    public interface IGenerator<T>
    {
        T Generate();
        IList<T> Generate(int count);
    }
}
