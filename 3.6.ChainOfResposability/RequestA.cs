using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
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
