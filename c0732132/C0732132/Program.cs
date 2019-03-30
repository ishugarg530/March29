using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0732132
{

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("downloading a file");
            Console.ReadLine();
        }




        static async Task Download()
        {
            await Network.Download();
            Console.WriteLine("Dowmload complete");
        }




        class Network
        {
            public static async Task Download()
            {
                HttpClient client = new HttpClient();



                await client.GetStringAsync("");
                Console.WriteLine("Download Complete");
            }
        }
    }
}

