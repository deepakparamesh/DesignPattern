using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.strategy.CompressorStrategy
{
    public interface ICompressorStrategy
    {
        //byte[] compress(byte[] imagefile);
        void compress(string fileName);
    }
}
