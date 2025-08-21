namespace Calculate_Rectangle_Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double width, height, area;

            width = double.Parse(Console.ReadLine() ?? "0"); 
            height = double.Parse(Console.ReadLine() ?? "0");

            area = GetRectangleArea(width, height);

            Console.WriteLine(area);

            static double GetRectangleArea(double width, double height)
            {
                return width * height;
            }
        }
    }
}
