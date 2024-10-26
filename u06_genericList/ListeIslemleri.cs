using System;

namespace u06_genericList
{
    public static class ListeIslemleri 
    {
        public static void AddRange(this List<int> liste, params int[] sayilar)
        {
            liste.AddRange(sayilar);
        }
    }
}
