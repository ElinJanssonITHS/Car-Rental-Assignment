using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Classes;

namespace Car_Rental.Common.Interfaces
{
    public interface IBooking
    {
        void ReturnVehicle(IVehicle vehicle);
        
    }
}
