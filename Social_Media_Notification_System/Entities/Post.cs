using System.Collections.Generic;

namespace Social_Media_Notification_System.Entities
{
    internal class Post
    {
        public int PostId { get; set; }
        public List<Like> Likes { get; set; }
        public int MyProperty { get; set; }
    }
}
