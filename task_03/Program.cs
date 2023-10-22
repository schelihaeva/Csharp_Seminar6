// Задача 42:  Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10  // 

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ConvertToBinary(int num) //решение задачи при помощи рекурсии , можно ввести long- это больший тип данных чем 
{
    if(num == 0) return;
    ConvertToBinary(num / 2);
    System.Console.Write(num%2);
} 

// --------------------------

int dec = ReadInt("Введите число: ");
ConvertToBinary(dec);

//System.Console.WriteLine(Convert.ToString(dec, 2)); //конвертация в двуичное число

