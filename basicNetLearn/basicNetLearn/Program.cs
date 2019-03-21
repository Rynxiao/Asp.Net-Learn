using System;

namespace basicNetLearn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double x = 1993545.0112;
            int y = (int)x;
            Console.WriteLine(y);

            int z = Convert.ToInt32(y);
            Console.WriteLine(z);

            Object o = x;
            Console.WriteLine("1. x的值为{0}, 装箱之后的对象为{1}", x, o);
            o = 345.1234;
            Console.WriteLine("2. x的值为{0}, 装箱之后的对象为{1}", x, o);

            int xx = 12;
            int yy = 22;
            Console.WriteLine(Math.Sin(xx * xx + yy * yy));

            //Console.Write("请输入一个年份：");
            //String str = Console.ReadLine();
            //int year = Int32.Parse(str);
            //bool isLeapYear = ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));
            //String yesOrNo = isLeapYear ? "是" : "不是";
            //Console.WriteLine("{0}年{1}闰年", year, yesOrNo);

            String[] ls = new string[2] { "1", "2" };
            Console.WriteLine(ls[0]);

            Type myType = typeof(int);
            Console.WriteLine("类型：{0}", myType);

            String str1 = "string1111";
            String str2 = "testHelloWorld";
            Console.WriteLine(String.Compare(str1, str2));
            Console.WriteLine(str1.CompareTo(str2));
        }
    }
}
