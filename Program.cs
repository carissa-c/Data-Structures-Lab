
Console.WriteLine("Please enter a word you would like to reverse.");
string response = Console.ReadLine().ToLower().ToLower();

static string ReverseWord(string words)
{
    Stack<string> word = new Stack<string>();
    {
        for (int i = 0; i < words.Length; i++)
        {
            word.Push(words.Substring(i, 1));
        }

        foreach (string reversed = "")
        {
            word.Pop(reversed.Substring(0));
        }
    }
    Console.WriteLine(ReverseWord(response));

}




