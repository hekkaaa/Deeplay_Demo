using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelAccountingApp.Models
{
    [Table("Directors")]
    public class Director : Role
    {
        
        public virtual Industry? Industrys { get; set; }
    }
}
