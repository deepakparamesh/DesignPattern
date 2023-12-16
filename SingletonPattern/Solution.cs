using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.SingletonPattern
{
    // In order to make the problem class as a singleton class we need to follow few steps
    // 1. Make the constructor of the class private - which will not enable the 'new' operation usage of the class
    // 2. Next we need to maintain a property which is responsible for single instance, this property is static and private.
    // 3. Next we need to have a method 'getInstance()' which is responsible to get the instance of the class, this property should be static.


    public class Configuration
    {
        private Dictionary<string, Object> settings = new();
        private static Configuration instance = new();

        private Configuration()
        {

        }

        public static Configuration getInstance()
        {
            return instance;
        }

        public void set(string key, Object value)
        {
            settings.Add(key, value);
        }

        public Object get(string key)
        {
            return settings[key];
        }
    }

    public class Solution
    { 
        public static void SolutionMain()
        {
            Configuration settings = Configuration.getInstance();
            settings.set("name", "Deepak Paramesh");

            Configuration anotherSetting = Configuration.getInstance();
            Console.WriteLine(anotherSetting.get("name"));
        }
    }
}
