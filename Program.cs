// //Задача 1. Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void allNaturalNumber (int N)
// {
//     if (N >= 1) // условие окончание рекурсии
//     {
//         allNaturalNumber(N - 1); // на вход рекурсии нельзя давать тоже число что в методе 
        
//         Console.Write(N + " ");     
//     }
// }

// allNaturalNumber(10);

//Задание 2. Напишите программу,
// которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

int sumNumbers(int num)
{

    if (num != 0)
    {
        return sumNumbers(num / 10) + num % 10;
    }
    return num;  
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = sumNumbers(Math.Abs(num));
Console.WriteLine($"Сумма цифр числа {num} равна {sum}");