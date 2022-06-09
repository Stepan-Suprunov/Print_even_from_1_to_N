// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Запрос на ввод N.
Console.WriteLine("Задайте число N");
int N = int.Parse(Console.ReadLine());
int i = 2;

// Вычисления и вывод решения.
if (N > 1) {
    do {
    Console.Write(i + ", ");
    i = i + 2;
    } while (i <= N);
}
else {
    Console.WriteLine("Слишком низкое значение N");
}