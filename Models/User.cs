namespace ApiAnnan.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }


        public int AccountRoleId { get; set; }
        public virtual AccountRole AccountRole { get; set; }

        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
