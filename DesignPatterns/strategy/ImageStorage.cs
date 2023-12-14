using DesignPatterns.strategy.CompressorStrategy;
using DesignPatterns.strategy.FilterStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.strategy
{
    public class ImageStorage
    {
        //private ICompressorStrategy compressor;
        //private IFilterStrategy filter;

        //public ImageStorage(ICompressorStrategy compressor, IFilterStrategy filter)
        //{
        //    this.compressor = compressor;
        //    this.filter = filter;
        //}

        public void store(string fileName, ICompressorStrategy compressor, IFilterStrategy filter)
        {
            compressor.compress(fileName);
            filter.filter(fileName);
        }
    }
}
