// we can reduce the code using the built-in features
/*
string[] InputStringFromConsole(char[] separators)
{
    string inputStr = Console.ReadLine() ?? String.Empty;
    string[] stringArray = inputStr.Split( separators , StringSplitOptions.RemoveEmptyEntries);
    Console.Clear();
    return stringArray;
}
*/

bool IsSeparatorCheck(char element, char[] separatorsArray)
{
    foreach (var item in separatorsArray)
    {
        if (item == element) return true;
    }
    return false;
}

int HowManyWords(string inputStr, char[] separatorsArray)
{
    int numOfWords = 0;
    int isWord = 0;
    foreach (var element in inputStr)
    {
        if (IsSeparatorCheck(element, separatorsArray))
        {
            isWord = 0;
        }
        else
        {
            if (isWord == 0)
            {
                numOfWords++;
                isWord = 1;
            }
        }
    }
    return numOfWords;
}

string[] InputStringFromConsole(char[] separatorsArray)
{
    string inputStr = Console.ReadLine() ?? String.Empty;
    int numOfWords = HowManyWords(inputStr, separatorsArray);
    string[] inputStringsArray = new string[numOfWords];
    int indexStrArr = 0;
    int isWord = 0;
    foreach(var currentElement in inputStr)
    {
        if (IsSeparatorCheck(currentElement, separatorsArray))
        {
            if (isWord == 1)
            {
                indexStrArr++;
                isWord = 0;
            }
        }
        else
        {
            if (isWord == 1)
            {
                inputStringsArray[indexStrArr] += Convert.ToString(currentElement);
            }
            else
            {
                inputStringsArray[indexStrArr] = Convert.ToString(currentElement);
                isWord = 1;
            }
        }
    }
    return inputStringsArray;
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

int CalcStringsNumberWithSizeEqualOrLessNeeded(string[] arrayOfStrings, int sizeOfString)
{
    int numberOfStrings = 0;
    foreach (var currentString in arrayOfStrings)
    {
        if (currentString.Length <= sizeOfString)
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

Console.WriteLine("Input words through \"spaces\" for text analysis and press \"Enter\":");
char[] separators = { ' ' }; //You may use one char symbols for separator
string[] initialStringsArray = InputStringFromConsole(separators);
int stringSizeParameter = 3;
string[] resultStringsArray = CopyToNewArrayStringsWithSizeEqualOrLessNeeded(initialStringsArray, stringSizeParameter);
Console.Clear();
PrintTwoArraysOfStrings(initialStringsArray, resultStringsArray);

Console.WriteLine();