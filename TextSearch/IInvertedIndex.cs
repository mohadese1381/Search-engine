namespace TextSearch;

public interface IInvertedIndex
{
    public void SetInvertedIndex(string[] filteredFiles);
    public Dictionary<string, HashSet<string>> GetInvertedIndex();
}