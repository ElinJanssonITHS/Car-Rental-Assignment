using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    private string _regNo;
    private string _make;
    private int _odometer;
    private VehicleTypes _vehicleType;
    private double _costKm;
    private double _costDay;
    private VehicleStatuses _status;
    public string RegNo => _regNo;

    public string Make => _make;

    public int Odometer => _odometer;

    public VehicleTypes VehicleType => _vehicleType;

    public double CostKm => _costKm;

    public double CostDay => _costDay;

    public VehicleStatuses Status => _status;
    public Car(string regNr, string make, int odometer, VehicleTypes vehicleType, double costKm, double costDay)
    {
        _regNo = regNr;
        _make = make;
        _odometer = odometer;
        _vehicleType = vehicleType;
        _costKm = costKm;
        _costDay = costDay;
    }

    public void ChangeStatus(VehicleStatuses status) => _status = status;
}
