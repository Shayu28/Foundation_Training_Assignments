using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.entity
{
    public class Employee
    {
        private int employeeID;
        private string employeeName;
        private string email;
        private string contactNumber;
        private string role;
        private double salary;

        public Employee() { }

        public Employee(int employeeID, string employeeName, string email, string contactNumber, string role, double salary)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.email = email;
            this.contactNumber = contactNumber;
            this.role = role;
            this.salary = salary;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Role { get => role; set => role = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString() => $"Employee: {EmployeeID}, {EmployeeName}, Role: {Role}";
    }
}
