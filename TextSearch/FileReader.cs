using System.Text;

namespace TextSearch;

public class FileReader : IFileReader
{
    private string[] filesArray;
    private string[] textFiles;
    public string[] ReadFile()
    {
        //get all files
        filesArray = Directory.GetFiles("C:\\Users\\NOBEL\\Desktop\\AllFiles");
        //get each file content
        textFiles = new string[filesArray.Length];

        for (int i = 0; i < filesArray.Length; i++)
        {
            textFiles[i] = File.ReadAllText(filesArray[i]).ToUpper();
        }

        return textFiles;
        //print files Test
        // PrintFileContent();
    }
    public void PrintFileContent()
    {
        foreach (var f in textFiles)
        {
            Console.WriteLine(f);
        }
    }
}