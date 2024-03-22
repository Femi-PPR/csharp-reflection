namespace Reflection
{
  class Car
  {
    string make;
    string model;
    string registration;
    int year;
    double currentValue;
    
    public Car(string make, string model, string registration, int year, double currentValue)
    {
      this.make = make;
      this.model = model;
      this.registration = registration;
      this.year = year;
      this.currentValue = currentValue;
    }
    
    public double getValue()
    {
      return this.currentValue;
    }
    
    public int getYear()
    {
      return this.year;
    }
    
    public override string ToString()
    {
      return "Car{\r\n" +
        $"  Make: {this.make}\r\n" +
        $"  Model: {this.model}\r\n" +
        $"  Registration: {this.registration}\r\n" +
        $"  Year of Initial Registration: {this.year}\r\n" +
        $"  Current Value: £{this.currentValue:f2}\r\n" +
        "}";
    }
  }
}
  