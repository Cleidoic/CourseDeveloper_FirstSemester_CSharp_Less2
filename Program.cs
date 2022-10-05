/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Семинар_1:

/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат
 (число умноженное на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/
______________________

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine(); 

//получаем числовое значение из строкового
int number = Convert.ToInt32(numberStr); 
int result = number * number;

Console.WriteLine($"{number} -> {result}");
Console.WriteLine("{number} -> {result}");
Console.WriteLine(number + " -> " + result);


___________________________________________________________________________



. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
_____________________

Console.WriteLine("Введите первое число");
string firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число");
string secondNumber = Console.ReadLine();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);

if (firstNum == secondNum * secondNum)

    Console.WriteLine($"Число {firstNum} является квадратом {secondNum}");

else

    Console.WriteLine($"Число {firstNum} не является квадратом {secondNum}");


____________________________________________________________________________



4. Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда 
5 -> Пятница
_________________

/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница
*/

Console.WriteLine("Введите число от 1 до 7");
string dayOfTheWeek = Console.ReadLine();

if (dayOfTheWeek == "1")
Console.WriteLine("Понедельник");

else if (dayOfTheWeek == "2")
Console.WriteLine("Вторник");

else if (dayOfTheWeek == "3")
Console.WriteLine("Среда");

else if (dayOfTheWeek == "4")
Console.WriteLine("Четверг");

else if (dayOfTheWeek == "5")
Console.WriteLine("Пятница");

else if (dayOfTheWeek == "6")
Console.WriteLine("Суббота");

else if (dayOfTheWeek == "7")
Console.WriteLine("Воскресенье");

else 
Console.WriteLine("Вы ввели не верное число, не указаное в условиях задачи. Необходимо ввести число от 1 до 7");


___________________________________________________________________



5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
_________________

int number = 0;
Console.write


____________________________________________________________________



7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
_________________

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 1000 && number>99)  
{
   Console.WriteLine(number%10);
}
else
    Console.WriteLine("Введено не трехзначное число");




************************************************************************


Семинар 2:


_______________________________________________________________________


/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/

____________________


//получение рандомного числа от minValue до maxValue
int GetNumber(int minValue, int maxValue)
{
    Random rnd = new Random();
    int result = rnd.Next(minValue, maxValue); // [10, 100) -> [10, 99]
    return result;
}

//получение максимальной цифры числа
int GetMaxDigitOfNumber(int number)
{ 
    int firstDigit = number / 10; // 95 / 10 = 9,5 -> 9
    int secondDigit = number % 10; // 95 % 10 = 5

    if(firstDigit > secondDigit)
      return firstDigit;
    else
      return secondDigit;
}

int number = GetNumber(10, 100);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number}: {maxDigit}");



_______________________________________________________________________


Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

__________________________


void AnswerToTask(){

    int newNumeric = (new Random()).Next(100,1000);
    Console.WriteLine($"Base numeric: {newNumeric}");    
    string numericAsString = newNumeric.ToString();
    int result = int.Parse(numericAsString[0].ToString() + numericAsString[2].ToString());
    Console.WriteLine($"Result numeric: {result}");

}

AnswerToTask();

_______________________________________________________________________


12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

___________________________


void CompareNumb (int num1, int num2)
{
    int num3 = num1 % num2;
    if (num3 == 0)
        Console.WriteLine("Второе число кратное");
    else
        Console.WriteLine($"Второе число не кратоне первому. Остаток {num3}");
}

CompareNumb(16,4);

_________________________________________________________________________


14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да

___________________________


void  GetNumber (int number)
{
    int result = number%7;
    int result1 = number%23;
    if (result==0 & result1==0)
    {
        Console.WriteLine($"{number}-> да");
    } 
    else
    Console.WriteLine($"{number} -> нет");
}
GetNumber(161);

__________________________________________________________________________


16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

_____________________________

void  Square(int num_1, int num_2)
{
    if (num_1 * num_1 == num_2) 
        Console.WriteLine($"Да. Число {num_1} является квадратом {num_2}");
    else if (num_2 * num_2 == num_1)
        Console.WriteLine($"Нет. Число {num_1} не является квадратом {num_2}");
}

Square(5, 25);

______________________________

void GetResult(int firstNumeric, int secondNumeric){


    if(firstNumeric * firstNumeric == secondNumeric){
        Console.WriteLine($"Numeric {secondNumeric} = {firstNumeric}^2");
        return;
    }

    if(secondNumeric * secondNumeric == firstNumeric){
        Console.WriteLine($"Numeric {firstNumeric} = {secondNumeric}^2");
        return;
    }
        
    Console.WriteLine($"It's so bad result =(");

}

GetResult(16, 4);



________________________________________________________________________________


Защита от дурака, проверяет, что введено число:

_____________________


int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        isCorrect = int.TryParse(Console.ReadLine(), out result);

        if(!isCorrect)
          Console.WriteLine("Ввели не число, введите корректное число");

        Console.WriteLine();
    }

    return result;
}




/*
reference (ссылочные) - string, list, class, dictionary, arrays...
value (значимые) - datetime, enum, struct, decimal, long, double, bool...

стек и управляемая куча

стек - значимые
куча - ссылочные
*/





