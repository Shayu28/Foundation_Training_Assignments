using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.entity
{
    public class CourierCompanyCollection
    {
        public string CompanyName { get; set; }
        public List<Courier> CourierDetails { get; set; }
        public List<Employee> EmployeeDetails { get; set; }
        public List<Location> LocationDetails { get; set; }

        public CourierCompanyCollection()
        {
            CourierDetails = new List<Courier>();
            EmployeeDetails = new List<Employee>();
            LocationDetails = new List<Location>();
        }

        public CourierCompanyCollection(string companyName) : this()
        {
            CompanyName = companyName;
        }

        public override string ToString()
        {
            return $"CourierCompanyCollection: {CompanyName}, Couriers: {CourierDetails.Count}, Employees: {EmployeeDetails.Count}, Locations: {LocationDetails.Count}";
        }
    }
}
