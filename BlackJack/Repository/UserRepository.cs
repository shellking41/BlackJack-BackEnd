using BlackJack.Data;
using BlackJack.Models;

namespace BlackJack.Repository
{
    public interface IUserRepository
    {
        User GetUser(int  id);
        ICollection<User> GetUsers();
    }

    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public User GetUser(int id) 
        {
            return _dataContext.Users.Find(id);
        }
        public ICollection<User> GetUsers() 
        {
            return _dataContext.Users.OrderBy(u => u.Id).ToList();
        }
    }
}
