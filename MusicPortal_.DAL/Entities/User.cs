using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.Entities
{
    public enum Status
    {
        admin,
        user
    }
    public class User
    {
        public int id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Salt { get; set; }

        public Status Status { get; set; }

        public ICollection<Media>? MediaFiles { get; set; }



        public User()
        {
            MediaFiles = new List<Media>();
        }


    }
}
