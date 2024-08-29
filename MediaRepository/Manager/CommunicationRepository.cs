using MainDatabase;
using MediaRepository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model;
using Model.Parshial;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MediaRepository.Manager
{
    public class CommunicationRepository : ICommnucationRepository
    {
        public DatabaseContext _databaseContext;
        public IConfiguration _config;
        public CommunicationRepository(DatabaseContext databaseContext, IConfiguration config)
        {
            _databaseContext = databaseContext;
            _config = config;
        }

        public async Task<UserInfo> Add(UserInfo userInfo)
        {
          var data=  await _databaseContext.userInfos.AddAsync(userInfo);
            _databaseContext.SaveChanges();
            return userInfo;
        }
        public async Task<UserInfo> GetById(int Id)
        {
            var StoreObje = await _databaseContext.userInfos.FindAsync(Id);
            return StoreObje;
        }
        public async Task<List<UserInfo>> GetAll()
        {
            var data = await _databaseContext.userInfos.ToListAsync();
            return data;
        }
        public async Task<UserInfo> Update(UserInfo userInfo)
        {
            UserInfo StorUser = new UserInfo();
            StorUser = await _databaseContext.userInfos.FindAsync(userInfo.Id);
            _databaseContext.userInfos.Update(userInfo);
            _databaseContext.SaveChanges();
            return StorUser;
        }
        public async Task<UserInfo> DeleteById(int Id)
        {
            UserInfo userObj = new UserInfo();
            userObj = await _databaseContext.userInfos.FindAsync(Id);
            _databaseContext.userInfos.Remove(userObj);
            _databaseContext.SaveChanges();
            return userObj;
        }
        public async Task<ResponseDTO> UserLogin(UserCommunication OuserCommunication)
        {
            var authReturnDto = await _databaseContext.userInfos.FirstOrDefaultAsync(x => x.Email == OuserCommunication.Email && x.Password == OuserCommunication.Password);
            if (authReturnDto == null)
            {
                throw new Exception("User not Found");
            }
            var response = GenerateJSONWebToken(authReturnDto.Email, authReturnDto.Id);
            ResponseDTO responsedto = new ResponseDTO();
            responsedto.Token = response;
            responsedto.UserName = authReturnDto.Email;
            responsedto.Id = authReturnDto.Id;
            responsedto.Name = authReturnDto.Name;
            return responsedto;
        }
        private string GenerateJSONWebToken(string userName, int userId)
        {
            var data = _config["Jwt:Key"];
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim("UserName", userName),
                new Claim("UserId", userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(
              _config["Jwt:Issuer"],
              _config["Jwt:Audience"],
              claims,
              expires: DateTime.Now.AddMinutes(10),
              signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
