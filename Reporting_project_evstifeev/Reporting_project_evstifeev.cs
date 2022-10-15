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

void PrintinputArray(string[] inputArr)
{   
    Console.Write("[");
        for (int j = 0; j <  inputArr.Length; j++)
        {
            Console.Write((j !=  inputArr.Length - 1) ? $"{inputArr[j]}," : $"{inputArr[j]}");
        }
    Console.Write("] -> ");
} 

void PrintArray(string[] printArr)
{   
    Console.Write("[");
        for (int k = 0; k < printArr.Length; k++)
        {
            Console.Write((k != printArr.Length - 1) ? $"{printArr[k]}," : $"{printArr[k]}");
        }
    Console.Write("]");
} 

PrintinputArray(values);
PrintArray(GetArray(values));

