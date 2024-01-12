using MusicPortal_.DAL.EF;
using MusicPortal_.DAL.Entities;
using MusicPortal_.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.Repositories
{
    internal class EFUnitOfWork : IUnitOfWork
    {
        private MusicPortalContext musicPortalContext;
        private UserRepository userRepository;
        private MediaRepository mediaRepository;

        public EFUnitOfWork(MusicPortalContext context) => musicPortalContext = context;

      
        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(musicPortalContext);
                return userRepository;
            }
        }

        public IRepository<Media> Medias
        {
            get
            {
                if (mediaRepository == null)
                    mediaRepository = new MediaRepository(musicPortalContext);
                return mediaRepository;
            }
        }

        public async Task Save()
        {
            await musicPortalContext.SaveChangesAsync();
        }

    }




}
