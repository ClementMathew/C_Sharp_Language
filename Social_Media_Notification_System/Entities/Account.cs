using System.Collections.Generic;

namespace Social_Media_Notification_System.Entities
{
    internal class Account
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
