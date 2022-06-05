using PersonnelAccountingApp.Data;
using PersonnelAccountingApp.Data.Connect;

namespace PersonnelAccountingApp.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly ApplicationContext _applicationContext;

        public UserService()
        {
            _applicationContext = new ApplicationContext();
            _userRepository = new UserRepository(_applicationContext);
        }
    }
}
