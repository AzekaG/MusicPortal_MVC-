using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal_.DAL.Interfaces
{
    internal interface IRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Create(T user);
        Task Delete(int id);
        void Update(T user);

    }
}
