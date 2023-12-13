using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Tools
{
    public class BrushTool : ITool
    {
        public void onMouseDown()
        {
            Console.WriteLine("BrushTool activated");
        }

        public void onMouseUp()
        {
            Console.WriteLine("A Brush Stroke is drawn");
        }
    }
}
