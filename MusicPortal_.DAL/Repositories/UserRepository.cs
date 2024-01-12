using Microsoft.EntityFrameworkCore;
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
    internal class UserRepository : IRepository<User>
    {
        MusicPortalContext db;

        public UserRepository(MusicPortalContext db)
        {
            this.db = db;
        }


        public async Task<User> Get(int id) => await db.Users.FindAsync(id);
        public async Task Create(User user) => await db.Users.AddAsync(user);

        public void Update(User user) => db.Entry(user).State = EntityState.Modified;

        public async Task Delete(int id)
        {
            User? user = await db.Users.FindAsync(id);
            if (user != null)
                db.Users.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAll() => await db.Users.ToListAsync();
    }
}
