Print("../../../1.jpg");
void Print(string filePath)
{
    using(FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
    {
        byte[] data = new byte[stream.Length];

        stream.Read(data, 0, data.Length);

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = (byte)(data[i] ^ 183);
        }

        stream.Seek(0, SeekOrigin.Begin);

        stream.Write(data, 0, data.Length);
        Console.WriteLine(data.Length);
        Console.WriteLine(string.Join(" ", data));
    }
}