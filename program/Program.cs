void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива:d");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void NewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество строк массива");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Введённый первоначальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine("Полученный массив: ");
NewArray(array);