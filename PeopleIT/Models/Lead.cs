namespace PeopleIT.Models
{
    // Connection String
    // Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
    public class Lead
    {
        public Lead(string quoteSentDate, string salesperson, string projectname, string projectcode, string customer)
        {
            QuoteSentDate = quoteSentDate;
            Salesperson = salesperson;
            ProjectName = projectname;
            ProjectCode = projectcode;
            Customer = customer;
        }
        public string QuoteSentDate { get; set; }
        public string Salesperson { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string Customer { get; set; }
    }
}