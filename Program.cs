using System.Globalization;

Console.WriteLine("Самостоятельная работа");
Console.WriteLine("Вариант1");
//Задача 1
for (int i = 1; i <= 8; i++){
    Console.WriteLine($" Урок {i}");
}
Console.WriteLine();
//Задача 2
int sum = 0;
int a = 1;
while (a <= 10)
{
    sum += a;
    a++;
}
Console.WriteLine($"Сумма чисел от 1 до 10 равна {sum}");


Console.WriteLine();
//Задача 3
string word = "PROGRAMMING";
int count = 0;
foreach (char letter in word)
{
    if(letter == 'M')
    {
        count++;
    }
}
Console.WriteLine($"Букв 'M' в строке {count}");


//задача 4
Console.WriteLine();
int Count = 0;
for (int j = 1; j <= 30; j++)
{
    if (j % 2 == 0)
    {
        Count++;
    }  
}
Console.WriteLine($"Ответ к задаче 4. Чётных чисел {Count}");

//Задача 5
Console.WriteLine();
int Count1 = 0;
int Sum = 0;
Console.Write("Введите оценки (для выхода введите -1)");
while (true)
{
    Console.WriteLine("Оценка ");
    if (int.TryParse(Console.ReadLine(), out int grade))
    {
        if (grade == -1)
        {
            break;
        }
        Count1++;
        Sum += grade;
    }
    else
    {
        Console.WriteLine("Введите число");
    }
}
Console.WriteLine($"Введено оценок : {Count1}");
Console.WriteLine($"Сумма всех оценок: {Sum} ");
//Вариант 2
//Задача № 1
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Раунд № {i}");
}


//Задача 2
int sum1 = 0;
int k = 1;
while (k <= 20)
{
    if (k % 2 == 0)
    {
        sum1 += k;
    }
    k++;
}
Console.WriteLine($"Сумма чётных чисел от 1 до 20: {sum1}");
Console.WriteLine();


//Задача 3
string nickname = "NeonBlade";
int count11 = 0;
foreach (char v in nickname)
{
    if (v == 'e' || v == 'E') {
        count11++;
    }
}
Console.WriteLine($"Количество букв 'e' равно {count11}");

Console.WriteLine();
//задача 4
int countN3 = 0;
for (n = 1; n <= 40; n++)
{
    if (n % 3 == 0)
    {
        countN3++;
    }
}
Console.WriteLine($"Чисел кратных 3 от 1до 40 всего {countN3}");


Console.WriteLine();
//Задача 5
//int count = 0;
int maxResult = int.MinValue;
int input;
Console.Write("Введите результаты участников (для выхода введите -1)");
while (true)
{
    Console.Write("Результаты: ");
    input = Convert.ToInt32(Console.ReadLine());
    if (input == -1)
    {
        break;
    }
    count++;
    if (input > maxResult)
    {
        maxResult = input;
    }
}
Console.WriteLine($"Количество введенных результатов: {count} ");
if (count > 0)
{
    Console.WriteLine($"Максимальный результат: {maxResult}");
}
else
{
    Console.WriteLine($"Результаты не были введены");
}