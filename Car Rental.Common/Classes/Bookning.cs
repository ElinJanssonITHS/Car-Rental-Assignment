using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Bookning : IBooking
{
    DateTime DayOfRent { get; init; }

    public Bookning() { }

    public void ReturnVehicle(IVehicle vehicle)
    {
        
        
    }

}
