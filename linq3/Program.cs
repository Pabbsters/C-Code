using System.Globalization;

class Program
{
    static void Main()
    {
        var options = new List<Menu>
        {
            new Menu() {Food = "pizza", Price = 8.99},
            new Menu() {Food = "fries", Price = 4.99},
            new Menu() {Food = "ice cream", Price = 5.99}
        };
        var pizzaOnly = options.Where(f => f.Food == "pizza").Select(p => p.Price);
        foreach(var f in pizzaOnly)
        {
            Console.WriteLine(f);
        }
    }
}
class Menu
{
    public String Food { get; set; }
    public double Price{ get; set; }
}