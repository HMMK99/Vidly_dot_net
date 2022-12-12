using System.ComponentModel.DataAnnotations;

namespace vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; } // 2nd edit
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; } //3rd edit
    }
}