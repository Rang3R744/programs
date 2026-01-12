namespace course.Models
{
    public class House : Property
    {
        public double LandArea { get; set; }

        public House() : base()
        {
            type = "Будинок";
        }

        public House(string address, int area, double price, double landArea)
            : base(address, area, price)
        {
            type = "Будинок";
            LandArea = landArea;
        }

        public override double CalculateValue()
        {
            return Price + LandArea * 2000;
        }
    }
}
