namespace course.Models
{
    public class Agent
    {
        public string FullName { get; set; }
        public string Agency { get; set; }
        public double Commission { get; set; }

        public Agent() { }

        public Agent(string name, string agency, double commission)
        {
            FullName = name;
            Agency = agency;
            Commission = commission;
        }
    }
}
