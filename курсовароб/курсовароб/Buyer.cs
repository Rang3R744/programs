namespace course.Models
{
    public class Buyer
    {
        public string FullName { get; set; }
        public string Contact { get; set; }

        public Buyer() { }

        public Buyer(string name, string contact)
        {
            FullName = name;
            Contact = contact;
        }
    }
}
