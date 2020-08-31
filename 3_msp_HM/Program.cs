using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_msp_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = "======================";
            string userChoose = "";
            int userSquareNum;
            object userNum;
            do
            {
                Console.WriteLine("Все возможности программы: ");
                Console.WriteLine("1) Возведение числа в степень;");
                Console.WriteLine("2) Возведение в степень лесятичного числа;");
                Console.WriteLine("3) Вычисление корня числа;");
                Console.WriteLine("0) Exit;");
                Console.WriteLine("----------");
                Console.Write("Ваш выбор -> ");
                userChoose = Console.ReadLine();
                Console.WriteLine(separator);
                switch(userChoose)
                {
                    case "1":
                        Console.Write("Введите число возводимое в степень: ");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        userSquareNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------------");
                        Console.WriteLine($"Результат: {Math.Pow((int)userNum, userSquareNum)}");
                        Console.WriteLine(separator);
                        break;
                    case "2":
                        Console.Write("Введите десятичное число возводимое в степень: ");
                        userNum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        userSquareNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------------");
                        Console.WriteLine($"Результат: {Math.Pow((double)userNum, userSquareNum)}");
                        Console.WriteLine(separator);
                        break;
                    case "3":
                        string numTypeChoose;
                        Console.Write("Введите тип числа: 1-обычное(10, 25 и тд), 2-десятичное(1,2) -> ");
                        numTypeChoose = Console.ReadLine();
                        switch(numTypeChoose)
                        {
                            case "1":
                                Console.Write("Введите число ОБЫКНОВЕННОЕ для вычисления степени: ");
                                userNum = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("-----------------");
                                Console.WriteLine($"Результат: {Math.Sqrt((int)userNum)}");
                                Console.WriteLine(separator);
                                break;
                            case "2":
                                Console.Write("Введите число ДЕСЯТИЧНОЕ для вычисления степени: ");
                                userNum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("-----------------");
                                Console.WriteLine($"Результат: {Math.Sqrt((double)userNum)}");
                                Console.WriteLine(separator);
                                break;
                        }
                        break;
                    case "0":
                        Console.WriteLine("Ну пока!");
                        break;
                }
            } while (userChoose!="0");
            Console.ReadLine();
        }
    }
}
