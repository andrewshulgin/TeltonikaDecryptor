using System;
using System.IO;
using Teltonika.Firmware;

namespace TeltonikaDecryptor
{
    class Program
    {
        static void Usage()
        {
            Console.Error.WriteLine("Usage: TeltonikaDecryptor <firmware.xim> <output.bin>");
        }

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Usage();
                return;
            }
            FrameContainer container = ContainerLoader.FromFile(args[0]);
            File.WriteAllBytes(args[1], container.Image.Array);
        }
    }
}
