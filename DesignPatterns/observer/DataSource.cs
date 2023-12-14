using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.observer
{
    public class DataSource
    {
        private int value;

        public int getValue()
        {
            return value;
        }

        public void setValue()
        {
            this.value = value;
        }
    }
}
