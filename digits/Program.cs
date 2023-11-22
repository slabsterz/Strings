using System.Text;

string input = Console.ReadLine();
StringBuilder numbers = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder chars = new StringBuilder();

for  (int i = 0; i < input.Length; i++)
{
    char current = input[i];

    if (char.IsLetter(current))
    {
        letters.Append(current);
    }
    else if (char.IsDigit(current))
    {
        numbers.Append(current);
    }
    else
    {
        chars.Append(current);
    }
}
Console.WriteLine(numbers);
Console.WriteLine(letters);
Console.WriteLine(chars);