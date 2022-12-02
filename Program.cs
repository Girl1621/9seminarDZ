//Задача 64: Задайте значение N. Напишите метод, 
//который выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

//Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];
// FillArray(number, array);
// PrintArray(array);

// void FillArray(int number, int[] array, int count = 0)
// {
//     if (count + 1 > number)
//     {
//         return;
//     }
//     array[count] = count + 1;
//     count++;
//     FillArray(number, array, count);
// }

// void PrintArray(int[] array)
// {
//     for (int i = 1; i < array.Length; i++)
//     {
//         Console.Write($" {i}");
//     }
// }  

//Задача 66: Задайте значения M и N. Напишите метод, 
//который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!
// Console.Write("Введите число m: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int result = FindSum(M, N);
// Console.Write($"{result} ");
// int FindSum(int number1, int number2)
// { 
//     int count = 0;
//     if (number1 <= number2)
//     {
//       int temp = number1;
//       count += temp;
//       count += FindSum(number1+1, number2);
//     }
//     return count; 
// }


// Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите число n: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

int result = Akk(n, m);

Console.Write(result);

int Akk(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return Akk(n - 1, 1);
        }
        else
        {
            return Akk(n - 1, Akk(n, m - 1));
        }
    }
}