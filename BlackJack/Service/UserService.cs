using BlackJack.Models;
using BlackJack.Repository;

namespace BlackJack.Service
{
    public interface IUserService
    {
        User GetUser(int id);
        ICollection<User> GetUsers();
    }

    public class UserService : IUserService 
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User GetUser(int id) 
        {
            return _repository.GetUser(id);
        }
        public ICollection<User> GetUsers() 
        {
            return _repository.GetUsers();
        }
    }
}
