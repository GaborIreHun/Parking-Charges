using System;

class ParkingCharges
{

    public double minimumCharge = 2;
    public double parkingLength;
    public double maximumCharge = 10;
    public double calculateCharges;

    public void SetParkingLength(double parkingChargesParkingLength)
    {
        parkingLength = parkingChargesParkingLength;
    }

    public double GetParkingLength()
    {
        return parkingLength;
    }


    public double CalculateCharges()
    {
        if (parkingLength > 0 && parkingLength <= 3)
        {
            calculateCharges = minimumCharge;
            return calculateCharges;
        }
        else if (parkingLength > 3 && parkingLength < 19)
        {
            calculateCharges = Math.Ceiling(parkingLength) * 0.50 + minimumCharge - 1.5;
            return calculateCharges;
        }
        else if (parkingLength >= 19 && parkingLength <= 24)
        {
            calculateCharges = maximumCharge;
            return calculateCharges;
        }
        else if (parkingLength == 0)
        {
            calculateCharges = 0;
            return calculateCharges;
        }
        else
            calculateCharges = maximumCharge + Math.Ceiling(parkingLength) * 0.50 - 12;
            return calculateCharges;
    }

}


    
    


