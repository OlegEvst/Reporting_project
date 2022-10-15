/* Написать программу, которая из имеющегося массива строк формирует массив строк 
длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами. */

Console.WriteLine("Введите любые символы через ','");

string[] values = Console.ReadLine().Split(new char[] { ',' });

string[] GetArray(string[] inputArray)
{
    string[] array = new string[inputArray.Length];

    for(int i = 0; i < array.Length; i++)
    {
        if(inputArray[i].Length <= 3)
        {
            array[i] = inputArray[i]; 
        }
    }
    return array;
}

void PrintArray(string[] printArr)
{
        for(int l = 0; l < printMx.GetLength(1); l++) 
        {
        Console.Write($"[");
        Console.Write($"{printMx[k,l]}, ");
        Console.Write($"\b\b]");   
        }
        Console.WriteLine("");
}


GetArray(values);