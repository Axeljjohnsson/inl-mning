using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using inlämningsorteringAxel;

namespace inlämningsorteringAxel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[1000];
            int[] c = new int[100000];

            int[] d = new int[10];
            int[] e = new int[1000];
            int[] f = new int[100000];

            int[] g = new int[10];
            int[] h = new int[1000];
            int[] j = new int[100000];

            Random tal = new Random(); 

            Stopwatch tid = new Stopwatch();

            double frequency = Stopwatch.Frequency;
            double nanosecPerTick = (1000 * 1000 * 1000) / frequency;

            double Atid = -1;
            double Btid = -1;
            double Ctid = -1;
            double Dtid = -1;
            double Etid = -1;
            double Ftid = -1;
            double Gtid = -1;
            double Htid = -1;
            double Jtid = -1;

            for (int i = 0; i < 10; i++)
            {
                a[i] = tal.Next(0, 1000000);
                d[i] = tal.Next(0, 1000000);
                g[i] = tal.Next(0, 1000000);
            }

            for (int i = 0; i < 1000; i++)
            {
                b[i] = tal.Next(0, 1000000);
                e[i] = tal.Next(0, 1000000);
                h[i] = tal.Next(0, 1000000);
            }

            for (int i = 0; i < 100000; i++)
            {
                c[i] = tal.Next(0, 1000000);
                f[i] = tal.Next(0, 1000000);
                j[i] = tal.Next(0, 1000000);
            }

            Console.WriteLine("Sorteringsalgoritmernas tid test");
            Console.WriteLine("Tryck ENTER för att starta");
            Console.ReadLine();

            Console.WriteLine("Bubblesort med 10 nummer");
            tid.Start();
            Bubblesort.BubbleSort(a);
            tid.Stop();
            Atid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort med 10 nummer");
            tid.Start();
            Insertionsort.InsertionSort(d);
            tid.Stop();
            Dtid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort med 10 nummer");
            tid.Start();
            Mergsort.MergeSort(g);
            tid.Stop();
            Gtid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Bubblesort med 1000 nummer");
            tid.Start();
            Bubblesort.BubbleSort(b);
            tid.Stop();
            Btid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort med 1000 nummer");
            tid.Start();
            Insertionsort.InsertionSort(e);
            tid.Stop();
            Etid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort med 1000 nummer");
            tid.Start();
            Mergsort.MergeSort(h);
            tid.Stop();
            Htid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Bubblesort med 100000 nummer");
            tid.Start();
            Bubblesort.BubbleSort(c);
            tid.Stop();
            Ctid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort med 100000 nummer");
            tid.Start();
            Insertionsort.InsertionSort(f);
            tid.Stop();
            Ftid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort med 100000 nummer");
            tid.Start();
            Mergsort.MergeSort(j);
            tid.Stop();
            Jtid = tid.Elapsed.TotalSeconds;
            Console.WriteLine(tid.Elapsed.TotalSeconds + " s");
            tid.Reset();
            Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("Bubblesort:");
            Console.WriteLine("Insättning med 10 element tog: " + Atid + " s");
            Console.WriteLine("Insättning med 1000 element tog: " + Btid + " s");
            Console.WriteLine("Insättning med 100000 element tog: " + Ctid + " s");

            Console.WriteLine("\n");
            Console.WriteLine("Insertionsort:");
            Console.WriteLine("Insättning med 10 element tog: " + Dtid + " s");
            Console.WriteLine("Insättning med 1000 element tog: " + Etid + " s");
            Console.WriteLine("Insättning med 100000 element tog: " + Ftid + " s");

            Console.WriteLine("\n");
            Console.WriteLine("Mergsort:");
            Console.WriteLine("Insättning med 10 element tog: " + Gtid + " s");
            Console.WriteLine("Insättning med 1000 elements tog: " + Htid + " s");
            Console.WriteLine("Insättning med 100000 element tog: " + Jtid + " s");

            Console.ReadLine(); 
        }
    }
}
