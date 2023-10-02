// See https://aka.ms/new-console-template for more information
using System;

abstract class GeographicObject
{
    public double X;
    public double Y;
    public string Name;
    public string Description;
    public virtual string GetInformation()
    {
        return "Name: {Name}, Coordinates: ({X}, {Y}), Description: {Description}";
    }

}
class River : GeographicObject
{
    public double FlowSpeed;
    public double TotalLength;
    public override string GetInformation()
    {
        return base.GetInformation() + ", Flow Speed: {FlowSpeed} см/с, Total Length: {TotalLength} км";
    }
}
    class Mountain : GeographicObject
{
    public double HighestPoint;
    public override string GetInformation()
    {
        return base.GetInformation() + ", Highest Point: {HighestPoint} м";
    }
}
class Program
{
    static void Main(string[] args)
    {
        River river = new River
        {
            X = 45.678,
            Y = 34.567,
            Name = "Dnipro",
            Description = "The largest river in Ukraine",
            FlowSpeed = 50.0,
            TotalLength = 2200.0
        };

        Mountain mountain = new Mountain
        {
            X = 48.123,
            Y = 25.567,
            Name = "Carpathians",
            Description = "The largest mountain range in Ukraine and neighbouring countries",
            HighestPoint = 2061.0
        };

        Console.WriteLine("Information about the river:");
        Console.WriteLine($"Name: {river.Name}");
        Console.WriteLine($"Coordinates: ({river.X}, {river.Y})");
        Console.WriteLine($"Description: {river.Description}");
        Console.WriteLine($"Flow Speed: {river.FlowSpeed} cm/s");
        Console.WriteLine($"Total Length: {river.TotalLength} km");

        Console.WriteLine("\nInformation about the mountain:");
        Console.WriteLine($"Name: {mountain.Name}");
        Console.WriteLine($"Coordinates: ({mountain.X}, {mountain.Y})");
        Console.WriteLine($"Description: {mountain.Description}");
        Console.WriteLine($"Highest Point: {mountain.HighestPoint} m");

        Console.ReadKey();
    }
}
  
    
