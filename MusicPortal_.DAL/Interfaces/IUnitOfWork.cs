using MusicPortal_.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.Interfaces
{
     interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Media> Medias { get; }
        Task Save();
    }
}
