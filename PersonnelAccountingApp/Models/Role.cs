﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingApp.Models
{
    [Table("Roles")]
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
