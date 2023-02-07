namespace TextSearch;

public class UserPanel : IUserPanel
{
    private string _word;
    private string[] arrWords;
    private HashSet<string>_finalFilesNumbers = new HashSet<string>();
    private Dictionary<string, HashSet<string>> finalFile;

    public void SetFinalFile( Dictionary<string, HashSet<string>> finalFile)
    {
       this.finalFile = finalFile;
    }

    public string[] GetInput()
    {
        Console.WriteLine("Enter words you want to look up :");
        _word = Console.ReadLine();
        arrWords = _word.Split(" ");
        return arrWords;
    }
    public HashSet<string> Search(string[] arrWords)
    {
        foreach (var w in arrWords)
        {

            if ((!w.StartsWith("+") && !w.StartsWith("-")))
            {
                if (finalFile.TryGetValue(w, out HashSet<string> filesNumbers1))
                {
                    foreach (var number in filesNumbers1)
                    {
                        _finalFilesNumbers.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("There's no such a file");
                    System.Environment.Exit(1);
                }
            }
            else if (w.StartsWith("+"))
            {
                w.Remove(0);
                if (finalFile.TryGetValue(w, out HashSet<string> filesNumbers2))
                {
                    foreach (var number in filesNumbers2)
                    {
                        _finalFilesNumbers.Add(number);
                    }
                }
            }
        }

        return _finalFilesNumbers;
    }
    public void ShowResult(HashSet<string> _finalFilesNumbers)
    {
        foreach (var filesNumber in _finalFilesNumbers)
        {
            Console.Write($"{filesNumber} ");
        }
    }
}