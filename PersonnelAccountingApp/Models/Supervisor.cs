using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelAccountingApp.Models
{
    //[Table("Supervisors")]
    public class Supervisor
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
