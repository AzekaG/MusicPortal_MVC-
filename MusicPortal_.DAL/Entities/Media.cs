using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.Entities
{
    public enum TypeMedia
    {
        Video,
        Audio
    }

    public class Media
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Artist { get; set; }

        public string? FileAdress { get; set; }

        public string? Poster { get; set; }


        public Genre? Genre { get; set; }

        public TypeMedia TypeMedia { get; set; }

        public Media() { }
    }
}
