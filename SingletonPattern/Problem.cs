using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.SingletonPattern
{
    // At some time, we need to maintain only one copy of a class across the application.
    // This is where we need singleton pattern.

    // let's say we have configuration in our application which is supposed to have only one copy across the application.
    // But if we let this class to be able to create multiple copies of it. The objective of single copy across the application will be breached
    public class Configuration
    {
        private Dictionary<string, Object> settings = new();

        public void set(string key, Object value)
        {
            settings.Add(key, value);
        }

        public Object get(string key)
        {
            return settings[key];
        }
    }

    public class Problem
    {
        public static void ProblemMain()
        {
            Configuration settings = new();
            settings.set("name", "Deepak");


            Configuration newSettings = new();

            Console.WriteLine(settings.get("name"));
            // This will throw an error which says newSettings does not have name in it.
            //Console.WriteLine(newSettings.get("name"));
        }
    }
}
