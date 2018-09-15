using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
{
    public interface IAppBuilder
    {

        void Use<T>() where T : RequestMessage, new();

        Task Run();
    }
}
