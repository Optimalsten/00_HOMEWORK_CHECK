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

// О С Н О В Н О Й   К О Д
//
// ЗАДАНИЕ с клав-ы РАЗМЕРА МАССИВА, с контролем допустимости задан.данных, вкл.тип значения
int sizeArr = GetNumbIntContr("элементов массива - натуральное (целое, положительное) \t N: ",
                             out bool contrN);
Console.Write($"\n Контрольная печать... Размер массива = {sizeArr}, проверка показала {contrN}\n");

// Задержка экрана
Console.Write("\n Для продолжения нажмите любую клавишу...\n"); //  "\n - "возврат каретки"
Console.Read();
