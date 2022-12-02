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

// int sumNumbers(int num)
// {

//     if (num != 0)
//     {
//         return sumNumbers(num / 10) + num % 10; // рекурсия дробит число и складывает остатки от деления
//     }
//     return num;  
// }

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = sumNumbers(Math.Abs(num));
// Console.WriteLine($"Сумма цифр числа {num} равна {sum}");

// Задача 3. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"


// m=start n=finish
// void findInterval(int start, int finish)
// {
//     if (start != finish)
//     {
//         if ( start > finish)
//         {
//             findInterval(start - 1, finish);
//             Console.Write(start + " ");

//         }
//         else
//         {
//             findInterval(start, finish - 1);
//             Console.Write(finish + " ");

//         }
//     }
//     else Console.Write(start + " ");
// }

// Console.WriteLine("Введите начало промежутка ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конец промежутка ");
// int finish = Convert.ToInt32(Console.ReadLine());

// findInterval(start, finish);


//Задача 4.Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int powNumber (int A, int B)
{
    if (B > 1)
    {
        return A * powNumber (A, B - 1); 
    }
    return A;
}

Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(powNumber(A,B));