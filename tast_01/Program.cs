// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void Reverse(int[] array) //  разворачиваем массив
{
    int temp = 0;

    for(int i = 0; i < array.Length / 2; i++) // обязательно массив делим на 2
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

// -------------------------------

int[] myArray = GenerateArray(6, -5, 5); // 6 элементов массиве, от -5 до 5 это диапазон массива
PrintArray(myArray); // вывод функции 
Reverse(myArray);
PrintArray(myArray);