using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Enums;
using Car_Rental.Data.Classes;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;
    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<IPerson> GetCustomers()
    {
        return _db.GetPersons().OrderBy(c=>c.LastName);
    }
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {
        //return _db.GetVehicles();         status.Equals(default) && status == default 

        if (status == VehicleStatuses.Booked)
        {
            return _db.GetVehicles().Where(v => v.Status.Equals(VehicleStatuses.Booked));
        }
        else if (status == VehicleStatuses.Available)
        {
            return _db.GetVehicles().Where(v => v.Status.Equals(VehicleStatuses.Available));
        }
        else
            return _db.GetVehicles();

    }
    public IEnumerable<IBooking> GetBookings()
    {
        return _db.GetBooking().OrderBy(b => b.RentalStatus);
    }

    /*Vehicle*/
    //public void AddVehicle() { }
    //public void GetVehicle() { }
    //public void RemoveVehicle() { }

    /*Bookings*/
    //public void GetBooking() { }
    //public void RentVehicle() { }
    //public void ReturnVehicle() { }
    //public void RemoveBooking() { }

    /*Custumer*/
    //public void GetCustomer() { }
    //public void AddCustomer() { }
    //public void RemoveCustomer() { }
    


}
