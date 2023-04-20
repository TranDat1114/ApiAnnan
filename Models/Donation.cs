namespace ApiAnnan.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public double Amount { get; set; }
        public DateTime DonationDate { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }
}
