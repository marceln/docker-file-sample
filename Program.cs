﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace docker_file_sample
{
    class Program
    {
        public static void Main(string[] args)
        {
            var i = 0;
            while (true)
            {
                if(!Console.IsInputRedirected && Console.KeyAvailable)
                {
                    break;
                }

                Console.WriteLine($"Counter: {++i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Stopping");
        }
    }
}
