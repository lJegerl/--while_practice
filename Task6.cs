﻿namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            int i = 1;

            while (i < n + 1)
            {
                sum += (double)Math.Pow(-1, i) / (double)((2 * i) + 1);
                i++;
            }

            return sum;
        }
    }
}
