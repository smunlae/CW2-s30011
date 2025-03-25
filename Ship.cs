namespace APBD_1_Containers;

public class Ship
{
    public List<Container> Containers { get; private set; } = new List<Container>();
    public int MaxContainers { get; private set; }
    public double MaxWeight { get; private set; }
    public double Speed { get; private set; }

    public Ship(int maxContainers, double maxWeight, double speed)
    {
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        Speed = speed;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new Exception("Too many containers!");
        
        double totalWeight = Containers.Sum(c => c.OwnWeight + c.CargoWeight);
        if (totalWeight + container.OwnWeight + container.CargoWeight > MaxWeight * 1000)
            throw new Exception("Too many kg!");

        Containers.Add(container);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"This ship transports {Containers.Count} containers. The speed is: {Speed} knots.");
    }
}
