using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.dao
{
    public interface ICourierUserService
    {
        // Place a new courier order
        string PlaceOrder(Courier courierObj);
        // Get status of the courier order
        string GetOrderStatus(string trackingNumber);
        // Cancel a courier order
        bool CancelOrder(string trackingNumber);
        // Get all orders assigned to a specific courier staff
        List<Courier> GetAssignedOrder(int courierStaffId);
    }
}
