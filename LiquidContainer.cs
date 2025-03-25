namespace APBD_1_Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isDangerous;

    public LiquidContainer(double maxCapacity, double height, double depth, double ownWeight, bool isDangerous):base(maxCapacity, height, depth, ownWeight, "L")
    {
        this.isDangerous = isDangerous;
    }

    public override void LoadCargo(double weight)
    {
        double limit;
        if (isDangerous)
        {
            limit = MaxCapacity * 0.5;   
        }
        else
        {
            limit = MaxCapacity * 0.9;
        }

        if (weight > limit)
        {
            NotifyDanger($"Overweight of container number {SerialNumber}");
            throw new OverfillException($"Dangerous limit cant be over {limit} kg.");
        }
        base.LoadCargo(weight);
    }

    public void NotifyDanger(string message)
    {
        Console.WriteLine($"Danger: {message}");
    }
}