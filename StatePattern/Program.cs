namespace Com.DeepakParamesh
{

    public class Canvas
    {
        public ITools currentTool;

        public void onMouseDown()
        {
            currentTool.mouseDown();
        }

        public void onMouseUp()
        {
            currentTool.mouseUp();
        }

        public void setCurrentTool(ITools tool)
        {
            currentTool = tool;
        }
    }

    public interface ITools
    {
        void mouseDown();
        void mouseUp();
    }

    public class BrushTool : ITools
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush tool activated");
        }

        public void mouseUp()
        {
            Console.WriteLine("Brush stroke is drawn");
        }
    }

    public class SelectionTool : ITools
    {
        public void mouseDown()
        {
            Console.WriteLine("Selection tool activated");
        }

        public void mouseUp()
        {
            Console.WriteLine("a dashed rectangle is drawn");
        }
    }

    public class EraserTool : ITools
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser tool activated");
        }

        public void mouseUp()
        {
            Console.WriteLine("Canvas is erased");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to state Pattern");
            
            Canvas newCanvas = new();
            // we are setting the state
            newCanvas.setCurrentTool(new BrushTool());
            newCanvas.onMouseDown();
            newCanvas.onMouseUp();


            newCanvas.setCurrentTool(new SelectionTool());
            newCanvas.onMouseDown();
            newCanvas.onMouseUp();

            newCanvas.setCurrentTool(new EraserTool());
            newCanvas.onMouseDown();
            newCanvas.onMouseUp();
        }
    }
}