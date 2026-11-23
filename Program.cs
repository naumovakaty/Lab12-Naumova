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
for (int i = 1; i <= 40; i++)
{
    if (i % 3 == 0)
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


Console.WriteLine();
// Вариант 3
// Задача 1
for(int i = 1; i <= 14; i++)
{
    Console.WriteLine($"День {i}");
}


Console.WriteLine();
//Задача 2
int summa = 0;
int n = 1;
while (n <= 25)
{
    if (n % 2 != 0)
    {
        summa += n;
    }
    n++;
}
Console.WriteLine($"Сумма нечётных чисел {summa}");


//Задача № 3
string text = "TEMPERATURE";
int t_count = 0;
foreach (char letter in text)
{
    if (letter == 'T')
    {
        t_count++;
    }
}
Console.WriteLine($"Буква встретилась {t_count} раз");

//Задача 4
Console.WriteLine();
int count7 = 0;
for (int i = 1; i <= 50; i++)
{
    if (i % 7 == 0)
    {
        count7++;
    }
}
Console.WriteLine($"Количество чисел, кратных 7 {count7} ");

Console.WriteLine();
//Задача 5
int count_t = 0;
double sum_t = 0;
while (true)
{
    Console.WriteLine("Введите температуру (для входа введите 100)");
    double temp = Convert.ToDouble(Console.ReadLine());
    if (temp == 100)
    {
        break;
    }
    sum_t += temp;
    count_t++;
}
if (count_t > 0)
{
    double average = sum_t / count_t;
    Console.WriteLine($"Количество показаний: {count_t}");
    Console.WriteLine($"Средняя температура {average:F2}");
}
else
{
    Console.WriteLine("Показаний нет");
}
