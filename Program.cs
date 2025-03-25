using APBD_1_Containers;

class Program
{
    static void Main()
    {
        Ship ship = new Ship(5, 10000, 30);

        var liquidContainer = new LiquidContainer(5000, 200, 300, 1000, true);
        var gasContainer = new GasContainer(4000, 180, 250, 800, 10);
        var fridgeContainer = new RefrigeratedContainer(3000, 170, 260, 900, "bananas", 13.3);

        try
        {
            liquidContainer.LoadCargo(3000); // Overload of dangerous container
        }
        catch (OverfillException ex)
        {
            Console.WriteLine(ex.Message);
        }

        ship.LoadContainer(liquidContainer);
        ship.LoadContainer(gasContainer);
        ship.LoadContainer(fridgeContainer);
        
        ship.PrintInfo();
    }
}