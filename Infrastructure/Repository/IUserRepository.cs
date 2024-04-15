using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(User user);
        Task<User> Detail(Guid id);
        Task<List<User>> GetAll();
    }
}
