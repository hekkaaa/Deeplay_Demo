using Data.Enum;

namespace Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Middlename { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public virtual Role Role { get; set; }
        public bool IsDeleted { get; set; }
    }
}
