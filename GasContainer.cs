namespace APBD_1_Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; private set; }

    public GasContainer(double maxCapacity, double height, double depth, double ownWeight, double pressure)
        : base(maxCapacity, height, depth, ownWeight, "G")
    {
        Pressure = pressure;
    }

    public override void UnloadCargo()
    {
        SetCargoWeight(CargoWeight * 0.05);
    }

    public void NotifyDanger(string message)
    {
        Console.WriteLine($"ОПАСНОСТЬ! {message}");
    }
}

