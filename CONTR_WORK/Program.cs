// Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// МЕТОД 1 (функция) - ЗАДАНИЕ натурального числа > 0,
// с контролем допустимости типа значения и величины, с рекурсией
int GetNumbIntContr(string message)
{
    Console.Write($"\n Задайте число {message}");
    string numberStr = Console.ReadLine();
    
    // conrtNum - True (корректно)/False (некорректно)
    bool contrNum = int.TryParse(numberStr, out int numN); // numN = 0 (если некорректно)

    if ((contrNum) && (numN > 0)) // обработка корректного значения
    {
        return numN;
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($" Заданное значение ({numberStr}) некорректно!");
    Console.ForegroundColor = ConsoleColor.White;
    return GetNumbIntContr(message);
}

// МЕТОД 2 - ЗАДАНИЯ с клав-ы массива строк
void GetStringArr(string [] diffCh)
{
    int size = diffCh.Length;
    Console.WriteLine($"\n Задайте последовательно {size} строк - элементов массива.");
    
    for (int i = 0; i < size;  i++)
    {
        Console.Write($" Введите значение {i+1}-го элемента массива : ");
        diffCh[i] = Console.ReadLine();
    }
}

// МЕТОД 3 - ВЫВОД на экран передаваемого методу массива строк
void PrintScr(string [] diffCh)
{
    int length = diffCh.Length;
    Console.Write($"\nЗадан массив строк из {length} элемента(ов)," +
    " каждый элемент обрамлен круглыми скобками :\n[  ");
    for (int i = 0; i < length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"({diffCh[i]})");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("  ");
    }
    Console.Write($"]");
}









// О С Н О В Н О Й   К О Д

// Очистка экрана
Console.Clear();
Console.WriteLine();

// ЗАДАНИЕ с клав-ы РАЗМЕРА МАССИВА, с контролем допустимости задан.данных, вкл.тип значения
int sizeArr = GetNumbIntContr("элементов массива - натуральное (целое, положительное) \t N: ");

// ЗАДАНИЕ с клав-ы всех {sizeArr} элементов МАССИВА строк
string [] diffChar = new string [sizeArr]; // объявление массива строк длиной {sizeArr}
GetStringArr(diffChar); // обращение к методу 2 - задание с клав-ы элементов массива строк

// ВЫВОД на экран всех {sizeArr} элементов заданного с клавиатуры МАССИВА строк
PrintScr(diffChar); // обращение к методу 3 - вывод на экран заданных элементов массива

// Задержка экрана
Console.Write("\n Для продолжения нажмите любую клавишу...\n"); //  "\n - "возврат каретки"
Console.Read();
