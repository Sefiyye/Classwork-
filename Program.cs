using System;

namespace Classwork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //{
            //    int[] arr = { 20, 31, 38, 44, 52 };
            //    int number = 25;
            //    additionNumber(ref arr, number);
            //}
            //static void additionNumber(ref int[] arr, int number)
            //{
            //    int[] newArr = new int[arr.Length + 1];
            //    newArr[arr.Length] = number;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        newArr[i] = arr[i];
            //    }
            //    arr = newArr;
            //    foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //}
            //}

            #endregion

            Product pr = new Product();
            pr.Name = "";
            pr.Price = 4;
            pr.Count = 7;
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();





            Console.WriteLine($"Gelirimiz : {pr.Totalcome} Mehsulun sayi {pr.Count} ");


        }
    }
}
