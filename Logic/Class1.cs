using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Class1
    {
        public static int GCD(out long time, params int[] a)
        {
            Stopwatch t = new Stopwatch();
            t.Start();

            if (a.Length < 2) throw new ArgumentException($"{nameof(a)} must have 2 or more numbers");
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                long time1;
                res = GCD(out time1, res, a[i]);
            }

            time = t.ElapsedMilliseconds;
            return res;
        }

        public static int GCD(out long time, int a, int b)
        {
            Stopwatch t = new Stopwatch();
            t.Start();

            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }

            time = t.ElapsedMilliseconds;
            return Math.Abs(a);
        }


        public static int BinaryGCD(out long time, params int[] a)
        {
            Stopwatch t = new Stopwatch();
            t.Start();

            if (a.Length < 2) throw new ArgumentException($"{nameof(a)} must have 2 or more numbers");
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                long time1;
                res = BinaryGCD(out time1, res, a[i]);
            }

            time = t.ElapsedMilliseconds;
            return res;
        }

        public static int BinaryGCD(out long time, int a, int b)
        {
            Stopwatch t = new Stopwatch();
            t.Start();

            if (a == b)
            {
                time = t.ElapsedMilliseconds;
                return a;
            }
            if (a == 0)
            {
                time = t.ElapsedMilliseconds;
                return b;
            }
            if (b == 0)
            {
                time = t.ElapsedMilliseconds;
                return a;
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            long time1;
            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                {
                    time = t.ElapsedMilliseconds;
                    return BinaryGCD(out time1, a >> 1, b);
                }

                time = t.ElapsedMilliseconds;
                return BinaryGCD(out time1, a >> 1, b >> 1) << 1;

            }
            if ((~b & 1) != 0)
            {
                time = t.ElapsedMilliseconds;
                return BinaryGCD(out time1, a, b >> 1);
            }
            if (a > b)
            {
                time = t.ElapsedMilliseconds;
                return BinaryGCD(out time1, (a - b) >> 1, b);
            }
            time = t.ElapsedMilliseconds;
            return BinaryGCD(out time1, (b - a) >> 1, a);

        }

    }
}
