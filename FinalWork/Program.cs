// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

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

int CalcStringsNumberWithSizeLessOrEqualNeeded(string[] arrayOfStrings, int sizeOfString)
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

string[] CopyToNewStringsArrayWithSizeLessOrEqualNeeded(string[] arrayOfStrings, int neededSizeOfString)
{
    int sizeOfNewArray = CalcStringsNumberWithSizeLessOrEqualNeeded(arrayOfStrings, neededSizeOfString);
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
