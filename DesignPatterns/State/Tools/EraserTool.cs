using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Tools
{
    public class EraserTool : ITool
    {
        public void onMouseDown()
        {
            Console.WriteLine("Eraser Tool Activated");
        }

        public void onMouseUp()
        {
            Console.WriteLine("Erase object is done");
        }
    }
}
