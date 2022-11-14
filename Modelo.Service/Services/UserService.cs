using Modelo.Domain.Interface;
using Modelo.Domain.Models;
using Modelo.Domain.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
        }
    }
}
