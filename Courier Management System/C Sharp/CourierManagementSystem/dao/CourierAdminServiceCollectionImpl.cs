using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.entity;

namespace CourierManagementSystem.dao
{
    public class CourierAdminServiceCollectionImpl : CourierUserServiceCollectionImpl, ICourierAdminService
    {
        public int AddCourierStaff(Employee employee)
        {
            int newId = companyObj.EmployeeDetails.Count + 1;
            employee.EmployeeId = newId;
            companyObj.EmployeeDetails.Add(employee);
            return newId;
        }
    }
}
