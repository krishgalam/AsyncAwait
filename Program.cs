using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Act();
            Console.ReadLine();
        }

        // async with out await means methods will run synchronously"

        //private static void Act()
        //{
        //    UpdateProfile();
        //    GetBalance();
        //    DepositAmount(10000);
        //}

        //private static async void UpdateProfile()
        //{
        //    Console.WriteLine("Profile Updated");
        //    Thread.Sleep(2000);
        //}

        //private static async void GetBalance()
        //{
        //    Console.WriteLine("Balance amount : 10000");
        //    Thread.Sleep(2000);
        //}

        //private static async void DepositAmount(int amount)
        //{
        //    Console.WriteLine("Amount Deposited : " + amount);
        //    Thread.Sleep(2000);
        //}


        // below example run all methods all synchronoulsy

        //private static void Act()
        //{
        //    UpdateProfile();
        //    GetBalance();
        //    DepositAmount(10000);
        //}

        //private static async void UpdateProfile()
        //{
        //    await Task.Run(() =>
        //    {
        //        Console.WriteLine("Profile Updated");
        //        Thread.Sleep(2000);
        //    });

        //}

        //private static async void GetBalance()
        //{
        //    await Task.Run(() =>
        //    {
        //        Console.WriteLine("Balance amount : 10000");
        //        Thread.Sleep(2000);
        //    });
        //}

        //private static async void DepositAmount(int amount)
        //{
        //    await Task.Run(() =>
        //    {
        //        Console.WriteLine("Amount Deposited : " + amount);
        //        Thread.Sleep(2000);
        //    });
        //}


        // Bbelow example shows wait for Update Profile response (synchronous) and asynchronous call for GetBalance and DepositAmount methods
        
        private static async void Act()
        {
            var result = await UpdateProfile();
            Console.WriteLine("Is Profile Updated :" + result);
            GetBalance();
            DepositAmount(10000);
        }

        private static async Task<bool> UpdateProfile()
        {
            bool result = false;
            await Task.Run(() =>
            {
                Console.WriteLine("Profile Updated");
                Thread.Sleep(2000);
                result = true;
            });
            return result;
        }

        private static async void GetBalance()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Balance amount : 10000");
                Thread.Sleep(2000);
            });
        }

        private static async void DepositAmount(int amount)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Amount Deposited : " + amount);
                Thread.Sleep(2000);
            });
        }

    }
}
