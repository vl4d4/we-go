namespace Web.Models
{
    public class Company
    {
        public long CompanyId { get; private set; }
        public string CompanyName { get; private set; }

        public Company(long id, string name)
        {
            CompanyId = id;
            CompanyName = name;
        }
    }
}