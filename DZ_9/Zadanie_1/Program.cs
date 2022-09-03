/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) return;

int sum = 0;
int SumNumbers (int firstNum, int secondNum)
{
    if (firstNum > secondNum) return sum;
    return firstNum + SumNumbers(firstNum + 1, secondNum);    
}
Console. WriteLine($"Сумма элементов от {m} до {n} равна {SumNumbers(m, n)}");
