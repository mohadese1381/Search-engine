namespace TextSearch;

public class FilterFile : IFilterFile
{
    private string[] filteredFiles;
    public string[] FilterFiles(string[] textFiles)
    {
        filteredFiles = new string[textFiles.Length];
        for (int i = 0; i < textFiles.Length; i++)
        {
            foreach (var c in textFiles[i])
            {
                if ((!Char.IsPunctuation(c)) && (!char.IsSymbol(c)) && (!Char.IsDigit(c)))
                {
                    filteredFiles[i] += c;
                } 
            }
        }
        return filteredFiles;
    }
}