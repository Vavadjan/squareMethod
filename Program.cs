namespace squareMethod
{
    internal class Program
    {
        
            static int SquareMethod(int side)
        {
            int result = side * side;
            return result;
        }
        
            static void Main(string[] args)
        {
            Console.WriteLine("Программа посчитает площадь квадрата");
            Console.WriteLine("Введите длинну стороны квадрата в метрах");

            int side = Convert.ToInt32(Console.ReadLine());

            int result = SquareMethod(side);

            Console.WriteLine("Площадь квадрата - " + result + " метров квадратных.");
        }
    }
}