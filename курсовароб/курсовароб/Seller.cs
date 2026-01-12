namespace course.Models
{
    public class Seller
    {
        public string FullName { get; set; }
        public string Contact { get; set; }

        public Seller() { }

        public Seller(string name, string contact)
        {
            FullName = name;
            Contact = contact;
        }
    }
}
