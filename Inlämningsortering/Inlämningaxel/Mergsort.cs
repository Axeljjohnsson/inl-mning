using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämningsorteringAxel
{
    class Mergsort
    {
        public static void MergeSort(int[] input, int låg, int hög)
        {
            if (låg < hög)
            {
                int mitten = (låg / 2) + (hög / 2);

                MergeSort(input, låg, mitten);
                MergeSort(input, mitten + 1, hög);
                Merge(input, låg, mitten, hög);
            }
        }

        public static void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }

        private static void Merge(int[] input, int låg, int mitten, int hög)
        {
            int vänster = låg;
            int höger = mitten + 1;
            int[] tmp = new int[(hög - låg) + 1];
            int tmpIndex = 0;

            while ((vänster <= mitten) && (höger <= hög))
            {
                if (input[vänster] < input[höger])
                {
                    tmp[tmpIndex] = input[vänster];
                    vänster = vänster + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[höger];
                    höger = höger + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (vänster <= mitten)
            {
                while (vänster <= mitten)
                {
                    tmp[tmpIndex] = input[vänster];
                    vänster = vänster + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (höger <= hög)
            {
                while (höger <= hög)
                {
                    tmp[tmpIndex] = input[höger];
                    höger = höger + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[låg + i] = tmp[i];
            }
        }
    }
}
