namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath,
           outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string
       secondInputFilePath, string outputFilePath)
        {
            using (StreamReader input1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader input2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter output = new StreamWriter(outputFilePath))
                    {
                        string text = string.Empty;
                        string text2 = string.Empty;
                        while (!input1.EndOfStream)
                        {
                            text += input1.ReadLine();
                        }
                        while (!input2.EndOfStream)
                        {
                            text2 += input2.ReadLine();
                        }

                        if (text.Length > text2.Length)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                if (text2.Length > i)
                                {
                                    output.WriteLine(text2[i]);
                                }
                                output.WriteLine(text[i]);
                            }
                        }
                        else if (text.Length < text2.Length)
                        {
                            for (int i = 0; i < text2.Length; i++)
                            {
                                if (text.Length > i)
                                {
                                    output.WriteLine(text[i]);
                                }
                                output.WriteLine(text2[i]);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < text2.Length; i++)
                            {
                                output.WriteLine(text[i]);
                                output.WriteLine(text2[i]);
                            }
                        }
                    }
                }
            }
        }
    }
}
