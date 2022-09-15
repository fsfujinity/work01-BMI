using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work01_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("体重を入力してください(kg)");
            double weight = 0;
            bool parseSuccess = false;
            while (!parseSuccess)
            {
                string userWeight = Console.ReadLine() ?? "";
                parseSuccess = double.TryParse(userWeight, out weight);
                if (!parseSuccess)
                    Console.WriteLine("数値を入力してください");
            }
            Console.WriteLine("体重は" + weight.ToString("F2") + "です。");
            Console.WriteLine("身長を入力してください(m)");
            double height = 0;
            parseSuccess = false;
            while (!parseSuccess)
            {
                string userHeight = Console.ReadLine() ?? "";
                parseSuccess = double.TryParse(userHeight, out height);
                if (!parseSuccess)
                    Console.WriteLine("数値を入力してください");
            }
            Console.WriteLine("身長は" + height.ToString("F2") + "です。");
            double bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi.ToString("F4") + "です。");


            double appropriateweight = (height * height) * 22;
            Console.WriteLine("あなたの適正体重は" + appropriateweight.ToString("F1") + "です。");
        }
    }
}
