using System;
using System.Collections;

namespace nonGenericArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NonGenericArrayList = new ArrayList();
            string str = "Like, Share, Subscribe";
            int x = 11;
            DateTime d = DateTime.Parse("3-dec-1998");

            NonGenericArrayList.Add(str);
            NonGenericArrayList.Add(x);
            NonGenericArrayList.Add(d);

            foreach(object o in NonGenericArrayList)
            {
                Console.WriteLine(o);
            }
        }
    }
}