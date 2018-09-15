using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
{
    public class RequestB : RequestMessage
    {

        int qtd = 0;



        public override async Task InvokeAsync(Context context)
        {
            context.Msg += "B";
            Console.WriteLine("Processando B ...");
            Thread.Sleep(2000);
            await Next(context);

            qtd--;
            if (qtd > 0)
            {
                await InvokeAsync(context);

                return;
            }
            Console.WriteLine("Terminando B ...");
            Thread.Sleep(2000);
        }
    }
}
