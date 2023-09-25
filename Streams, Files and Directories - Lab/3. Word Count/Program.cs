namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
       textFilePath, string outputFilePath)
        {
            using (StreamReader words = new StreamReader(wordsFilePath))
            {
                string line = string.Empty;
                while (!words.EndOfStream)
                {
                    line = words.ReadLine();
                }
                string[] split = line.Split(" ");

                using (StreamReader text = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        Dictionary<string, int> times = new Dictionary<string, int>();

                        string read = string.Empty;
                        while (!text.EndOfStream)
                        {
                            read += text.ReadToEnd();
                        }

                        string[] parts = read.Split(new string[] { " ", "-", ",", ".", "!", "?", ":", ";" }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < split.Length; i++)
                        {
                            times.Add(split[i], 0);
                        }
                        for (int j = 0; j < parts.Length; j++)
                        {
                            string Low = parts[j].ToLower();
                            if (times.ContainsKey(Low))
                            {
                                times[Low]++;
                            }
                        }
                        var sortedDict = from entry in times orderby entry.Value descending select entry;
                        foreach (var item in sortedDict)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
