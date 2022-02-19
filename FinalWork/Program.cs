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