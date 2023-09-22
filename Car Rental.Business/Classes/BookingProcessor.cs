using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Classes;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;
    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<Customer> GetCustomers()
    {
        return (IEnumerable<Customer>)_db.GetPersons();
    }
    public IEnumerable<IVehicle> GetVehicles()
    {
        return _db.GetVehicles();
    }
    public IEnumerable<IBooking> GetBookings()
    {
        return _db.GetBooking();
    }

    /*Vehicle*/
    public void AddVehicle() { }
    public void GetVehicle() { }
    public void RemoveVehicle() { }

    /*Bookings*/
    public void GetBooking() { }
    public void RentVehicle() { }
    public void ReturnVehicle() { }
    public void RemoveBooking() { }

    /*Custumer*/
    public void GetCustomer() { }
    public void AddCustomer() { }
    public void RemoveCustomer() { }
    


}
