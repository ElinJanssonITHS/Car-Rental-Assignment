using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Enums;
namespace Car_Rental.Common.Classes;

public class Bookning : IBooking
{
    private double _daysRented;
    public IPerson Customer { get; init; }
    public IVehicle Vehicle { get; init; }
    public string RegNr { get; init; }
    public DateTime DayOfRent { get; init; }
    public DateTime DayOfReturn { get; private set; }
    public double OdometerBeforeRent { get; init; }
    public double Cost {get; private set;}
    public bool RentalStatus { get; private set;}

    
    

    public Bookning(IPerson customer, IVehicle vehicle) 
    { 
        Customer = customer;
        Vehicle = vehicle;
        RegNr = vehicle.RegNo;
        DayOfRent = DateTime.Now;
        OdometerBeforeRent = vehicle.Odometer;
        vehicle.ChangeStatus(VehicleStatuses.Booked);
        RentalStatus = true;
    }

    public void ReturnVehicle(IVehicle vehicle, double kmDriven)
    {
        vehicle.ChangeStatus(VehicleStatuses.Available);
        vehicle.UpdateOdometer(kmDriven);
        DayOfReturn = DateTime.Now;
        CalculateDays(DayOfRent,DayOfReturn);
        Cost = _daysRented * vehicle.CostDay + kmDriven * vehicle.CostKm;
        RentalStatus = false;
    }
    private void CalculateDays(DateTime dayOfRent, DateTime dayOfReturn) 
        => _daysRented = (dayOfReturn - dayOfRent).TotalDays;

}
