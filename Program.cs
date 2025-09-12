using System.ComponentModel.DataAnnotations;

string RandomPassword(int length, bool numbers, bool uppercase, bool symbols)
{
    string lettersLower = "abcdefghijklmnopqrstuvwxyz";
    string lettersUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string digits = "0123456789";
    string special = ",.#%&?!@$£-_";

    string characters = lettersLower;
    if (numbers) {
        characters += digits;
    }
    if (uppercase) {
        characters += lettersUpper;
    }
    if (symbols) {
        characters += special;
    }

    string password = "";
    Random random = new Random();

    while (password.Length < length)
    {
        int randomIndex = random.Next(characters.Length);
        char c = characters[randomIndex];

        password += c;
    }

    return password;
}

string Word(Random random)
{
    //small list of words need more for actual password
    List<string> words = new List<string> { "the", "of", "to", "and", "a", "in", "is", "it", "you", "that", "he", "was", "for", "on", "are", "with", "as", "i", "his", "they" };
    int randomIndex = random.Next(words.Count);
    return words[randomIndex];
}

string WordPassword(int words, char separator, bool uppercase)
{
    string password = "";
    Random random = new Random();
    int uppercaseWord = random.Next(words-1);

    for (int i = 0; i < words; i++)
    {
        int randomLength = random.Next(2, 6);
        string word = Word(random);

        if (i == uppercaseWord && uppercase)
        {
            word = word.ToUpper();
        }
        if (i != words - 1)
        {
            word += separator;
        }

        password += word;
    }
    return password;
}

void RandomPasswordInput()
{ 
    bool numbers = false;
    bool uppercase = false;
    bool symbols = false;
    int length;

    Console.WriteLine("Length of password:");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        length = result;
    }
    else
    {
        return;
    }

    Console.WriteLine("numbers? (y/n)");
    input = Console.ReadLine();
    if (input == "y")
    { 
        numbers = true;
    }

    Console.WriteLine("uppercase letters? (y/n)");
    input = Console.ReadLine();
    if (input == "y")
    {
        uppercase = true;
    }

    Console.WriteLine("symbols? (y/n)");
    input = Console.ReadLine();
    if (input == "y")
    {
        symbols = true;
    }
    Console.WriteLine(RandomPassword(length, numbers, uppercase, symbols));
}

void WordPasswordInput()
{
    bool uppercase = false;
    char separator = '-';
    int length;

    Console.WriteLine("Number of words:");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int passLenght))
    {
        length = passLenght;
    }
    else
    {
        return;
    }

    Console.WriteLine("chose the separator (default '-')");
    input = Console.ReadLine();
    if (char.TryParse(input, out char sepChar))
    {
        separator = sepChar;
    }

    Console.WriteLine("uppercase word? (y/n)");
    input = Console.ReadLine();
    if (input == "y")
    {
        uppercase = true;
    }
    Console.WriteLine(WordPassword(length, separator, uppercase));
}

void Main()
{
    Console.WriteLine("what password type? - Random Password (r), Word Password (w)");
    string? input = Console.ReadLine();
    if (input == "r")
    {
        RandomPasswordInput();
    }
    else if (input == "w")
    {
        WordPasswordInput();
    }
}

while (true)
{
    Main();
}