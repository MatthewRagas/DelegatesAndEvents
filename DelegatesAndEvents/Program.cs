using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int[] arrayList = new int[4];            
            arrayList[0] = 1;
            arrayList[1] = 2;
            arrayList[2] = 3;
            arrayList[3] = 4;
            

            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.ReadKey();
            arrayList = list.Add(arrayList, 5);
            Console.ReadKey();
            arrayList = list.Add(arrayList, 6);
            Console.ReadKey();
            arrayList = list.Add(arrayList, 99);

            //for (int i = 0; i < arrayList.Length; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            Console.ReadKey();
        }
    }
}
