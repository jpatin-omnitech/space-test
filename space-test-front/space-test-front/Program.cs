using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_test_front
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return TestHelper.BuildWebSite(args);
        }

       

        static int Fibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0; // It will return the first number of the series
            if (n == 1) return 1; // it will return  the second number of the series
            for (int i = 2; i <= n; i++)  // main processing starts from here
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }


    }
}
