namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string
       outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter write = new StreamWriter(outputFilePath))
                {
                    int count = 0;
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        if (count++ % 2 == 1)
                        {
                            write.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}