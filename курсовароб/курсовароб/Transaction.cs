using System;

namespace course.Models
{
    public class Transaction
    {
        public Property Property { get; set; }
        public Buyer Buyer { get; set; }
        public Seller Seller { get; set; }
        public Agent Agent { get; set; }
        public double FinalPrice { get; set; }
        public DateTime Date { get; set; }

        public Transaction() { }

        public Transaction(Property property, Buyer buyer, Seller seller, Agent agent, double finalPrice)
        {
            Property = property;
            Buyer = buyer;
            Seller = seller;
            Agent = agent;
            FinalPrice = finalPrice;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Property.Type} {Property.Address} – {FinalPrice}$ ({Date.ToShortDateString()})";
        }
    }
}
