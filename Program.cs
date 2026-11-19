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