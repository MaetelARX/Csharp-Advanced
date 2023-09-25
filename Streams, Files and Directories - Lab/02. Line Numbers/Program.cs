namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string
       outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter write = new StreamWriter(outputFilePath))
                {
                    int count = 1;
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        write.WriteLine($"{count++}. {line}");
                    }
                }
            }
        }
    }
}
