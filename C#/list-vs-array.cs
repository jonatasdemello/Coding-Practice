        public static void test()
        {
            int cap = 100000;

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            int[] ix = new int[cap];
            for (int x = 0; x < cap; x++)
            {
                ix[x] = 1;
            }

            sw1.Stop();

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            List<int> iy = new List<int>(cap);
            for (int y = 0; y < cap; y++)
            {
                iy.Add(y);
            }
            sw2.Stop();

            Console.WriteLine(cap.ToString() + "     int[]= \t" + sw1.ElapsedTicks.ToString() + "\t" + sw1.ElapsedMilliseconds);
            Console.WriteLine(cap.ToString() + " List<int>= \t" + sw2.ElapsedTicks.ToString() + "\t" + sw2.ElapsedMilliseconds);

            Console.ReadKey();
        }