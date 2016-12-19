using System;

namespace TSMS.Entities
{
    public class Delivery : EntityBase
    {
        public long DeliveryId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public string CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
        public long PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }
    }
}