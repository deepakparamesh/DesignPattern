using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.strategy.FilterStrategies
{
    public class BlackAndWhiteFilter : IFilterStrategy
    {
        public void filter(string fileName)
        {
            Console.WriteLine("Black And white filter Applied");
        }
    }
}
