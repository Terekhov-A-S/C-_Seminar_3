// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Вас приветствует искусственный интеллект Core 2.0!");
Console.Write("Введите число, для вывода таблицы кубов от единицы до указанного числа ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) { Console.WriteLine($"Число {num} меньше 1, магия не получится! "); return; }
int count = 1;
int result = count;
while (count <= num)
{
    result = count * count * count;
    Console.WriteLine($"{result} ");
    count++;
}
Console.WriteLine("Буду рад снова пообщаться с Вами!");
