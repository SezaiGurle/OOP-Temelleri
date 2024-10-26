using System;

namespace u03_extensionMethod
{
    public static class Matematik
    {
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        public static int Ekle(this int a, int b)
        {
            return a + b;
        }

    }

    public class Matematik2
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
    }
}
