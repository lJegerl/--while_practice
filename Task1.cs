﻿namespace WhilePractice
{
    public static class Task1
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            int i = 1;

            while (i < n + 1)
            {
                sum += 1d / i;
                i++;
            }

            return sum;
        }
    }
}
