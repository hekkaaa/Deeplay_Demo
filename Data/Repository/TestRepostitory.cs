using Data.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TestRepostitory
    {
        private ApplicationContext _context;

        public TestRepostitory(ApplicationContext context)
        {
            _context = context;
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.Id;
        }

        public int AddTest(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges(); 
            return user.Id;
        }

        public void UpdateWorker(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public void UpdateWorker(Worker user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public List<User> GetTest ()
        {
            var t = _context.Users.ToList();
            return t;
        }

        public Director GetDirectorById(int id)
        {
            return _context.Directors.FirstOrDefault(x => x.Id == id);
        }

        public Worker GetWorkerId(int id)
        {
            return _context.Workers.FirstOrDefault(x => x.Id == id);
        }

        public Supervisor GetSupervisorById(int id)
        {
            return _context.Supervisor.FirstOrDefault(x => x.Id == id);
        }
       
    }
}
