using System;
using System.Collections;

namespace AdvancedFeaturesNetLearn
{
    public class IteratorTest: IEnumerable
    {
        private String[] MyFamily = {"父亲", "母亲", "弟弟", "妹妹"};
            
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < MyFamily.Length; i++)
            {
                yield return MyFamily[i];
            }
        }
    }
}