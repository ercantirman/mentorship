using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScratchPad
{
    class Program
    {
        #region First
        //static void Main(string[] args)
        //{
        //    MakeTea();

        //    Console.WriteLine("Bon appétit!");
        //}

        //public static void MakeTea()
        //{
        //    var water = BoilWater();

        //    Console.WriteLine("Take the cups out");

        //    Console.WriteLine("Put tea in cup");

        //    Console.WriteLine($"Pour {water} in cups");
        //}

        //public static string BoilWater()
        //{
        //    Console.WriteLine("Start the kettle");

        //    Console.WriteLine("Waiting for the kettle");

        //    //Task.Delay(2000).GetAwaiter().GetResult();

        //    Thread.Sleep(2000);

        //    Console.WriteLine("Kettle finished boiling");

        //    return "water";
        //}
        #endregion

        #region First- Part 2
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    MakeTea();
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Bon appétit!");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //}

        //public static void MakeTea()
        //{
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    var water = BoilWater();
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Take the cups out");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Put tea in cup");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine($"Pour {water} in cups");
        //}

        //public static string BoilWater()
        //{
        //    Console.WriteLine("Start the kettle");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Waiting for the kettle");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    //Task.Delay(2000).GetAwaiter().GetResult();

        //    Thread.Sleep(2000);
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Kettle finished boiling");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    return "water";
        //}
        #endregion

        #region Second
        //static async Task Main(string[] args)
        //{
        //    await MakeTeaAsync();

        //    Console.WriteLine("Bon appétit!");
        //}


        //public static async Task MakeTeaAsync()
        //{
        //    var boilingWater = BoilWaterAsync();

        //    Console.WriteLine("Take the cups out");

        //    var a = 0;
        //    for (int i = 0; i < 1000000000; i++)
        //    {
        //        a++;
        //    }

        //    Console.WriteLine("Put tea in cup");

        //    var water = await boilingWater;

        //    Console.WriteLine($"Pour {water} in cups");
        //}

        //public static async Task<string> BoilWaterAsync()
        //{
        //    Console.WriteLine("Start the kettle");

        //    Console.WriteLine("Waiting for the kettle");

        //    await Task.Delay(2000);

        //    //Thread.Sleep(2000);

        //    Console.WriteLine("Kettle finished boiling");

        //    return "water";
        //}
        #endregion

        #region Second - Part 2
        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    await MakeTeaAsync();
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Bon appétit!");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //}


        //public static async Task MakeTeaAsync()
        //{
        //    var boilingWater = BoilWaterAsync();
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Take the cups out");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    var a = 0;
        //    for (int i = 0; i < 1000000000; i++)
        //    {
        //        a++;
        //    }

        //    Console.WriteLine("Put tea in cup");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    var water = await boilingWater;
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine($"Pour {water} in cups");
        //}

        //public static async Task<string> BoilWaterAsync()
        //{
        //    Console.WriteLine("Start the kettle");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Waiting for the kettle");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    await Task.Delay(2000);

        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("Kettle finished boiling");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    return "water";
        //}
        #endregion

        #region Third
        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 1");
        //    var client = new HttpClient();

        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 2");
        //    var task = client.GetStringAsync("http://google.com");

        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 3");
        //    var a = 0;
        //    //for (int i = 0; i < 1000000000; i++)
        //    //{
        //    //    a++;
        //    //}
        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        a++;
        //    }

        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 4");
        //    var page = await task;

        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 5");
        //}
        #endregion

        #region Fourth
        static async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 1");
            var client = new HttpClient();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 2");
            var str = await client.GetStringAsync("http://google.com");

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 3");
            //var a = 0;
            //for (int i = 0; i < 1000000000; i++)
            //{
            //    a++;
            //}

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 4");
            var str2 = await client.GetStringAsync("http://google.com");

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 5");
        }
        #endregion
    }
}
