using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.strategy
{
    public class MalImageStorage
    {
        private string compressor;
        private string filter;
        

        public MalImageStorage(string compressor, string filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName)
        {
            if (compressor == "jpeg")
                Console.WriteLine("Compress using JPEG");
            else if (compressor == "png")
                Console.WriteLine("Compressing using PNG");

            if (filter == "b&w")
                Console.WriteLine("Apply b&w filter");
            else if (filter == "advanced")
                Console.WriteLine("Apply advanced filter");
        }
    }
}
