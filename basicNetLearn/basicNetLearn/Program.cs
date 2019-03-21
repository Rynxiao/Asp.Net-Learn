using System;
using System.Collections;

namespace basicNetLearn
{
    class MainClass
    {
        class C
        {
            public int Value = 0;
        }

        enum MyDate
        {
            Sun = 0,
            Mon = 1,
            Tue = 2,
            Wed = 3,
            Thi = 4,
            Fri = 5,
            Sat = 6
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int ls = 927;
            byte shj = 255;
            Console.WriteLine("ls={0}", ls);
            Console.WriteLine("shj={0}", shj);

            int v1 = 0;
            int v2 = v1;
            v2 = 927;
            C r1 = new C();
            C r2 = r1;
            r2.Value = 112;
            Console.WriteLine("Values: {0},{1}", v1, v2);
            Console.WriteLine("Refs: {0},{1}", r1.Value, r2.Value);

            int k = (int) DateTime.Now.DayOfWeek;
            switch (k)
            {
                case (int) MyDate.Sun:
                    Console.WriteLine("今天星期天");
                    break;
                case (int) MyDate.Mon:
                    Console.WriteLine("今天星期一");
                    break;
                case (int) MyDate.Tue:
                    Console.WriteLine("今天星期二");
                    break;
                case (int) MyDate.Wed:
                    Console.WriteLine("今天星期三");
                    break;
                case (int) MyDate.Thi:
                    Console.WriteLine("今天星期四");
                    break;
                case (int) MyDate.Fri:
                    Console.WriteLine("今天星期五");
                    break;
                case (int) MyDate.Sat:
                    Console.WriteLine("今天星期六");
                    break;
            }

            double x = 1993545.0112;
            int y = (int) x;
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

            String[] ls2 = new string[2] {"1", "2"};
            Console.WriteLine(ls2[0]);

            Type myType = typeof(int);
            Console.WriteLine("类型：{0}", myType);

            String str1 = "string1111";
            String str2 = "testHelloWorld";
            Console.WriteLine(String.Compare(str1, str2));
            Console.WriteLine(str1.CompareTo(str2));

            DateTime dt = DateTime.Now;
            String strB = String.Format("{0:D}", dt);
            Console.WriteLine(strB);
            
            // PadLeft, PadRight
            String strPad = "*^___^*";
            String str12 = strPad.PadLeft(7, '(').PadRight(8, ')');
            Console.WriteLine(str12);
            
            // HashTable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", "001");
            hashtable.Add("sex", "男");
            hashtable.Add("name", "张三");
            foreach (DictionaryEntry dicEntry in hashtable)
            {
                Console.WriteLine("\t" + dicEntry.Key + "\t" + dicEntry.Value);
            }
            Console.WriteLine(hashtable.ContainsKey("id"));
            
            Chapter8_9.Date date = new Chapter8_9.Date();
            date.Day = 12;
            Console.WriteLine(date.Day);

            StructTest structTest;
            structTest.width = 2.4;
            structTest.height = 4.5;
            Console.WriteLine("area: " + structTest.Area());
            
            StructTest structTest2 = new StructTest(4.0, 4.0);
            Console.WriteLine("area2: " + structTest2.Area());
            
            // class
            ChildClass childClass = new ChildClass();
            ClassTest classTest = childClass;
            classTest.X = 12;
            classTest.Y = 23;
            Console.WriteLine(classTest.Add());
        }
    }
}