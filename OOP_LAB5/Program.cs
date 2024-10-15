class Program
{
    class Cricle
    {
        int Radius { get; set; }
        double Volume { get; set; }
        double Circumference { get; set; }

        public Cricle(int radius)
        {
            Radius = radius;
        }

        public void GetArea()
        {
            double area = 3.14 * Radius * Radius;
            Console.WriteLine("Area of circle is: " + area);
        }
        
        public void GetVolume()
        {
            Volume = (4.0 / 3) * Math.PI * Math.Pow(Radius, 3);
            Console.WriteLine("Volume of circle is: " + Volume);
        }
        
        public void GetCircumference()
        {
            Circumference = 2 * Math.PI * Radius;
            Console.WriteLine("Circumference of circle is: " + Circumference);
        }
    }

    static void Main()
    {
        Cricle c = new Cricle(5);
        c.GetArea();
        c.GetVolume();
        c.GetCircumference();
    }
}