string[] InputStringFromConsole(char[] separators)
{
    string inputStr = Console.ReadLine() ?? String.Empty;
    string[] stringArray = inputStr.Split( separators , StringSplitOptions.RemoveEmptyEntries);
    Console.Clear();
    return stringArray;
}

void PrintStringsArray(string[] arrayOfStrings)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        Console.Write($"\"{arrayOfStrings[i]}\"");
        if (i != arrayOfStrings.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void PrintTwoArraysOfStrings(string[] initialStringsArray, string[] resultStringsArray)
{
    PrintStringsArray(initialStringsArray);
    Console.Write(" -> ");
    PrintStringsArray(resultStringsArray);
    Console.WriteLine();
}

int CalcStringsNumberWithSizeEqualOrLessNeeded(string[] stringsArray, int stringSize)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringsArray.Length; i++)
    {
        if (stringsArray[i].Length <= stringSize)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] CopyToNewArrayStringsWithSizeEqualOrLessNeeded(string[] stringsArray, int stringSize)
{
    int sizeOfNewArray = CalcStringsNumberWithSizeEqualOrLessNeeded(stringsArray, stringSize);
    string[] newStringsArray = new string[sizeOfNewArray];
    int j = 0;
    foreach (var currentString in stringsArray)
    {
        if (currentString.Length <= stringSize)
        {
            newStringsArray[j] = currentString;
            j++;
        }
    }
    return newStringsArray;
}

Console.Clear();

Console.WriteLine("Input words through spaces for analizing text:");
char[] separators = {' '};
string[] initialStringsArray = InputStringFromConsole(separators);
int stringSizeParameter = 3;
string[] resultStringsArray = CopyToNewArrayStringsWithSizeEqualOrLessNeeded(initialStringsArray, stringSizeParameter);
PrintTwoArraysOfStrings(initialStringsArray, resultStringsArray);

Console.WriteLine();