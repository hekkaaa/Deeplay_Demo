using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingApp.Models
{
    [Table("HeadDeparts")]
    public class HeadDepart : Role
    {   
        public int NameDepartId { get; set; }
        public virtual NameDepart NameDeparts { get; set; }
    }
}
