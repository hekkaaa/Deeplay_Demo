using PersonnelAccountingApp.Data;
using PersonnelAccountingApp.Data.Connect;
using PersonnelAccountingApp.Models;

namespace PersonnelAccountingApp.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly RoleRepository _roleRepository;
        private readonly ApplicationContext _applicationContext;

        public UserService()
        {
            _applicationContext = new ApplicationContext();
            _userRepository = new UserRepository(_applicationContext);
            _roleRepository = new RoleRepository(_applicationContext);
        }

        public int AddNewEmpoyees(Employees user)
        {
            var newUser = CorrectionRole(user);
            newUser.IsDeleted = false;
            return _userRepository.AddNewEmployees(newUser);
        }

        private Employees CorrectionRole(Employees oldUser)
        {
            if (oldUser.Role.Name == "Директор")
            {
                oldUser.Role = _roleRepository.GetDirectorRole();
                return oldUser;
            }
            else if (oldUser.Role.Name == "Работник")
            {
                oldUser.Role = _roleRepository.GetDirectorRole();
                return oldUser;
            }
            else
            {
                oldUser.Role = _roleRepository.GetDirectorRole();
                return oldUser;
            }
        }
    }
}
