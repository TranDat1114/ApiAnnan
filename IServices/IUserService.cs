using ApiAnnan.Models;

namespace ApiAnnan.IServices
{
    public interface IUserService
    {
        public User GetUserById (int id);
        public User GetUserByUsername(string username);
        public User GetUserByEmail(string email);
        public User GetUserByPhoneNumber(string phoneNumber);
        public User LoginByEmailAndPassword(string username);
        public List<User> Get100Users();
        public void AddUser();
        public void UpdateUser(User user);
        public void DeleteUser(User user);
    }
}
