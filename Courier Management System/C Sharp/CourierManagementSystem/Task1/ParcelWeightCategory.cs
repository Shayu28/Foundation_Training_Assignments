using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task1
{
    // main/ParcelWeightCategory.cs
    public class ParcelWeightCategory
    {
        public static void CategorizeParcel(float weight)
        {
            switch (weight)
            {
                case <= 2:
                    Console.WriteLine("Light Parcel");
                    break;
                case <= 5:
                    Console.WriteLine("Medium Parcel");
                    break;
                default:
                    Console.WriteLine("Heavy Parcel");
                    break;
            }
        }
    }

}
