using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("Roles")]
    public abstract class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
