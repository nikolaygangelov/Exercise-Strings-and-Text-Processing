using System;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            
            int startFileIndex = filePath.LastIndexOf('\\') + 1;
            int startFileExtensionIndex = filePath.IndexOf('.') + 1;
            int fileNameLength = startFileExtensionIndex - 1 - startFileIndex;

            string fileName = filePath.Substring(startFileIndex, fileNameLength);
            string fileExtension = filePath.Substring(startFileExtensionIndex);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
