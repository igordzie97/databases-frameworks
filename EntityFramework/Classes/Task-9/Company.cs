using System;
namespace IgorDzierwaEFProducts
{
    public abstract class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }
}

