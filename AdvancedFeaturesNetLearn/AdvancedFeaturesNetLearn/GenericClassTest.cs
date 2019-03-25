namespace AdvancedFeaturesNetLearn
{
    public class GenericClassTest<T, TI>: IGenericInterface<TI> where T: TI, new()
    {
        public TI CreateInstance()
        {
            return new T();
        }
    }

    public class Finder
    {
        public static int Find<T>(T[] items, T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}