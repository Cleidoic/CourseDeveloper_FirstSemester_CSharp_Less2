/*
Проверка на ввод числа.
"Защита от дурака"
*/


int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        isCorrect = int.TryParse(message, out result);

        if(!isCorrect) {
            Console.WriteLine($"Ввели не число. Введите корректное число\n");
            message = Console.ReadLine();
        }
    }

    return result;
}

/*
Задача 1: Напишите программу, 
которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void SecondDigit(int num) {
    
    if (num < 100 || num > 1000) 
        Console.WriteLine($"Вы ввели не трёхзначное число, повторите попытку: {num}");
    else
        Console.WriteLine($"Вторая цифра введенного числа: {num%100/10}");

}

SecondDigit(472);

/*
Задача 2: Напишите программу, 
которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void ThirdDigit(int num) {

    int digit = 0;
    if (num < 100)
        Console.WriteLine($"В числе {num} нет третьей цифры");
    else {
        digit = num.ToString()[2] - '0';
        Console.WriteLine($"Третья цифра числа {num}: {digit}");
    }
}

ThirdDigit(154865);

/*
Задача 3: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void DayOfTheWeek (int day) {

    while (day < 1 || day > 7) {
        Console.WriteLine($"В неделе семь дней. Введите цифру от 1 до 7\n");
        day = GetNumber(Console.ReadLine());
    }
    if (day > 0 && day < 6)
        Console.WriteLine($"Сегодня не выходной");
    else
        Console.WriteLine($"Сегодня выходной");
}

DayOfTheWeek(GetNumber(Console.ReadLine()));