using PersonnelAccountingApp.Data.Connect;
using PersonnelAccountingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonnelAccountingApp.Data
{
    public class UserRepository
    {
        private ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Employees> GetAllUser()
        {
            var res = _context.Employees.ToList();
            return res;
        }

        public int AddNewEmployees(Employees newUser)
        {
            _context.Employees.Add(newUser);
            _context.SaveChanges();
            return newUser.Id;
        }
    }
}
