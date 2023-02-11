namespace ArchitectArithmetic
{
    class Program
    {
        // area of rectangle
        static double rectArea(double length, double width) {
            return (length * width);
        }
        // area of circle
        static double circleArea(double radius) {
            return (Math.PI * Math.Pow(radius, 2));
        }
        // area of triangle
        static double triangleArea(double bottom, double height) {
            return (0.5 * bottom * height);
        }

        // Teotihuacan cost method
        // (design in the included JPG file)
        static void costOfTeotihuacan()
        {
            // finding total area
            double totalArea = 0;
            totalArea += rectArea(2500, 1500);
            totalArea += triangleArea(750, 500);
            totalArea += (circleArea(375) / 2);
            // currency is Mexican pesos
            // 180 Mexican pesos per sqaure area
            double totalCosts = totalArea * 180;
            // printing result
            Console.WriteLine($"Total Area = {Math.Round(totalArea, 2)} Square Meters");
            Console.WriteLine($"Per Square Cost = 180 Mexican Pesos");
            Console.WriteLine($"Total Estimated Costs = {Math.Round(totalCosts, 2)} Mexican Pesos");
        }

        // main
        public static void Main(string[] args)
        {
            costOfTeotihuacan();
        }
    }
}