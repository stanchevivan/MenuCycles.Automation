using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleData.Generators
{
    public interface IGenerator<T>
    {
        T Generate();
        IList<T> Generate(int count);
    }
}
