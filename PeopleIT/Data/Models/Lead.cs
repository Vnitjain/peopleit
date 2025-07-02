using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PeopleIT.Data.Models
{
    public class Lead : IEquatable<Lead>
    {
        public Lead(DateTime quoteSentDate, string salesperson, string projectname, string projectcode, string customer, string customerCity, string customState, string marketingCategoy, int noOfQuotes, double totalNet)
        {
            QuoteSentDate = quoteSentDate;
            Salesperson = salesperson;
            ProjectName = projectname;
            ProjectCode = projectcode;
            Customer = customer;
            CustomerCity = customerCity;
            CustomState = customState;
            MarketingCategory = marketingCategoy;
            NoOfQuotes = noOfQuotes;
            TotalNet = totalNet;
        }
        public Lead()
        {

        }

        public bool Equals(Lead? otherObject)
        {
            return QuoteSentDate == otherObject.QuoteSentDate
             && string.Equals(Salesperson, otherObject.Salesperson, StringComparison.OrdinalIgnoreCase)
             && string.Equals(ProjectName, otherObject.ProjectName, StringComparison.OrdinalIgnoreCase);
        }
        public override bool Equals(object obj) => Equals(obj as Lead);


        public override int GetHashCode()
        {
            return HashCode.Combine(
                QuoteSentDate,
                Salesperson?.ToLowerInvariant(),
                ProjectName?.ToLowerInvariant()
            );
        }
        public DateTime QuoteSentDate { get; set; }

        [StringLength(100)]
        public string Salesperson { get; set; }
        [StringLength(100)]
        public string ProjectName { get; set; }
        [StringLength(100)]
        public string ProjectCode { get; set; }
        [StringLength(100)]
        public string Customer { get; set; }
        [StringLength(100)]
        public string CustomerCity { get; set; }
        [StringLength(100)]
        public string CustomState { get; set; }
        [StringLength(100)]
        public string MarketingCategory { get; set; }
        public int NoOfQuotes { get; set; }
        public double TotalNet { get; set; }



    }
}