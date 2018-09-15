using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RequestA : RequestMessage
    {
 
        public override async Task InvokeAsync(Context context)
        {
            context.Msg += "A";
            Console.WriteLine("Processando A ...");
            Thread.Sleep(2000);

            await Next(context);

            Console.WriteLine("Terminando A ...");
        }
    }
}
