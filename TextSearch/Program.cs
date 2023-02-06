using TextSearch;

public static class Program
{
    static void Main(string[] args)
    {
        FileReader fileReader = new FileReader();
        string[] file = fileReader.ReadFile();

        FilterFile fileFilter = new FilterFile();
        string[] filteredFile = fileFilter.FilterFiles(file);
        
        InvertedIndex invertedIndex = new InvertedIndex();
        invertedIndex.SetInvertedIndex(filteredFile);
        Dictionary<string, HashSet<string>> finalFile = invertedIndex.GetInvertedIndex();

        UserPanel userPanel = new UserPanel();
        userPanel.Search(finalFile);
    }
}