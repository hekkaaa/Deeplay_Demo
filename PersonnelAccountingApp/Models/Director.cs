using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelAccountingApp.Models
{
    [Table("Directors")]
    public class Director : Role
    {
        public int Id { get; set; }
        public virtual string? Industry { get; set; }
    }
}
