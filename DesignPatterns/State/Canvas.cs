using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private ITool currentTool;
    
        public void onMouseUp()
        {
            currentTool.onMouseUp();
        }
        
        public void onMouseDown()
        {
            currentTool.onMouseDown();
        }

        public ITool getTool()
        {
            return currentTool;
        }

        public void setTool(ITool currentTool)
        {
            this.currentTool = currentTool;
        }
    }
}
