using System;
using System.ComponentModel.DataAnnotations;

namespace ASP.Net_MVC_Fundamentals.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        [Display(Name ="Date of Birth")] 
        public DateTime? birthdate { get; set; }
    }
}