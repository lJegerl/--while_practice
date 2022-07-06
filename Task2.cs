﻿namespace WhilePractice
{
    public static class Task2
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            int i = 1;

            while (i < n + 1)
            {
                sum += (double)Math.Pow(-1, i + 1) / (i * (i + 1d));
                i++;
            }

            return sum;
        }
    }
}
