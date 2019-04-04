using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("Введите первое число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Int32.Parse(Console.ReadLine());           
            int z = x + y;
            Console.WriteLine($"Сумма = {z}");
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Введите первое число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("Сумма равна - ");
            int z1 = Int32.Parse(Console.ReadLine());
            int z = x + y;
            Console.WriteLine(z1 == z ? "Верно" : "Неверно");
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Введите первое число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("Сумма равна - ");
            int z1 = Int32.Parse(Console.ReadLine());
            int z = x + y;
            if (z == z1)
            {
                Console.WriteLine("Верно");
                Console.Write("Введите число ");
                int ch = int.Parse(Console.ReadLine());
                Console.WriteLine(ch > z ? $"{ch} больше {z}" : $"{ch} меньше {z}");
            }
            else
            {
                Console.WriteLine("Неверно");
            }                        
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Введите первое число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Int32.Parse(Console.ReadLine());
            Console .Write("Что требуется: сложить или вычесть? - ");
            string @operator = Console.ReadLine();
            switch (@operator)
            {
                case "сложить":
                    Console.Write("Сумма равна - ");
                    int z1 = Int32.Parse(Console.ReadLine());
                    int z = x + y;
                    if (z == z1)
                    {
                        Console.WriteLine("Верно");
                        Console.Write("Введите число ");
                        int ch = int.Parse(Console.ReadLine());
                        Console.WriteLine(ch > z ? $"{ch} больше {z}" : $"{ch} меньше {z}");
                    }
                    else
                    {
                        Console.WriteLine("Неверно");
                    }
                    break;
                case "вычесть":
                    Console.Write("Разность равна - ");
                    int z2 = Int32.Parse(Console.ReadLine());
                    int rz= x - y;
                    if (z2 == rz)
                    {
                        Console.WriteLine("Верно");
                        Console.Write("Введите число ");
                        int ch = int.Parse(Console.ReadLine());
                        Console.WriteLine(ch > z2 ? $"{ch} больше {z2}" : $"{ch} меньше {z2}");                        
                    }                    
                    else
                    {
                        Console.WriteLine("Неверно");
                    }
                    break;
                default:
                    Console.WriteLine("Введите 'сложить' или 'вычесть'");
                    break;
            }
            
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {            
            Console.WriteLine("Введите первое число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("Что требуется: сложить или вычесть? - ");
            string @operator = Console.ReadLine();
            int i = 0;
            Console.WriteLine("Вам дается 3 попытки чтобы решить эту задачу правильно");
            while (i<3)
            {
                switch (@operator)
                {
                    case "сложить":                        
                        Console.Write("Сумма равна - ");
                        int z1 = Int32.Parse(Console.ReadLine());
                        int z = x + y;
                        if (z == z1)
                        {
                            Console.WriteLine("Верно");
                            Console.Write("Введите число ");
                            int ch = int.Parse(Console.ReadLine());
                            if (ch == z)
                            {
                                Console.WriteLine("Числа равны");
                                i = 3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine(ch > z ? $"{ch} больше {z}" : $"{ch} меньше {z}");
                                i = 3;
                                break;
                            }                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Неверно");
                            i++;
                            if (i == 3)
                            {
                                break;
                            }
                            Console.WriteLine(i < 2 ? "У вас осталось две попытки" : "У вас осталась одна попытка");
                            break;
                        }
                        
                    case "вычесть":
                        Console.Write("Разность равна - ");
                        int z2 = Int32.Parse(Console.ReadLine());
                        int rz = x - y;
                        if (z2 == rz)
                        {
                            Console.WriteLine("Верно");
                            Console.Write("Введите число ");
                            int ch = int.Parse(Console.ReadLine());
                            if (ch == z2)
                            {
                                Console.WriteLine("Числа равны");
                                i = 3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine(ch > z2 ? $"{ch} больше {z2}" : $"{ch} меньше {z2}");
                                i = 3;
                                break;
                            }                            
                        }
                        else
                        {
                            Console.WriteLine("Неверно");
                            i++;
                            if (i == 3)
                            {
                                break;
                            }
                            Console.WriteLine(i < 2 ? "У вас осталось две попытки" : "У вас осталась одна попытка");
                            break;
                        }                        
                    default:
                        Console.WriteLine("Введите 'сложить' или 'вычесть'");
                        break;
                }               

            }

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            int[] arrayInt = new int[5];
            Console.WriteLine("Введите пять чисел");
            for (int j = 0; j < 5; j++)
            {
                arrayInt[j] = int.Parse(Console.ReadLine());
            }         
            Console.Write("Что требуется: сложить или вычесть? - ");
            string @operator = Console.ReadLine();
            int i = 0;
            Console.WriteLine("Вам дается 3 попытки чтобы решить эту задачу правильно");
            while (i < 3)
            {
                switch (@operator)
                {
                    case "сложить":
                        Console.Write("Сумма равна - ");
                        int z1 = Int32.Parse(Console.ReadLine());                        
                        int z = arrayInt.Sum();                   
                        if (z == z1)
                        {
                            Console.WriteLine("Верно");
                            Console.Write("Введите число ");
                            int ch = int.Parse(Console.ReadLine());
                            if (ch == z)
                            {
                                Console.WriteLine("Числа равны");
                                i = 3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine(ch > z ? $"{ch} больше {z}" : $"{ch} меньше {z}");
                                i = 3;
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Неверно");
                            i++;
                            if (i == 3)
                            {
                                break;
                            }
                            Console.WriteLine(i < 2 ? "У вас осталось две попытки" : "У вас осталась одна попытка");
                            break;
                        }

                    case "вычесть":
                        int rz = 0;
                        Console.Write("Разность равна - ");
                        int z2 = Int32.Parse(Console.ReadLine());                       
                        for (int j = 1; j < 5; j++)
                        {
                            rz = rz-arrayInt[j]; //- arrayInt[j + 1];
                        }                       
                        if (z2 == rz)
                        {
                            Console.WriteLine("Верно");
                            Console.Write("Введите число ");
                            int ch = int.Parse(Console.ReadLine());
                            if (ch == z2)
                            {
                                Console.WriteLine("Числа равны");
                                i = 3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine(ch > z2 ? $"{ch} больше {z2}" : $"{ch} меньше {z2}");
                                i = 3;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверно");
                            i++;
                            if (i == 3)
                            {
                                break;
                            }
                            Console.WriteLine(i < 2 ? "У вас осталось две попытки" : "У вас осталась одна попытка");
                            break;
                        }
                    default:
                        Console.WriteLine("Введите 'сложить' или 'вычесть'");
                        break;
                }

            }
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            // В предыдущих методах есть проверки на правильность введенного пользователем результата
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            Console.Write("Радиус круга равен - ");
            double  r = double.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);            
            Console.WriteLine($"Площадь круга равна - {Math.Round( s,2)}");
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.Write("Введите сумму - ");
            int sum = int.Parse(Console.ReadLine());
            Console.Write("Введите срок кредита в месяцах - ");
            double  term = double.Parse(Console.ReadLine());
            Console.Write("Введите процентную ставку ");
            decimal rate = decimal.Parse(Console.ReadLine());
            double p = (double)rate / 12 / 100;
            decimal monthPay = sum * ((decimal)p + (decimal)p / (decimal)(Math.Pow(1 + p, term) - 1));
            decimal total = monthPay * (decimal )term;
            Console.WriteLine($"Месячный платеж равен - {Math.Round( monthPay,2)}");
            Console.WriteLine($"Общая сумма платежа равна - {Math.Round( total,2)}");
        }
    }
}
