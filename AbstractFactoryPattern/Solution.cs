using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.AbstractFactoryPattern
{

    public interface IWidget
    {
        public void render();
    }

    public interface IButton : IWidget
    {
        // other elements of button
    }

    public interface ITextBox : IWidget
    {

    }

    // Abstract Factory
    public interface IWidgetFactory
    {
        IButton createButton();
        ITextBox createTextBox();
    }

    // Concrete Factory
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton createButton()
        {
            return new MaterialButton();
        }

        public ITextBox createTextBox()
        {
            return new MaterialTextBox();
        }
    }

    public class BootstrapWidgetFactory : IWidgetFactory
    {
        public IButton createButton()
        {
            return new BootstrapButton();
        }

        public ITextBox createTextBox()
        {
            return new BootstrapTextBox();
        }
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
        public void render(IWidgetFactory factory)
        {
            factory.createTextBox().render();
            factory.createButton().render();
        }
    }

    public class Solution
    {
        public static void SolutionMain()
        {
            new ContactForm().render(new MaterialWidgetFactory());
        }
    }
}
