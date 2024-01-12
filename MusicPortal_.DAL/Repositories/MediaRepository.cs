using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MusicPortal_.DAL.EF;
using MusicPortal_.DAL.Entities;
using MusicPortal_.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.Repositories
{
    internal class MediaRepository : IRepository<Media>
    {
        MusicPortalContext db;

        public MediaRepository(MusicPortalContext db) 
        {
            this.db = db;
        }


        public async Task<Media> Get(int id) => await db.Medias.FindAsync(id);
        public async Task Create(Media media) => await db.Medias.AddAsync(media);

        public void Update(Media media) => db.Entry(media).State = EntityState.Modified;

        public async Task Delete(int id)
        {
            Media? media = await db.Medias.FindAsync(id);
            if (media != null)
                db.Medias.Remove(media);
        }

        public async Task<IEnumerable<Media>> GetAll() => await db.Medias.ToListAsync();
    }
}
