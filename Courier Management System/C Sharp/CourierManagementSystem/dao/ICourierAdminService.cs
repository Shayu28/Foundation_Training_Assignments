using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.entity;

namespace CourierManagementSystem.dao
{
    public interface ICourierAdminService
    {
        // Add a new courier staff
        int AddCourierStaff(Employee obj);
    }
}
