// See https://aka.ms/new-console-template for more information


Book book=new Book();
book.ProductName = "A Tale of two Cities";

InventoryItem item = new Book();

public abstract class Vehicle
{
    public string VIN { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int YearManufactured { get; set; }
}

public class Car:Vehicle
{
    public int NumberOfWheels { get; set; } = 4;

}
