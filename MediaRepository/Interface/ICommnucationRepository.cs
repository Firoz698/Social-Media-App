using Model;
using Model.Parshial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaRepository.Interface
{
    public interface ICommnucationRepository
    {
        Task<UserInfo> Add(UserInfo userInfo);
        Task<List<UserInfo>> GetAll();
        Task<UserInfo> GetById(int Id);
        Task<UserInfo> Update(UserInfo userInfo);
        Task<UserInfo> DeleteById(int Id);
        Task<ResponseDTO> UserLogin(UserCommunication oUserDto);
    }
}
