using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new Context();

            var builder = new AppBuilder(context);
            builder.Use<RequestA>();
            builder.Use<RequestB>();
            builder.Use<RequestC>();
            builder.Use<RequestD>();
            builder.Use<RequestE>();
            builder.Run().Wait();

            Console.WriteLine(context.Msg);
            Console.Read();

        }
    }
}
