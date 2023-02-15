using System.Text;
using System.Text.RegularExpressions;


public class Word
{
    private Reference _reference;
    private List<Scripture> _scriptures;
    static Random random = new Random();

    public Word()
    {
        _reference = new Reference();
        _scriptures = _reference.GetScriptures();
    }

    public void ScriptureChoose()
        {
            Console.WriteLine("Please choose a scripture from the list below:");
            for (int i = 0; i < _scriptures.Count; i++)
            {
                Scripture scripture = _scriptures[i];
                string referenceString = scripture.GetReference();
                Console.WriteLine($"{i+1}) {referenceString}");
            }

            int choice = int.Parse(Console.ReadLine());
            Scripture chosenScripture = _scriptures[choice - 1];
            string chosenReference = chosenScripture.GetReference();
            string chosenText = string.Join("\n", chosenScripture.Verses.Select(v => v.Text));
            //Console.WriteLine($"{chosenReference} - {chosenText}");
            ReplaceWords(chosenReference, chosenText);
            //String of prove
            //string text = "But before ye seek for riches, seek ye for the kingdom of God.";
            //string result = ReplaceWords(text);
        }

    public static string ReplaceWords(string reference, string text) 
    {
        string[] words = text.Split(' ');
        int totalWords = words.Length;
        int replacedWords = 0;

        Console.Clear();
        Console.WriteLine($"{reference} > {text}");
        Console.WriteLine(" ");
        Console.Write("Enter the number of words to hide (1-10) or press 'q' to quit: ");
        string input = Console.ReadLine().Trim().ToLower();

        if (input == "q") 
        {
            return text;
        }

        if (!int.TryParse(input, out int numToReplace) || numToReplace < 1 || numToReplace > 10) 
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 6 or 'q' to quit.");
            return text;
        }

        while (replacedWords < totalWords) 
        {
            for (int i = 0; i < numToReplace && replacedWords < totalWords; i++) 
            {
                int index = random.Next(totalWords);
                while (words[index] == new string('_', words[index].Length)) 
                {
                    index = random.Next(totalWords);
                }
                words[index] = new string('_', words[index].Length);
                replacedWords++;
            }

            Console.Clear();
            Console.WriteLine($"{reference} > {string.Join(" ", words)}");

            if (replacedWords == totalWords) 
            {
                break;
            }

            Console.Write("Press Enter to continue or 'q' to quit: ");
            input = Console.ReadLine().Trim().ToLower();

            if (input == "q") 
            {
                return string.Join(" ", words);
            }

            int wordsLeft = totalWords - replacedWords;
            int numLeftToReplace = Math.Min(wordsLeft, numToReplace);
            for (int i = 0; i < numLeftToReplace && replacedWords < totalWords; i++) 
            {
                int index = random.Next(totalWords);
                while (words[index] == new string('_', words[index].Length)) 
                {
                    index = random.Next(totalWords);
                }
                words[index] = new string('_', words[index].Length);
                replacedWords++;
            }
            Console.Clear();
            Console.WriteLine($"{reference} > {string.Join(" ", words)}");
        }

        string result = string.Join(" ", words);
        //replaces all characters in a string that are not spaces with underscores.
        result = string.Join("", result.Select(c => c == ' ' ? ' ' : '_'));

        Console.Clear();
        Console.WriteLine($"{reference} > {result}");
        Console.Write("Press 'q' to quit: ");
        input = Console.ReadLine().Trim().ToLower();

        return result;
    }
}