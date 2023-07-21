// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна заданному количеству символов. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Функция ввода числового значения
int EnterNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// Функция заполнения строкового массива
void FillStringArrayByUser(string[] array)
{
    Console.WriteLine($"Введите последовательно элементы строкового массива размерности {array.Length}");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

// Функция печати строкового массива
void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");   
    }
    Console.Write($"{array[array.Length - 1]}");
}

// Функция определения длины нового массива
int LengthNewArray(string[] array, int limiterNumberCharacters)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limiterNumberCharacters)
        {
            length++;
        }
    }
    return length;
}

// Функция заполнения нового массива элементами длина которых меньше заданного значения.
void FillNewArray(string[] newArray, string[] array, int limiterNumberCharacters)
{
    int j = 0; // счётчик нового массива 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limiterNumberCharacters)
        {
            newArray[j] = array[i];
            j++;
        }
    }
}

// Основная программа
int lengthArray = EnterNumber("Введите длину строкового массива: ");
string[] array = new string[lengthArray];
FillStringArrayByUser(array);
int limiterNumberCharacters = EnterNumber("Введите ограничитель количества символов в строке: ");

int newLength = LengthNewArray(array,  limiterNumberCharacters);
string[] newArray = new string[newLength];
FillNewArray(newArray, array, limiterNumberCharacters);

Console.WriteLine("Элементы введенного массива:");
PrintStringArray(array);
Console.WriteLine();
Console.WriteLine($"Элементы нового массива в которых строки имеют длину меньшую или равную {limiterNumberCharacters}");
PrintStringArray(newArray);
