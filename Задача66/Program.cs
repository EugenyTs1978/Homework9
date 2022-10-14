/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/
int SumOfRange(int minNumber, int maxNumber)
{
    if (minNumber == maxNumber)
    {
        return minNumber;
    }
    return minNumber + SumOfRange(minNumber + 1, maxNumber);
}

int userMinNum = Convert.ToInt32(Console.ReadLine());
int userMaxNum = Convert.ToInt32(Console.ReadLine());
int userSum = userMaxNum>userMinNum?SumOfRange(userMinNum, userMaxNum):SumOfRange(userMaxNum, userMinNum);
Console.WriteLine(userSum);

