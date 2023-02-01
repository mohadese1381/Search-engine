namespace TextSearch;

public class FileReader : IFileReader
{
    public void ReadFile()
    {
        //get all files
        string[] filesArray = Directory.GetFiles("C:\\Users\\NOBEL\\Desktop\\AllFiles");
        //get each file content
        string[] textFiles = new string[filesArray.Length];

        for (int i = 0; i < filesArray.Length; i++)
        {
            textFiles[i] = File.ReadAllText(filesArray[i]);
        }
        //print files Test
        PrintFileContent(textFiles);
    }
    public void PrintFileContent(string[] files)
    {
        foreach (var f in files)
        {
            Console.WriteLine(f);
        }
    }
}