namespace TextSearch;

public interface IUserPanel
{
    public HashSet<string> Search(string[] arrWords);
    public void SetFinalFile(Dictionary<string, HashSet<string>> finalFile);
    public string[] GetInput();
    public void ShowResult(HashSet<string> finaFilesNumbers);
}