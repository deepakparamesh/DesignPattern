using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.strategy.FilterStrategies
{
    public interface IFilterStrategy
    {
        void filter(string fileName);
    }
}
