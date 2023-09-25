namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long size = Calculator(folderPath, 0);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {               
                writer.WriteLine($"{size / 1024.0} KB");
            }
        }
        public static long Calculator(string name, int level)
        {

            Console.WriteLine($"{new string(' ', level * 3)}{name}");
            string[] files = Directory.GetFiles(name);

            long sum = 0;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{new string(' ', level * 3)}{info.Name} - {info.Length} bytes");
                sum += info.Length;
            }

            string[] directory = Directory.GetDirectories(name);

            foreach (var item in directory)
            {
                sum += Calculator(item, level + 1);
            }
            return sum;
        }
    }
}