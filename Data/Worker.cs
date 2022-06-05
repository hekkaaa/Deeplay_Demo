using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("Workers")]
    public class Worker : Role
    {   
        public virtual Supervisor? Supervisor { get; set; }
    }
}
