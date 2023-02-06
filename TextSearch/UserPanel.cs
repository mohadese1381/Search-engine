namespace TextSearch;

public class UserPanel : IUserPanel
{
    private string _word;
    private HashSet<string> filesNumbers = new HashSet<string>();
    public void Search( Dictionary<string, HashSet<string>> finalFile)
    {
        Console.WriteLine("Enter a word you want to look up :");
        string _word = Console.ReadLine();
        if (finalFile.TryGetValue(_word, out HashSet<string> filesNumbers))
        {
            Console.WriteLine("Files that contain this word : ");
            foreach (var number in filesNumbers)
            {
                Console.Write($"{number}  ");
            }
        }
        else
        {
            Console.WriteLine("No such a word in my files:)");
        }

    }
}