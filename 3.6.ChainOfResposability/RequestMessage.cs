using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
{
    public abstract class RequestMessage
    {
        protected RequestMessage _next;
        public abstract Task InvokeAsync(Context context);

        protected async Task Next(Context context)
        {
            if (_next != null)
                await _next.InvokeAsync(context);
        }

        public void Use(RequestMessage requestMessage)
        {
            if (_next == null)
                _next = requestMessage;
            else
                _next.Use(requestMessage);
        }

    }
}
