using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class User : BaseEntity
    {
        public User()
        {
            Coments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }      
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public string Telephone { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Comment> Coments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
