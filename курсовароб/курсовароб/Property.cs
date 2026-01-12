using System;

namespace course.Models
{
    public abstract class Property : IComparable<Property>
    {
        protected string type; 

        private string address;
        private int area;
        private double price;
        private string status;

        public string Address { get => address; set => address = value; }
        public int Area { get => area; set => area = value; }
        public double Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public string Type => type;

        public Property()
        {
            address = "Невідомо";
            area = 0;
            price = 0.0;
            status = "Продається";
        }

        public Property(string address, int area, double price)
            : this()
        {
            this.address = address;
            this.area = area;
            this.price = price;
        }

        public virtual double CalculateValue()
        {
            return price;
        }

        public int CompareTo(Property other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Type}: {Address}, {Area} м², {Price}$, {Status}";
        }
    }
}
