﻿using System;

namespace TextRPG.Utils
{
    public static class RPGRandom
    {
        private static Random random;

        static RPGRandom()
        {
            random = new Random();
        }

        public static float NextFloat(float min, float max)
        {
            if (min > max) 
                throw new ArgumentException("min > max", "min cannot be larger than max");

            float result = MathF.Round((float)(random.NextDouble() * (max - min) + min), 2);
            return result;
        }

        public static string PickFrom(string[] strings)
        {
            int index = random.Next(0, strings.Length);
            return strings[index];
        }
    }
}
