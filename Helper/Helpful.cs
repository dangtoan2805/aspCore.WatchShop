using System;
using System.Collections.Generic;
using System.Linq;

namespace aspCore.WatchShop.Helper
{
    public class Helpful
    {

        public static object[] ToResult<T>(List<T> ls, int items)
        {
            if (ls.Count <= items)
                return new object[] { ls, ls.Count };
            else
                return new object[] { ls.Take(items), ls.Count };
        }

        public static List<T> GetPage<T>(List<T> ls, int number, int pageItems)
        {
            return ls.Skip(pageItems * (number - 1)).Take(pageItems).ToList();
        }
    }
}