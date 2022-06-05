﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelAccountingApp.Models
{
    [Table("Workers")]
    public class Worker : Role
    {
        public virtual Supervisor? Supervisor { get; set; }
    }
}
