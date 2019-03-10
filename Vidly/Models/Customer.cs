using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Resources;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = nameof(CustomerResources.Name), ResourceType = typeof(CustomerResources))]
        public string Name { get; set; }

        [Display(Name = nameof(CustomerResources.IsSubscribedToNewsletter), ResourceType = typeof(CustomerResources))]
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = nameof(CustomerResources.MembershipTypeId), ResourceType = typeof(CustomerResources))]
        public byte MembershipTypeId { get; set; }

        [Display(Name = nameof(CustomerResources.BirthDate), ResourceType = typeof(CustomerResources))]
        public DateTime? BirthDate { get; set; }
    }
}