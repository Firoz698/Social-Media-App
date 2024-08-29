using ExprementProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryInterface
    {
        Task<IEnumerable<UserInfo>> GetAll();
        Task<UserInfo> GetById(int Id);
        Task Add(UserInfo userInfo);
        Task Update (UserInfo userInfo);
        Task DeleteById(int Id);
    }
}
