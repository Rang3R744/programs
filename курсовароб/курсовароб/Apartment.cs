namespace course.Models
{
    public class Apartment : Property
    {
        public int Floor { get; set; }

        public Apartment() : base()
        {
            type = "Квартира";
        }

        public Apartment(string address, int area, double price, int floor)
            : base(address, area, price)
        {
            type = "Квартира";
            Floor = floor;
        }

        public override double CalculateValue()
        {
            return Price * 1.05; 
        }
    }
}
