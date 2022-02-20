void PrintStringsArray(string[] stringsArray)
{
    Console.Write("[");
    for (int i = 0; i < stringsArray.Length; i++)
    {
        Console.Write($"\"{stringsArray[i]}\"");
        if (i != stringsArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void PrintTwoStringsArray(string[] initialStringsArray, string[] resultStringsArray)
{
    PrintStringsArray(initialStringsArray);
    Console.Write(" -> ");
    PrintStringsArray(resultStringsArray);
    Console.WriteLine();
}

int CalcStringsNumberWithSizeEqualOrLessNeeded(string[] arrayOfStrings, int sizeOfString)
{
    int numberOfStrings = 0;
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length <= sizeOfString)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] CopyToNewStringsArrayWithSizeEqualOrLessNeeded(string[] arrayOfStrings, int neededSizeOfString)
{
    int sizeOfNewArray = CalcStringsNumberWithSizeEqualOrLessNeeded(arrayOfStrings, neededSizeOfString);
    string[] newArrayOfStrings = new string[sizeOfNewArray];
    int j = 0;
    foreach (var currentString in arrayOfStrings)
    {
        if (currentString.Length <= neededSizeOfString)
        {
            newArrayOfStrings[j] = currentString;
            j++;
        }
    }
    return newArrayOfStrings;
}

Console.Clear();

string[] initialStringsArray = {"hello", "2", "world", ":-)"}; // Sample 1 for testing
// string[] initialStringsArray = {"1234", "1567", "-2", "computer science"}; // Sample 2 for testing
// string[] initialStringsArray = {"Russia", "Denmark", "Kazan"}; // Sample 3 for testing
int stringSizeParam = 3;
string[] resultStringsArray = CopyToNewStringsArrayWithSizeEqualOrLessNeeded(initialStringsArray, stringSizeParam);
PrintTwoStringsArray(initialStringsArray, resultStringsArray);

Console.WriteLine();