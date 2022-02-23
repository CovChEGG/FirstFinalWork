# Итоговая проверочная работа.

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

_Примеры результатов выполнения программы для проверки:_

    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

    ["1234", "1567", "-2", "computer science"] -> ["-2"]

    ["Russia", "Denmark", "Kazan"] -> []


# Выполнение задания 

## Версия 1 - с предварительно заданными значениями

[Исходный код](https://github.com/CovChEGG/FirstFinalWork/blob/main/FinalWork/Program.cs)

[Блок схема](https://github.com/CovChEGG/FirstFinalWork/blob/main/BlockDiagrammV1.png)

### Описание созданых методов

1. Создан метод (`CalcStringsNumberWithSizeEqualOrLessNeeded`) который _возвращает количество строк_, в полученном через первый аргумент массиве, соответстующих параметру поиска строк, определённому заданием, получаемый через второй аргумент.

    + тип возвращаемого значения `int`;

    + аргументы и их типы 
    
        `string[] arrayOfStrings` и `int sizeOfString`

    + инициализируем переменную-счётчик для подсчёта искомых строк

        `int numberOfStrings = 0`;

    + перебирется массив при помощи цикла 
    `foreach`;

    + для опредедления совпадений длин строк условию меньше либо равным параметру второго аргумента (по заданию <= 3) используется оператор `if` и счётчик `numberOfStrings` который увеличивается на едеиницу при каждом совпадении;

    + возвращаем значение счётчика `numberOfStrings` равный количеству строк подходящих условию.

2. Создан метод (`CopyToNewStringsArrayWithSizeEqualOrLessNeeded`) который _возвращает новый массив с искомыми строками_ выбирамыми из массива строк полученных через первый аргумент, соответстующих параметру поиска строк, получаемый через второй аргумент. Для определения размера новго массива строк, происходит присвоение новой локальной переменной (`sizeOfNewArray`) результата вызова метода (`CalcStringsNumberWithSizeEqualOrLessNeeded`) из п. 1, предавая ему полученные на входе аргументы.

    + тип возвращаемого значения `string[]`;

    + аргументы и их типы `string[] arrayOfStrings`, `int neededSizeOfString`;

    + инициализируется локальная переменная
        `int sizeOfNewArray` возвращаемым значением метода `CalcStringsNumberWithSizeEqualOrLessNeede` с передваваемыми ему значениями аргументов `arrayOfStrings` и `neededSizeOfString`;
    + инициализируется новый массив строк newArrayOfStrings
    
    + инициалицируем локальную переменную `int j = 0` отвечающую за текущий индекс нового массива строк;

   + перебирется массив при помощи цикла 
    `foreach`;

    + проверяем соотвеетствие длин строк меньше либо равным параметру второго аргумента (по заданию <= 3); для этого используется оператор `if` и строка нового массива `newArrayOfStrings[j]` которой присваивается текущее значение строки исходного массива `currentString` при выполнении условия, а также после присвоения происходит увеличение текущего индекса нового массива `j` на еденицу;

    + возвращаем новый, заполненный массив строк `newArrayOfStrings`.

3. Создан ничего не возвращающий метод (`PrintStringsArray`) производящий _выввод в консоли на экран элементов одного массива строк_ в заданном по примерам из задания - образцу; массив строк принимается посредством одного единственного аргумента этого метода.

    + метод не возвращает значений - тип `void`;

    + тип и наименование принимаемого аргумента `string[] stringsArray`;

    + производится вывод в консоль символа `[`;

    + производится вывод строк массива в окружении символов двойных кавычек `"{stringsArray[i]}"` в консоль с помощью цикла `for`, а также после каждого элемента, кроме последнего (исползуется оператр `if`) выводим символы `, `(запятая и пробел)

    + производится вывод в консоль символа `]`;


4. Чтобы осуществить _вывод результата работы алгоритма_ создан ничего не возвращающий метод (`PrintTwoStringsArray`) который принимает в качестве двух аргументов два массива строк. Превый аргумент предназначен для вывода исходного массива и первым передаётся методу (`PrintStringsArray`) из п. 3. Затем производится вывод в консоль символов "`  ->  `". Последним действием этого метода выводится второй аргумент, предназначенный для вывода результирующего массива, через второй вызов метода (`PrintStringsArray`) с этим аргументом.

    + метод не возвращает значений - тип `void`;

    + тип и наименование принимаемых аргументов:
    
        `string[] initialStringsArray`, `string[] resultStringsArray`

    + вызвыватся для печати исходного массива метод `PrintStringsArray`с передачей в качестве аргумента `initialStringsArray`.

    +  производится вывод в консоль символов `  ->  ` (пробел + дефис + знак больше + пробел);

    + вызвыватся для печати результирующего массива метод `PrintStringsArray` с передачей в качестве аргумента `resultStringsArray`.

### Выполнение алгоритма

5. Производится задание исходных параметров:
    + первоначальным массивом строк (`initialStringsArray`) которому присваюиваются уже имеющиеся значения; из него производится последующий поиск требуемых значений;
    + переменной (`stringSizeParam`) в которой явно указываем основной параметр для поиска; этот параметр введен для удобства чтения и понимания алгоритма, а также для быстрой модификации последнего, в простейшем случае.
6. Далее произовдится инициализация результирующего массива строк (`resultStringsArray`) с присовением искомого результата возвращаемого в виде массива строк методом из п.2 (`CopyToNewStringsArrayWithSizeEqualOrLessNeeded`) с передаваемыми ему аргументами из п.5 (`initialStringsArray, stringSizeParam`).
7. Произовдим вывод в консоль, в требуемом по заданию формате, вызывая метод из п.4 (`PrintTwoStringsArray`), передавая ему в качестве первого аргумента - первоначальный массив строк из п.5 (`initialStringsArray`) и в качестве второго аргумента - результирующий массив строк из п.6 (`resultStringsArray`).

### Результаты работы программы:
    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

    ["1234", "1567", "-2", "computer science"] -> ["-2"]

    ["Russia", "Denmark", "Kazan"] -> []

### Блок схема

![Блок схема первой версии](https://github.com/CovChEGG/FirstFinalWork/blob/main/BlockDiagrammV1.png)

[Блок схема первой версии в новом окне](https://github.com/CovChEGG/FirstFinalWork/blob/main/BlockDiagrammV1.png)