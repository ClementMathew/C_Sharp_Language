using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Notification_System.Entities
{
    internal class Account
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
