class Program {
    class Cricle
    {
        int Radius { get; set; }

        public Cricle(int radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            double area = 3.14 * Radius * Radius;
            Console.WriteLine("Area of circle is: " + area);
        }
    }
    static void Main()
    {
        Cricle c = new Cricle(5);
        c.GetArea();
    }
}