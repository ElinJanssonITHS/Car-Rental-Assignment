﻿using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Classes;

public class Motorcycle : IVehicle
{
    private string _regNo;
    private string _make;
    private double _odometer;
    private VehicleTypes _vehicleType;
    private double _costKm;
    private double _costDay;
    private VehicleStatuses _status = VehicleStatuses.Available;
    public string RegNo => _regNo;

    public string Make => _make;

    public double Odometer => _odometer;

    public VehicleTypes VehicleType => _vehicleType;

    public double CostKm => _costKm;

    public double CostDay => _costDay;

    public VehicleStatuses Status => _status;
    public Motorcycle(string regNr, string make, int odometer, VehicleTypes vehicleType, double costKm, double costDay)
    {
        _regNo = regNr;
        _make = make;
        _odometer = odometer;
        _vehicleType = vehicleType;
        _costKm = costKm;
        _costDay = costDay;
    }

    public void ChangeStatus(VehicleStatuses status) => _status = status;
    public void UpdateOdometer(double km) => _odometer += km;
}
