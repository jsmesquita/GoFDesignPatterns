using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
{
    public class AppBuilder : IAppBuilder
    {
        private RequestMessage _start;
        private Context _context;

        public AppBuilder(Context context)
        {
            _context = context;
        }

        public async Task Run()
        {
            await _start.InvokeAsync(_context);
        }

        public void Use<T>() where T : RequestMessage, new()
        {
            if (_start == null)
                _start = new T();
            else
                _start.Use(new T());
        }
    }
}
