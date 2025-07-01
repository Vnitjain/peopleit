using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PeopleIT.Data.Models
{
    [Keyless]
    public class Lead
    {
        public Lead(DateTime quoteSentDate, string salesperson, string projectname, string projectcode, string customer,string customerCity,string customState, string marketingCategoy, int noOfQuotes, double totalNet)
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