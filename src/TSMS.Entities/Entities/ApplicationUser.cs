using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TSMS.Entities.Interfaces;

namespace TSMS.Entities
{

    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser,IEntity
    {
        public ApplicationUser()
        {
            
        }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; }
     
        public long PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }

        public bool IsActive { get; set; }
        public string Note { get; set; }

        public DateTime Created { get; set; }


        public DateTime Modified { get; set; }

    }

}
