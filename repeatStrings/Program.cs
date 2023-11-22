using System.Text;

List<string> input = Console.ReadLine().Split().ToList();

StringBuilder result  = new StringBuilder();

for  (int i = 0; i < input.Count; i++)
{
    string currentWord = input[i];

    for (int j = 0; j < currentWord.Length; j++)
    {
        result.Append(currentWord);
    }
}

Console.WriteLine(result);