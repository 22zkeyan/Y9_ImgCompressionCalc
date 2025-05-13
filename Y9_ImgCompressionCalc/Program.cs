namespace Y9_ImgCompressionCalc
{
    internal class Program
    {
        static void CompressionCalc()
        {
            int[] bitDepthsCompressed = { 64, 48, 36, 32, 30, 24, 16, 8, 1 };
            int[] compressedFileSizes = new int[4];

            Console.Write("Enter the bit depth in the form e.g. 24-bit true colour: ");
            string temp = Console.ReadLine()!;
            string bitDepthTemp = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '-')
                {
                    break;
                }
                bitDepthTemp += temp[i];

            }
            int bitDepth = Convert.ToInt32(bitDepthTemp);
            Console.WriteLine("Enter the dimensions in pixels");
            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bit depth test: " + bitDepth);
            Console.WriteLine("test: " + Array.IndexOf(bitDepthsCompressed, bitDepth));

            for (int i = Array.IndexOf(bitDepthsCompressed, bitDepth); i < bitDepthsCompressed.Length-1; i++)
            {
                for (int j = 0; j < compressedFileSizes.Length-1; j++)
                {
                    compressedFileSizes[j] = (width * height * bitDepthsCompressed[i]) / 8000;
                }
                
            }

            Console.WriteLine("File sizes in increasing order of compression (kB): ");
            foreach (int i in compressedFileSizes)
            {
                Console.WriteLine(i + "kB");
            }
        }
        static void Main(string[] args)
        {
            CompressionCalc();
        }
    }
}
