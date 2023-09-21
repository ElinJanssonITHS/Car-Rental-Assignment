using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces
{
    public interface IVehicle
    {
        string RegNo { get; }
        string Make { get; }
        int Odometer { get; }
        VehicleTypes VehicleType { get; }
        double CostKm { get; }
        double CostDay { get; }
        VehicleStatuses Status { get; }
        void ChangeStatus (VehicleStatuses status);

    }
}
