using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.entity
{
    public class Courier
    {
        private static int trackingSeed = 1000;

        private int courierID;
        private string senderName;
        private string senderAddress;
        private string receiverName;
        private string receiverAddress;
        private double weight;
        private string status;
        private string trackingNumber;
        private DateTime deliveryDate;
        private int userId;

        public Courier()
        {
            trackingNumber = GenerateTrackingNumber();
        }

        public Courier(int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress,
                       double weight, string status, DateTime deliveryDate, int userId)
        {
            this.courierID = courierID;
            this.senderName = senderName;
            this.senderAddress = senderAddress;
            this.receiverName = receiverName;
            this.receiverAddress = receiverAddress;
            this.weight = weight;
            this.status = status;
            this.deliveryDate = deliveryDate;
            this.userId = userId;
            this.trackingNumber = GenerateTrackingNumber();
        }

        private string GenerateTrackingNumber() => $"TRK{trackingSeed++}";

        public int CourierID { get => courierID; set => courierID = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string ReceiverName { get => receiverName; set => receiverName = value; }
        public string ReceiverAddress { get => receiverAddress; set => receiverAddress = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Status { get => status; set => status = value; }
        public string TrackingNumber { get => trackingNumber; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public int UserId { get => userId; set => userId = value; }

        public override string ToString() => $"Courier: {CourierID}, Tracking: {TrackingNumber}, Status: {Status}";
    }
}
