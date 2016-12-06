using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld
{
    // Klasa generyczna
    class Sender<TItem>
    {
        private TItem item;

        public void Send(TItem item)
        {
            this.item = item;
            Console.WriteLine($"Sending {item}");
        }

        public TItem GetItem()
        {
            return item;
        }
    }
}
