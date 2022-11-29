// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] CreateArray(int size)
{
    string []stringarray = new string [size];
    Console.WriteLine($"Размер массива {size}");
    for(int i = 0; i < size; i ++)
    {
        Console.Write($"Введите {i + 1} слово массива: ");
        stringarray[i] = Convert.ToString(Console.ReadLine());
    }
    return stringarray;
}

void ShowArray(string[]stringarray)
{
    for(int i = 0; i < stringarray.Length; i ++)
    Console.Write(stringarray[i]+  " ");
    Console.WriteLine();
}

string [] FindElements(string [] stringarray)
{
    string [] newArray = new string [stringarray.Length];
    int count = 0;

    for(int i = 0; i < stringarray.Length; i ++)
    {
        if(stringarray[i].Length <= 3)
        {
            newArray[count] = stringarray[i];
            count ++;
        }
    }
    return newArray;
}

 string []array = CreateArray(5);
 ShowArray(array);
 string[]newArray = FindElements(array);
 Console.WriteLine();
 ShowArray(newArray);
