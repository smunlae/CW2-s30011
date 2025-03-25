namespace APBD_1_Containers;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; private set; }
    public double Temperature { get; private set; }

    public RefrigeratedContainer(double maxCapacity, double height, double depth, double ownWeight, string productType, double temperature)
        : base(maxCapacity, height, depth, ownWeight, "C")
    {
        ProductType = productType;
        Temperature = temperature;
    }
}
