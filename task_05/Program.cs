//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using System.Reflection.Metadata.Ecma335;

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);

    return tempArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];

    return copyArray;
}

//------------------------------
int[] myArray = GenerateArray(5, -5, 5);
PrintArray(myArray);

int[] secondArray = myArray[..]; 
int[] thirdArray = CopyArray(myArray);

myArray[0] = 100;

PrintArray(myArray);
PrintArray(secondArray);
PrintArray(thirdArray);