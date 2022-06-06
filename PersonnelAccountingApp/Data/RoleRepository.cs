using PersonnelAccountingApp.Data.Connect;
using PersonnelAccountingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingApp.Data
{
    public class RoleRepository
    {
        private ApplicationContext _context;

        public RoleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Role> GetAllRoles()
        {
            var res = _context.Roles.ToList();
            return res;
        }

        public Director GetDirectorRole()
        {
            return _context.Directors.FirstOrDefault();
        }

        public Worker GetWorkerRole()
        {
            return _context.Workers.FirstOrDefault();
        }

        public Supervisor GetSupervisorRole()
        {
            return _context.Supervisor.FirstOrDefault();
        }
    }
}
