// See https://aka.ms/new-console-template for more information
interface IGeographicObject
{
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    string GetInformation();
}
class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public string GetInformation()
    {
        return $"Name: {Name}, Coordinates: ({X}, {Y}), Description: {Description}, " +
               $"Flow Speed: {FlowSpeed} cm/s, Total Length: {TotalLength} km";
    }
}

class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public string GetInformation()
    {
        return $"Name: {Name}, Coordinates: ({X}, {Y}), Description: {Description}, " +
               $"Highest Point: {HighestPoint} m";
    }
}
