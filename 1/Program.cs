// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CheckZero(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

int[] InputMassive(int size)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = GetInfo($"Введите {i + 1}-е число: ");
    }
    return massive;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInfo("Введите количество чисел: ");
int[] massive = InputMassive(size);
PrintArray(massive);
Console.Write($" -> {CheckZero(massive)} (Количество чисел больше 0)");