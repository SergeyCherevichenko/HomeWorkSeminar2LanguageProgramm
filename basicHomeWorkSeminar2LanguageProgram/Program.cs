using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace basicHomeWorkSeminar2LanguageProgram;
class Program
{
    static void Main(string[] args)
    {

        void Task10()

        {

            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            int Input() // Ввод числа
            {
                Console.WriteLine("Введите трехзначное целое число: ");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                return number;
            }


            int numberUser = Input();
            while (numberUser < 100 || numberUser >= 1000) // Проверка что число трехзначное
            {
                Console.WriteLine("Вы ввели не трехзначное целое число! Попробуйте еще раз!");
                numberUser = Input();
            }
            int result = numberUser / 10 % 10; // Получаем вторую цифру трехзнвчного числа
            Console.WriteLine($"Вторая цифра вашего числа: {result}");

        }

        void Task13()
        {
            // Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает,
            // что третьей цифры нет.


            int Input() // Ввод числа
            {
                Console.WriteLine("Введите любое целое число: ");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                return number;
            }

            int usernumber = Input();
            if (usernumber < 100) // Проверка является ли число трехзначным
            {
                Console.WriteLine($"В вашем числе {usernumber} нет третьей цифры");
            }
            else // Не зависимо скольки значное число( > 99) ролучаем его третью цифру
            {
                int result = usernumber;
                int remainder = 0;
                while (result > 99)
                {
                    remainder = result % 10;
                    result = result / 10;
                }

                Console.WriteLine($"В вашем числе {usernumber} третья цифра яявляется {remainder}");
            }

        }

        void Task15()
        {
            // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
            // и проверяет, является ли этот день выходным.
            string text1 = "Вашь день недели:";
            string text2 = ". Это выходной!";
            string text3 = ". Это рабочий день!";

            int Input() // Ввод дня недели
            {
                Console.WriteLine("Введите номер дня недели: ");
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }

            int dayWeek = Input();// Проверка что число действительно является днем недели
            while (dayWeek < 1 || dayWeek > 7)
            {
                Console.WriteLine($"Дня недели с таким номером  {dayWeek} не существует! Введите еще раз!");
                dayWeek = Input();
            }

            int day = dayWeek;
            if (day == 1) // Вывод согласно условия в зависимости от дня недели
            {
                Console.WriteLine(text1 + " Понедельник" + text3);
            }
            else if (day == 2)
            {
                Console.WriteLine(text1 + " Вторник" + text3);
            }
            else if (day == 3)
            {
                Console.WriteLine(text1 + " Среда" + text3);
            }
            else if (day == 4)
            {
                Console.WriteLine(text1 + " Четверг" + text3);
            }
            else if (day == 5)
            {
                Console.WriteLine(text1 + " Пятница" + text3);
            }
            else if (day == 6)
            {
                Console.WriteLine(text1 + " Суббота" + text2);
            }
            else
            {
                Console.WriteLine(text1 + " Воскресенье" + text2);
            }
        }

        void AdditionalTask1()
        {
            //Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

            int Input(string text) // Ввод  длин сторон треугольника 
            {
                Console.WriteLine(text);
                int lenghtSaidTriangle = Convert.ToInt32(Console.ReadLine());
                return lenghtSaidTriangle;
            }

            Console.WriteLine("Введите длинну сторон вашего треуголника");
            int lenghtSaidTriangleA = Input("Введите длинну первой стороны: ");
            int lenghtSaidTriangleB = Input("ВВедите длинну второй стороны: ");
            int lenghtSaidTriangleC = Input("Введите длинну третьей стороны: ");
            if (lenghtSaidTriangleA <= 0 || lenghtSaidTriangleB <= 0 || lenghtSaidTriangleC <= 0) //Проверка ввода  
            {
                Console.WriteLine("Такого треугольника не существует!");
            }
            else if (lenghtSaidTriangleA > lenghtSaidTriangleB + lenghtSaidTriangleC && lenghtSaidTriangleB > lenghtSaidTriangleA +
            lenghtSaidTriangleC && lenghtSaidTriangleC > lenghtSaidTriangleA + lenghtSaidTriangleB) //Проверка существования треугольника
            {
                Console.WriteLine($"Треугольника со сторонами {lenghtSaidTriangleA}, {lenghtSaidTriangleB}, {lenghtSaidTriangleC} " +
                "не существует!");
            }
            else if (lenghtSaidTriangleA == lenghtSaidTriangleB && lenghtSaidTriangleA == lenghtSaidTriangleC) // Равносторонний ли треугольник
            {
                Console.WriteLine($"Ваш треугольник со сторонами {lenghtSaidTriangleA}, {lenghtSaidTriangleB}, {lenghtSaidTriangleC} " +
                " является равностороним!");
            }
            else if (lenghtSaidTriangleA == lenghtSaidTriangleB || lenghtSaidTriangleB == lenghtSaidTriangleC ||
            lenghtSaidTriangleA == lenghtSaidTriangleC) // Равнобедренный ли треугольник
            {
                Console.WriteLine($"Ваш треугольник со сторономи {lenghtSaidTriangleA}, {lenghtSaidTriangleB}, {lenghtSaidTriangleC} " +
                  "является равнобедренным!");
            }
            else
            {
                Console.WriteLine($"Ваш треугольник со сторонами {lenghtSaidTriangleA}, {lenghtSaidTriangleB}, {lenghtSaidTriangleC}" +
                "существует, но не является равнобедренным или равностороним!"); //  Есть простой треугольник
            }




        }

        void AdditionalTask2()
        {
            // Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.

            int Input(string text) // Ввод  даты рождения
            {
                Console.WriteLine(text);
                int lenghtSaidTriangle = Convert.ToInt32(Console.ReadLine());
                return lenghtSaidTriangle;
            }

            int years = Input("Введите год рождения в фориате ГГГГ: ");// Ввод года и проверка
            while (years < 1000)
            {
                Console.WriteLine("Вы ввели не правильно год рождения. Пожалуйста введите в формате ГГГГ и от 1000 ");
                years = Input("Введите год рождения в фориате ГГГГ: ");
            }
            int userYears = years;//Ввод месяца и проверка
            int months = Input("Введите меяц рождения в формате M: ");
            while (months < 1 || months > 12)
            {
                Console.WriteLine("Вы ввели не правильно месяц рождения. Пожалуйста введите от 1 до 12 ");
                months = Input("Введите меяц рождения в формате MM: ");
            }
            int userMonths = months;// Ввод дня и проверка
            int day = Input("Введите день рождения в формате Д");
            while (day < 1 || day > 31)
            {
                Console.WriteLine("Вы ввели не правильно день рождения. Пожалуйста от 1 до 31");
                day = Input("Введите день рождения в формате Д");
            }
            int userDay = day;

            int resultYear = 2022 - userYears;
            if (resultYear < 0)// Если разница годов меньше 0 человек не родился
            {
                Console.WriteLine($"Человек c датой рождения {userDay} / {userMonths} / {userYears} на дату 01 / 07 / 2022  еще не родился");
            }
            else if (resultYear >= 0 && userMonths < 07) // Если год разница годов больше или равна 0 и месяц при этом меньше 07
                                                         // то считать разницу годов 
            {
                Console.WriteLine($"Человеку c датой рождения {userDay} / {userMonths} / {userYears}" +
                 $" на дату 01 / 07 / 2022  исполнилось - {resultYear} год(а)");
            }
            else if (resultYear >= 0 && userMonths > 07) //  Если год разница годов больше или равна 0 и месяц при этом ,больше 07
                                                         // то считать разницу годов -1 год
            {
                Console.WriteLine($"Человеку c датой рождения {userDay} / {userMonths} / {userYears}" +
                 $" на дату 01 / 07 / 2022  исполнилось - {resultYear - 1} год(а)");

            }
            else if (resultYear >= 0 && userMonths == 07) //  Если год разница годов больше или равна 0 и месяц при этом ,равен 07

            {
                if (userDay > 1) // Если день больше 1 числа то оставить разницу годов
                {
                    Console.WriteLine($"Человеку c датой рождения {userDay} / {userMonths} / {userYears}" +
                                                     $" на дату 01 / 07 / 2022  исполнилось - {resultYear} год(а)");
                }

                else if (userDay == 1) // Если день равен 1 числу то считать разницу годов + 1 и добавить что сегодня Д/Р
                {
                    Console.WriteLine($" У Человека c датой рождения {userDay} / {userMonths} / {userYears}" +
                                                        $" на дату 01 / 07 / 2022 исполнилось {resultYear + 1}  Cегодня день рождения!");
                }
                else // В других случаях отнимать от разницы годов 1 год
                {
                    Console.WriteLine($"Человеку c датой рождения {userDay} / {userMonths} / {userYears}" +
                                                     $" на дату 01 / 07 / 2022  исполнилось - {resultYear - 1} год(а)");
                }
            }

        }

        void AdditionalTask3()

        {
            // Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
            // Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

            Console.WriteLine("Депозит Ивана равен 1000 руб. Процентная ставка по вкладу равна 1,5% ежемесячно.");

            int Input() // Ввод количетсва месяцев
            {

                Console.WriteLine("Введите количество месяцев, через которое вы хотите узнать рамер депозита Ивана с учетом процентов:  ");
                int months = Convert.ToInt32(Console.ReadLine());
                return months;

            }
            int userMonth = Input();

            if (userMonth <= 0) // Проверка месяцев 1 и более
            {
                Console.WriteLine("Вы ввели не правильное количество месяцев оно должно быть не менее 1!");
                userMonth = Input();
            }

            double depozit = 1000;
            double interestRate = 1.5;
            int months = userMonth;

            while (months > 0) // Расчет депозита с условием, что каждый месяц размер депозита увеличивается на 1,5% 
            {
                depozit = depozit + depozit * interestRate / 100;
                months--;
            }


            Console.WriteLine($"Депозит Ивана в 1000 руб. через - {userMonth} месяц(ев) будет составлять {Math.Round(depozit, 2)} руб.");
        }

        void AdditionalTask4()
        {
            // Задача 4. Дано натуральное число, в котором все цифры различны. Определить,
            // какая цифра расположена в нем левее: максимальная или минимальная.
            int Input()
            {
                Console.WriteLine("Введитее любое натуральное число: ");
                bool repit = false;
                int number = 0;
                while (!repit)
                {

                    try
                    {

                        number = Convert.ToInt32(Console.ReadLine());
                        repit = true;

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($" Вы ввели дробное число! Попробуйте еще раз!");

                    }
                }

                return number;

            }

            int naturalNumber = Input();

            while (naturalNumber < 0)
            {
                Console.WriteLine("Вы ввели не натуральное число. Оно должно быть больше 0");
                naturalNumber = Input();
            }
            int MaxDigit = naturalNumber % 10;
            int MinDigit = naturalNumber % 10;
            int digit = naturalNumber;
            int count = 1;
            string text = "";
            if (naturalNumber < 10)
            {
                text = "Ваше натуральное число: " + digit + " однозначное! " +
                "Максимальная цифра в числе: " + MaxDigit + " =  Минимальная цифра в числе: " + MinDigit + " и стоят на одной позиции";
            }
            else
            {

                while (naturalNumber > 10)
                {
                    naturalNumber = naturalNumber / 10;
                    if (MaxDigit < naturalNumber % 10)
                    {
                        MaxDigit = naturalNumber % 10;
                    }
                    if (MinDigit > naturalNumber % 10)
                    {
                        MinDigit = naturalNumber % 10;
                    }

                    if (MaxDigit > MinDigit)
                    {
                        text = "Максимальная цифра в числе: " + MaxDigit + " стоит правее. " +
                        " Минимальная цифра в числе: " + MinDigit + " cтоит левее.";
                    }
                    if (MaxDigit < MinDigit)
                    {
                        text = "Максимальная цифра в числе: " + MaxDigit + "стоит левее. " +
                        " Минимальная цифра в числе: " + MinDigit + " cтоит правее.";
                    }
                    if (MaxDigit == MinDigit)
                    {
                        text = MaxDigit + " = " + MinDigit;
                    }

                    count++;
                }
            }

            Console.WriteLine($"Ваше натуральное число  {digit}  {count} значное");

            Console.WriteLine(text);

        }

        Console.Clear();
        AdditionalTask4();

    }
}

