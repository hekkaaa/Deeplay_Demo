using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingApp.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Middlename { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Post { get; set; }
    }
}
