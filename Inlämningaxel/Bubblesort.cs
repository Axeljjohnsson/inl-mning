using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämningsorteringAxel
{
    class Bubblesort
    {
        public static void BubbleSort(int[] intuppställ)
        {
            for (int i = intuppställ.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (intuppställ[j] > intuppställ[j + 1])
                    {
                        int highValue = intuppställ[j];
                        intuppställ[j] = intuppställ[j + 1];
                        intuppställ[j + 1] = highValue;
                    }
                }
            }
        }
    }
}
