using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.entity
{
    public class CourierCompany
    {
        private string companyName;
        private Courier[] courierDetails;
        private Employee[] employeeDetails;
        private Location[] locationDetails;

        public CourierCompany() { }

        public CourierCompany(string companyName, Courier[] courierDetails, Employee[] employeeDetails, Location[] locationDetails)
        {
            this.companyName = companyName;
            this.courierDetails = courierDetails;
            this.employeeDetails = employeeDetails;
            this.locationDetails = locationDetails;
        }

        public string CompanyName { get => companyName; set => companyName = value; }
        public Courier[] CourierDetails { get => courierDetails; set => courierDetails = value; }
        public Employee[] EmployeeDetails { get => employeeDetails; set => employeeDetails = value; }
        public Location[] LocationDetails { get => locationDetails; set => locationDetails = value; }

        public override string ToString() => $"Company: {CompanyName}";
    }
}
