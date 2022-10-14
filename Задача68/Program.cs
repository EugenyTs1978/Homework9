/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m -1, 1);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int userNum1 = Convert.ToInt32(Console.ReadLine());
int userNum2 = Convert.ToInt32(Console.ReadLine());
int valueAckermann = AckermannFunction(userNum1, userNum2);
Console.WriteLine($"A({userNum1}, {userNum2}) = {valueAckermann}");
