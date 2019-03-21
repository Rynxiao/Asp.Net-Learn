namespace basicNetLearn
{
    public class Chapter8_9
    {
        public class Date
        {
            private int day = 7;

            public int Day
            {
                get { return day; }
                set
                {
                    if (value > 0 && value < 8)
                    {
                        day = value;
                    }
                }
            }
        }
    }
}