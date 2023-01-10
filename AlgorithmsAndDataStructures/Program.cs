
// get number of words
Console.WriteLine("Please enter a number: ");
int numberOfWords = Int32.Parse(Console.ReadLine());

// initialize array with n words
string[] stringArray = new string[numberOfWords];
Console.WriteLine("Please enter " + numberOfWords + " words");
Console.WriteLine(" ");

// pushes n words to array
for (int i = 0; i < stringArray.Length; i++)
{
    stringArray[i] = Console.ReadLine();
}
Console.WriteLine(" ");

// lists all current words
Console.WriteLine("Your list of words is: ");
for (int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine(stringArray[i]);
}
Console.WriteLine(" ");

// sets the search term
Console.WriteLine("Please enter a character to search: ");
char searchCharacter = Char.Parse(Console.ReadLine());
Console.WriteLine(" ");

// concatenates the array of strings into a single string for iteration
string concatString = string.Join(", ", stringArray);
int count = 0;

foreach (char n in concatString)
{
    if (n == searchCharacter) count++;
}
Console.WriteLine("Your character " + "'" + searchCharacter + "'" + " shows up " + count + " times ");
