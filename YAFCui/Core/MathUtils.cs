using System;

namespace YAFC.UI
{
    public static class MathUtils
    {
        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
        
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public static int Round(float value) => (int) MathF.Round(value);
        public static int Floor(float value) => (int) MathF.Floor(value);
        public static int Ceil(float value) => (int) MathF.Ceiling(value);
    }
}