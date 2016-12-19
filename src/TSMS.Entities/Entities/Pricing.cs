using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TSMS.Entities
{
    public class Pricing : EntityBase
    {
        public long  PricingId { get; set; }

        [DataType(DataType.Currency)]
        public decimal BreakfastCost { get; set; }

        [DataType(DataType.Currency)]
        public decimal LunchCost { get; set; }

        [DataType(DataType.Currency)]
        public decimal DinnerCost { get; set; }
       
        public virtual  ICollection<ApplicationUser> Customers { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}