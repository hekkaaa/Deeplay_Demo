using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Supervisor
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
