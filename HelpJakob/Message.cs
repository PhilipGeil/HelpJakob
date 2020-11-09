using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class Message
    {
        private string to;

        public string To
        {
            get { return to; }
            private set { to = value; }
        }

        private string from;

        public string From
        {
            get { return from; }
            private set { from = value; }
        }

        private string body;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        private string subject;

        public string Subject
        {
            get { return subject; }
            private set { subject = value; }
        }

        private string cc;

        public string Cc
        {
            get { return cc; }
            private set { cc = value; }
        }

        public Message(string to, string from, string body, string subject)
        {
            To = to;
            From = from;
            Body = body;
            Subject = subject;
        }
        public Message(string to, string from, string body, string subject, string cc) : this(to, from, body, subject)
        {
            Cc = cc;
        }



    }
}
