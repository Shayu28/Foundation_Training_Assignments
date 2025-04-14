using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.entity;
using CourierManagementSystem.exception;

namespace CourierManagementSystem.dao
{
    public class CourierUserServiceCollectionImpl : ICourierUserService
    {
        protected CourierCompanyCollection companyObj;

        public CourierUserServiceCollectionImpl()
        {
            companyObj = new CourierCompanyCollection("Hexaware Courier Co.");
        }

        public string PlaceOrder(Courier courierObj)
        {
            companyObj.CourierDetails.Add(courierObj);
            return courierObj.TrackingNumber;
        }

        public string GetOrderStatus(string trackingNumber)
        {
            foreach (var c in companyObj.CourierDetails)
            {
                if (c.TrackingNumber == trackingNumber)
                {
                    return c.Status;
                }
            }
            throw new TrackingNumberNotFoundException("Tracking number not found.");
        }

        public bool CancelOrder(string trackingNumber)
        {
            var courier = companyObj.CourierDetails.Find(c => c.TrackingNumber == trackingNumber);
            if (courier != null)
            {
                courier.Status = "Cancelled";
                return true;
            }
            throw new TrackingNumberNotFoundException("Cannot cancel. Tracking number not found.");
        }

        public List<Courier> GetAssignedOrder(int courierStaffId)
        {
            return companyObj.CourierDetails.FindAll(c => c.UserId == courierStaffId);
        }
    }
}
