/* Написать программу, которая из имеющегося массива строк формирует массив строк 
длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами. */

Console.WriteLine("Введите любые символы через ','");

string[] values = Console.ReadLine().Split(new char[] { ',' });

string[] GetArray(string[] inputArray)
{
    int count = 0;
    int length = 3;
    int pos = 0;
        string[] array = new string[inputArray.Length];
            for(int i = 0; i < array.Length; i++)
            {
                if(inputArray[i].Length <= length) 
                {
                array[pos] = inputArray[i];
                pos++;
                }
                else count++;
            }
    Array.Resize(ref array, array.Length - count); 
    return array;
}

void PrintArray(string[] printArr)
{   
    Console.Write("[");
    for (int j = 0; j < printArr.Length; j++)
    {
        Console.Write($"{printArr[j]},");
    }
    Console.Write("]");
    Console.WriteLine();
} 

PrintArray(GetArray(values));

