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
            if (item == null)
                throw new ArgumentNullException(nameof(item));




            this.item = item;

            var type = item.GetType();

            Console.WriteLine($"Sending {item}");
        }

        public TItem GetItem()
        {
            return item;
        }
    }
}
