using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RequestC : RequestMessage
    {

        public override async Task InvokeAsync(Context context)
        {
            try
            {

                context.Msg += "C";
                Console.WriteLine("Processando C ...");
                Thread.Sleep(2000);
                throw new ArgumentException();


                Console.WriteLine("Terminando C ...");
                Thread.Sleep(2000);
            }
            catch (Exception)
            {

                Console.WriteLine("Um erro ocorreu em C");
            }
            finally
            {
                await Next(context);
            }
        }
    }
}
