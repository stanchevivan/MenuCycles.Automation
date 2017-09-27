using System.Collections.Generic;

namespace MenuCycleData.Generators
{
    public interface IGenerator<T>
    {
        T Generate();
        IList<T> Generate(int count);
    }
}
