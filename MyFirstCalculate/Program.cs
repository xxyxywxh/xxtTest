using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("我的计算器");
        Console.WriteLine("=======================");
        inputNum01:
        Console.Write("请输入第一个数字：");
        string str1 = Console.ReadLine();
        if (str1.Trim().Length == 0)
        {
            Console.WriteLine("输入的不是数字！");
            goto inputNum01;
        }
        int Num1 = Convert.ToInt32(str1);
        if (Num1 < 0 || Num1 > 1000)
        {
            Console.WriteLine("输入的数字超出范围！");
            goto inputNum01;
        }

        inputNum02:
        Console.Write("请输入第二个数字：");
        string str2 = Console.ReadLine();
        if (str2.Trim().Length == 0)
        {
            Console.WriteLine("输入的不是数字！");
            goto inputNum02;
        }
        int Num2 = Convert.ToInt32(str2);
        if (Num2 < 0 || Num2 > 1000)
        {
            Console.WriteLine("输入的数字超出范围！");
            goto inputNum02;
        }

        Console.WriteLine("计算结果:{0} + {1} = {2}", Num1, Num2, Num1 + Num2);
        Console.WriteLine("计算完毕！");
        Console.ReadKey();
    }
}

