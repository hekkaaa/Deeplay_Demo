using PersonnelAccountingApp.Data;
using PersonnelAccountingApp.Data.Connect;
using PersonnelAccountingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonnelAccountingApp.Services
{
    public class RoleService
    {
        private readonly RoleRepository _roleRepository;
        private readonly ApplicationContext _applicationContext;

        public RoleService()
        {
            _applicationContext = new ApplicationContext();
            _roleRepository = new RoleRepository(_applicationContext);
        }

        public List<Role> GetAllRole()
        {
            return _roleRepository.GetAllRoles();
        }

        public List<string> GetListAllNameRole()
        {
            var tmpres = _roleRepository.GetAllRoles();
            return tmpres.Select(x => x.Name).ToList();
        }
    }
}
