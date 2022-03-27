using System;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1                     
            int a1 = 1;
            int b1 = 3;
            int result1 = CompareDigits(a1, b1);
            Console.WriteLine(result1);

            //Задание 2                        
            int x1 = 1;
            int y1 = 1;
            string result2 = GetQuarter(x1, y1);
            Console.WriteLine(result2);

            //Задание 3                       
            int a3 = 45;
            int b3 = 12;
            int c3 = 61;
            int[] nums3 = GetSorted(a3, b3, c3);
            Console.WriteLine(string.Join(" ", nums3));

            //Задание 4          
            double a4 = 1;
            double b4 = 4;
            double c4 = -9;
            string res4 = GetRoot(a4, b4, c4);
            Console.WriteLine(res4);

            //Задание 5            
            string string_number = "16";
            string s4 = ConvertNumberToText(string_number);
            Console.WriteLine(s4);

            //Задание 6  
            double a6 = 6;
            double b6 = 3;            
            double c6 = 10;
            bool res6 = TriangleExist(a6,b6,c6);
            Console.WriteLine(res6);
        }
        static int CompareDigits(int a1, int b1)
        {
            int result1 = 0;
            if (a1 > b1) result1 = a1 + b1;
            if (a1 == b1) result1 = a1 * b1;
            if (a1 < b1) result1 = a1 - b1;
            return result1;
        }

        static string GetQuarter(int x1, int y1)
        {
            if (x1 > 0 && y1 > 0)
                return "Первая четверть";
            else if (x1 > 0 && y1 < 0)
                return "Вторая четверть";
            else if (x1 < 0 && y1 < 0)
                return "Третья четверть";
            else if (x1 < 0 && y1 > 0)
                return "Четвертая четверть";
            else
                return "Центр окружности!";
        }

        static int[] GetSorted(int a3, int b3, int c3)
        {
            int[] nums = new int[] { a3, b3, c3 };
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }

        static string GetRoot(double a4, double b4, double c4)
        {
            if (Math.Pow(b4, 2) - 4 * a4 * c4 < 0 || a4 == 0)
                return "Корней нет";
            else if (Math.Pow(b4, 2) - 4 * a4 * c4 == 0)
            {
                double x4 = -b4 / (2 * a4);
                return "Корень один: " + x4;
            }
            else
            {
                double x4_1 = Math.Round(-b4 - Math.Sqrt(Math.Pow(b4, 2) - 4 * a4 * c4) / (2 * a4), 3);
                double x4_2 = Math.Round(-b4 + Math.Sqrt(Math.Pow(b4, 2) - 4 * a4 * c4) / (2 * a4), 3);
                return "Корня два: " + x4_1 + " " + x4_2;
            }
        }

        static string ConvertNumberToText(string string_number)
        {
            if (string_number.StartsWith('1'))
            {
                switch (string_number)
                {
                    case "10":
                        return "десять";
                        break;
                    case "11":
                        return "одинадцать";
                        break;
                    case "12":
                        return "двенадцать";
                        break;
                    case "13":
                        return "тринадцать";
                        break;
                    case "14":
                        return "четыернадцать";
                        break;
                    case "15":
                        return "пятнадцать";
                        break;
                    case "16":
                        return "шестнадцать";
                        break;
                    case "17":
                        return "семьнадцать";
                        break;
                    case "18":
                        return "восемьнадцать";
                        break;
                    case "19":
                        return "девятнадцать";
                        break;
                }
                return "";
            }
            else
            {
                string text = "";
                switch (string_number[0])
                {
                    case '2':
                        text = "двадцать";
                        break;
                    case '3':
                        text = "тридцать";
                        break;
                    case '4':
                        text = "сорок";
                        break;
                    case '5':
                        text = "пятьдесят";
                        break;
                    case '6':
                        text = "шестьдесят";
                        break;
                    case '7':
                        text = "семьдесят";
                        break;
                    case '8':
                        text = "восемьдесят";
                        break;
                    case '9':
                        text = "девяносто";
                        break;
                }
                switch (string_number[1])
                {
                    case '1':
                        text += " один";
                        break;
                    case '2':
                        text += " два";
                        break;
                    case '3':
                        text += " три";
                        break;
                    case '4':
                        text += " четыре";
                        break;
                    case '5':
                        text += " пять";
                        break;
                    case '6':
                        text += " шесть";
                        break;
                    case '7':
                        text += " семь";
                        break;
                    case '8':
                        text += " восемь";
                        break;
                    case '9':
                        text += " девять";
                        break;
                }
                return text;
            }
        }

        static bool TriangleExist(double a6,double b6,double c6)
        {
            return !(a6 >= b6 + c6 || b6 >= a6 + c6 || c6 >= a6 + b6);                
        }
    }
}
