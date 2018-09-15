using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RequestE : RequestMessage
    {

        public override async Task InvokeAsync(Context context)
        {
            context.Msg += "E";
            Console.WriteLine("Processando E ...");
            Thread.Sleep(2000);
            await Next(context);

            Console.WriteLine("Terminando E ...");
            Thread.Sleep(2000);
        }
    }
}
