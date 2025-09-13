class ExtractFile 
{
    static void Main()
    {
        string filePath = Console.ReadLine();


        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
        string fileExtension = Path.GetExtension(filePath).TrimStart('.');

        Console.WriteLine($"File name: {fileNameWithoutExtension}");
        Console.WriteLine($"File extension: {fileExtension}");
    }
}
