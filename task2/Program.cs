/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
//получить число с консоли
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int M = GetNumber("Введите первое число:");
int N = GetNumber("Введите второе  число:");

// нахождение суммы натуральных чисел в промежутке

int Summ(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + Summ(M, N - 1); 
    else return N + Summ(M, N + 1);            
}

Console.WriteLine($"Сумма = {Summ(M, N)}");
Console.ReadLine();