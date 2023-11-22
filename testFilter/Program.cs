string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string word in bannedWords)
{
    string censored = "";
    for (int i = 0; i < word.Length; i++)
    {
        censored += "*";
    }

    if (text.Contains(word))
    {
        text = text.Replace(word, censored);
    }
}
Console.WriteLine(text);

