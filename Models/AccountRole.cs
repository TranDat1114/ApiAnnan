namespace ApiAnnan.Models
{
    public class AccountRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string? RoleDescription { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
