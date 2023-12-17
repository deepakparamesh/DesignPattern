using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.AbstractFactoryPattern
{

    public interface IWidget
    {
        public void render();
    }

    public interface IButton : IWidget
    {
        
    }

    public interface ITextBox: IWidget
    {

    }

    public class MaterialButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Material Button rendered");
        }
    }

    public class MaterialTextBox : ITextBox
    {
        public void render()
        {
            Console.WriteLine("Material TextBox rendered");
        }
    }

    public class BootstrapButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Bootstrap button rendered");
        }
    }

    public class BootstrapTextBox : ITextBox
    {
        public void render()
        {
            Console.WriteLine("Bootstrap textbox rendered");
        }
    }

    public enum Theme
    {
        Material,
        Bootstrap
    }


    public class ContactForm
    {
        public void render(Theme theme)
        {
            if(theme == Theme.Material)
            {
                new MaterialButton().render();
                new MaterialTextBox().render();
            }
            else if(theme == Theme.Bootstrap)
            {
                new BootstrapButton().render();
                new BootstrapTextBox().render();
            }
        }
    }

    public class Problem
    {
        public static void ProblemMain()
        {
           ContactForm contactForm = new();
           contactForm.render(Theme.Bootstrap);

           
        }
    }
}
