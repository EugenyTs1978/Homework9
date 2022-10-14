/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
*/
void PrintArray(int Number)
{
    if (Number == 0)
    {
        return;
    }
    Console.Write(Number == 1? Number: Number + ",");
    PrintArray(Number - 1);
    
}
int userNumber = Convert.ToInt32(Console.ReadLine());
PrintArray(userNumber);
