using System;


class ParkingChargesTest
{
    static void Main()
    {
        ParkingCharges parkingCharges = new ParkingCharges();

        Console.WriteLine("\n================== Greetings at the Parking meter ==================");

        double total = 0;

        do
        {
            Console.Write("\n\n\nPlease enter the lenght of your parking or 0 to exit: ");
            double parkingChargestheParkingLength = double.Parse(Console.ReadLine());
            parkingCharges.SetParkingLength(parkingChargestheParkingLength);


            Console.WriteLine($"Your charges for the given parking parking lenght is: {parkingCharges.CalculateCharges()}");

            total += parkingCharges.CalculateCharges();

        } while (parkingCharges.GetParkingLength() != 0);

        Console.WriteLine($"\n\nThe total parking spend is: {total}");

        Console.WriteLine("\n\n====== Thank you and good bye! ======");
        
    }
}
