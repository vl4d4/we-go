using System;
using Web.Models;
using Xunit;

namespace Tests
{
    public class CompanySpecs
    {
        [Fact]
        public void Companies_are_equal()
        {
            var company1 = new Company(1, "NAXI");
            var company2 = new Company(1, "NAXI");

            Assert.Equal(company1, company2);
        }
    }
}
