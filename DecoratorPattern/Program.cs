namespace Com.DeepakParamesh
{

    // Cloudstream class to store the given data in the cloud
    public class CloudStream
    {
       public void write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }


    public class CompressedCloudStream : CloudStream
    {
        public void write(string data)
        {
            var compressed = compress(data);
            base.write(data);
        }
        private string compress(string data)
        {
            return data.Substring(0, 5);
        }
    }

    public class Program
    {
        public static void Main()
        {

        }
    }
}