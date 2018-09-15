using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
{
    public class RequestD : RequestMessage
    {

        public override async Task InvokeAsync(Context context)
        {
            context.Msg += "D";
            Console.WriteLine("Processando D ...");
            Thread.Sleep(2000);
            await Next(context);

            Console.WriteLine("Terminando D ...");
            Thread.Sleep(2000);
        }
    }
}
