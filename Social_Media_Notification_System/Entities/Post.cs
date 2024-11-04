using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Notification_System.Entities
{
    internal class Post
    {
        public int PostId { get; set; }
        public List<Like> Likes { get; set; }
        public int MyProperty { get; set; }
    }
}
