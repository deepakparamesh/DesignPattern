using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Tools
{
    public class SelectionTool : ITool
    {
        public void onMouseDown()
        {
            Console.WriteLine("Selection Tool Activated");
        }

        public void onMouseUp()
        {
            Console.WriteLine("A dotted rectangle is drawn");
        }
    }
}
