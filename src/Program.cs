namespace Ucu.Poo.Restaurant;
class Program
{
    static void Main(string[] args)
    {
        Dish ensalada = new Dish("Ensalada", 10, false);
        Dish strogonof = new Dish("Strogonof", 20, false);
        Dish pizza = new Dish("Pizza", 10, true);
        Dish hamburguesa = new Dish("Hamburguesa", 15, false);
        Dish ratatouille = new Dish("Ratatouille", 25, true);
        Dish pescado = new Dish("Pescado", 10, false);
        Dish milanesa = new Dish("Milanesa", 15, false);
        Dish asado = new Dish("Asado", 20, false);
        ensalada.Description();
    }
}