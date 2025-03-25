namespace APBD_1_Containers;

public class Container
{
    private static int counter = 1;
    public string SerialNumber { get; private set; }
    public double CargoWeight { get; private set; }
    public double MaxCapacity { get; private set; }
    public double Height { get; private set; }
    public double Depth {get; private set;}
    public double OwnWeight { get; private set; }

    public Container(double maxCapacity, double height, double depth, double ownWeight, string type)
    {
        MaxCapacity = maxCapacity;
        Height = height;
        Depth = depth;
        OwnWeight = ownWeight;
        SerialNumber = $"KON-{type}-{counter++}";
    }

    public virtual void LoadCargo(double weight)
    {
        if (weight > MaxCapacity)
            throw new OverfillException($"Overweight! {SerialNumber} cant get {weight} kg");
                
        CargoWeight = weight;
    }

    public virtual void UnloadCargo()
    {
        CargoWeight = 0;
    }
    
    protected void SetCargoWeight(double weight)
    {
        CargoWeight = weight;
    }
    
} 
