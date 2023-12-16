namespace Com.DeepakParamesh
{
    // Assume you are a software engineer and your boss asks you to store a file in the cloud.
    // You have created a class CloudStream which writes the file to cloud storage.
    // One day your boss asks you to store file by encrypting it.
    // Hence you are writing another class CloudStreamEncrypted which encrypts and then write to the cloud.
    // Some other day, you are asked to compress the file and then store to the cloud.
    // Hence you are writing another class CloudStreamCompress which compress and then writes to the cloud.
    // Another day, you are asked to Both Compress and Encrypt the file before storing to cloud.
    // Hence you know what to do.

    // The problem here is "Class Explosion", you are creating different classes for adding new features to a base class.
    // The solution is Decorator pattern, which helps to add layers of features you want to add in base class. Or decorate your base class with list of features you want to add on top.

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
            base.write(compressed);
        }
        private string compress(string data)
        {
            return data.Substring(0, 5);
        }
    }

    public class EncryptedCloudStream : CloudStream
    {
        public void write(string data)
        {
            var encrypted = encrypt(data);
            base.write(encrypted);
        }

        private string encrypt(string data)
        {
            return "~0#$$%^%^&%^&#@@#!@#$#%^*^)*()^&*#$%T@#$@#$";
        }
    }

    public class Problem
    {
        public static void ProblemMain()
        {
            EncryptedCloudStream cloudStream = new();
            cloudStream.write("Here's some data");
        }
    }
}