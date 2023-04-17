using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduKey.Entity
{
    public class Inbox
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public DateTime InboxTime { get; set; }
        public string InboxContent { get; set; }
    }
}
