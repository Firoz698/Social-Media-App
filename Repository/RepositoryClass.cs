using CoreDataBase;

namespace Repository
{
    public class RepositoryClass : IRepositoryInterface
    {
        //data base inject here
        public readonly MainDataBase _Dbcontext;
        public RepositoryClass(MainDataBase dbcontext)
        {
            _Dbcontext = dbcontext;
        }

        public Task Add(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserInfo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserInfo> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }
    }
}
