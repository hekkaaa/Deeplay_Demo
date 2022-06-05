using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Directors")]
    public class Director : Role
    {   
        int Id { get; set; }
        public virtual string? Industry { get; set; }
    }
}
