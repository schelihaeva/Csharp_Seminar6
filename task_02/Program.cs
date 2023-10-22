// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

string CheckTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return "Треугольник существует со сторонами такой длинны";
    return "Треугольник не существует со сторонами такой длинны";

}

Console.WriteLine("Введите длинну трёх сторон: ");
int[] myMrray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
if (myMrray.Length!=3) 
{   
    Console.WriteLine("Введено не три стороны!");
    return;
}

Console.WriteLine(CheckTriangle(myMrray[0],myMrray[1],myMrray[2]));