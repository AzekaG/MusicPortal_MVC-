using Microsoft.EntityFrameworkCore;
using MusicPortal_.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.EF
{
    internal class MusicPortalContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public MusicPortalContext(DbContextOptions<MusicPortalContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                /*pass == 1111*/


                Users?.Add(new User { FirstName = "Sergio", LastName = "Adminos", Email = "azekaggg@gmail.com", Status = Status.admin, Password = "938E3782FCDEC612B9A5BB5FD9EB94E9", Salt = "4BFEA494ACEE92BB6ADBD53348F5CD52" });


                SaveChanges();

                Genres?.AddRange(new Genre { Name = "pop" }, new Genre { Name = "Rock" }, new Genre { Name = "Rap" },
                    new Genre { Name = "Metal" }, new Genre { Name = "House" }, new Genre { Name = "Tehno" },
                    new Genre { Name = "Indi" }, new Genre { Name = "Lo-fi" }, new Genre { Name = "Reggae" });
                SaveChanges();

                Medias?.Add(new Media { Name = "Слышишь", Artist = "Dante", Genre = Genres?.First(x => x.Name == "pop"), TypeMedia = TypeMedia.Audio, Poster = "/Media/Poster/Чуэш.jpg", FileAdress = "/Media/Musec/Vladimir Dantes-Чуєш.mp3" });
                Medias?.Add(new Media { Name = "Слышишь", Artist = "Dante", Genre = Genres?.First(x => x.Name == "pop"), TypeMedia = TypeMedia.Video, Poster = "/Media/Poster/Чуэш.jpg", FileAdress = "Media/Video/VOLODYMYR DANTES — ЧУЄШ.mp4" });
                SaveChanges();
            };
            /* 
            */
        }

    }
}
