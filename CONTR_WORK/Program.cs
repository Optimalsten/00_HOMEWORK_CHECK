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

// МЕТОД 1 - ЗАДАНИЕ натурального числа > 0,
// с контролем допустимости типа значения и величины, с рекурсией
int GetNumbIntContr(string message, out bool contrNum) // conrtNum - True (корректно)/False (некорректно)
{
    Console.Write($"\n Задайте число {message}");
    string numberStr = Console.ReadLine();
    contrNum = int.TryParse(numberStr, out int numN); // numN = 0 (если некорректно)

    if ((contrNum) && (numN > 0)) // обработка корректного значения
    {
        return numN;
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($" Заданное значение ({numberStr}) некорректно!");
    Console.ForegroundColor = ConsoleColor.White;
    return GetNumbIntContr(message, out bool contrN);
}

// МЕТОД 2 - ЗАДАНИЯ с клав-ы массива строк,
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

// int[] GetNumArr(int size, out bool contrNum) // ввод элементов массива, конверт.(контроль допустим.)
// {
//     int[] arrayNN = new int[size];
//     string numberStr;
//     contrNum = true; // интегратор контроля допустимости введеных значений True/False
//     bool contrTem; // переменная контроля допустимости текущего введенного значения
           
//     Console.WriteLine($"\nЗадайте массив NN[] из {size} элементов (целых чисел)" +
//     "\nдля последующего вывода массива на экран.\n");
    
//     for (int i = 0; i < size;  i++)
//     {
//         Console.Write($"Задайте значение {i}-го элемента массива. NN[{i}] = ");
//         numberStr = Console.ReadLine();

//         contrTem = int.TryParse(numberStr, out int numN);
//         contrNum = contrNum && contrTem;
        
//         arrayNN[i] = numN; // В случае некорректного ввода array[i] будет = 0
//     }
//     return arrayNN;
// }

void PrintScr(string [] diffCh) // вывод на экран результатов задания массива с клавиатуры
{
    int length = diffCh.Length;
    Console.Write($"\nЗадан массив строк из {length} элемента(ов):\n[  ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"'{diffCh[i]}'  ");
    }
    Console.Write($"]");
}









// О С Н О В Н О Й   К О Д

// Очистка экрана
Console.Clear();
Console.WriteLine();

// ЗАДАНИЕ с клав-ы РАЗМЕРА МАССИВА, с контролем допустимости задан.данных, вкл.тип значения
int sizeArr = GetNumbIntContr("элементов массива - натуральное (целое, положительное) \t N: ",
                             out bool contrN);

// ЗАДАНИЕ с клав-ы всех {sizeArr} элементов МАССИВА строк
string [] diffChar = new string [sizeArr]; // объявление массива строк длиной {sizeArr}
GetStringArr(diffChar); // обращение к методу 2 - задание с клав-ы элементов массива строк

// ВЫВОД на экран всех {sizeArr} элементов заданного с клавиатуры МАССИВА строк
PrintScr(diffChar); // обращение к методу 3 - вывод на экран заданных элементов массива

// Задержка экрана
Console.Write("\n Для продолжения нажмите любую клавишу...\n"); //  "\n - "возврат каретки"
Console.Read();
