using System.ComponentModel.DataAnnotations;

namespace CrankBank.Data
{
    public class AccountSummaries
    {
        [Key]
        public string AccountNumber { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
