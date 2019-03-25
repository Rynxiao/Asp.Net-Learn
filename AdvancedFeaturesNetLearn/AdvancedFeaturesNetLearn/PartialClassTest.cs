namespace AdvancedFeaturesNetLearn
{
    public class PartialClassTest
    {
        
    }

    partial class account
    {
        public int addition(int a, int b)
        {
            return a + b;
        }
    }

    partial class account
    {
        public int multipication(int a, int b)
        {
            return a * b;
        }
    }

    partial class account
    {
        public int substraction(int a, int b)
        {
            return a - b;
        }
    }
    
    partial class account
    {
        public int division(int a, int b)
        {
            return a / b;
        }
    }
}