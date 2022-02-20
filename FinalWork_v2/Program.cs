void PrintArrayOfStrings(string[] arrayOfStrings)
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

void PrintTwoArraysOfStrings(string[] arrayOfStrings, string[] newArrayOfStrings)
{
    PrintArrayOfStrings(arrayOfStrings);
    Console.Write(" -> ");
    PrintArrayOfStrings(newArrayOfStrings);
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

string[] stringArray = ;
int stringSizeEqualOrLessToSearch = 3;
string[] newArrayOfStrings = CopyToNewStringsArrayWithSizeEqualOrLessNeeded(stringArray, stringSizeEqualOrLessToSearch);
PrintTwoArraysOfStrings(stringArray, newArrayOfStrings);

Console.WriteLine();