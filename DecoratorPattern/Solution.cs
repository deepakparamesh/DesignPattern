using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // You see in the problem section that this will lead to class explosion, 
    // And in future if you want to add logging functionality, you will have to create different types of logging for different types of streaming you did.

    public interface Istream
    {
        void write(string data);
    }

    public class CloudStream : Istream
    {
        public void write(string data)
        {
            Console.WriteLine(" Storing " + data);
        }
    }

    // decorators
    // Decorator class will have constructors on what type of stream it has to assign.
    public class CompressedCloudStream : Istream
    {
        private Istream stream;

        public CompressedCloudStream(Istream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var compressed = compress(data);
            stream.write(compressed);
        }

        private string compress(string data)
        {
            return data.Substring(0,8);
        }
    }

    public class EncryptedCloudStream : Istream
    {
        private Istream stream;

        public EncryptedCloudStream(Istream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var encrypteded = encrypted(data);
            stream.write(encrypteded);
        }

        private string encrypted(string data)
        {
            return "~!@#!@#$!@#$%#$%%^$^$&^%I^&*$#%$!@#$";
        }
    }

    public class Solution
    {
        public static void SolutionMain()
        {
            Istream stream = new EncryptedCloudStream(new CloudStream());
            stream.write("123456");

            storeCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
        }

        public static void storeCreditCard(Istream stream)
        {
            stream.write("1234-1234-1234-1234");
        }
    }
}
