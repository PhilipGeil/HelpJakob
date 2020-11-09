using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message("you", "me", "hello", "greeting");
            SendMessageHandler s = new SendMessageHandler();
            s.SendMessage(MessageCarrier.Smtp, m, true);
            Console.WriteLine("Your message has been sent");
            Console.ReadKey();
        }
    }
}
