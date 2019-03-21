using System;

namespace basicNetLearn
{
    public class ClassTest
    {
        ~ClassTest()
        {
            Console.WriteLine("析构函数自动调用");
        }
        
        private int x;
        private int y;

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public virtual int Add()
        {
            return X + Y;
        }
    }

    public class ChildClass : ClassTest
    {
        public override int Add()
        {
            int x = 5;
            int y = 7;
            return x + y;
        }
    }
}