namespace TextSearch;

public class InvertedIndex : IInvertedIndex
{
    private Dictionary<string, HashSet<string>> invertedIndex=new Dictionary<string, HashSet<string>>();
    private string[] _words;
    private static int _fileCounter = 0;
    private HashSet<string> _fileIndex;
    public void SetInvertedIndex(string[] filteredFiles)
    {
        for (int i = 0; i < filteredFiles.Length; i++)
        {
            _fileCounter++;
            if (filteredFiles[i] != null)
            {
                _words = filteredFiles[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var c in _words)
                {
                    if (!invertedIndex.ContainsKey(c))
                    {
                        _fileIndex = new HashSet<string>();
                        _fileIndex.Add($"{_fileCounter}");
                        invertedIndex.Add(c,_fileIndex);
                    }
                    else
                    {
                        invertedIndex.GetValueOrDefault(c).Add($"{_fileCounter}");
                    }
                }
            }
        }
    }
    public Dictionary<string,HashSet<string>> GetInvertedIndex()
    {
        return invertedIndex; 
    }
}