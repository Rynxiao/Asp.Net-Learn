namespace basicNetLearn
{
    public struct StructTest
    {
        public double width;
        public double height;

        public StructTest(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }
    }
}