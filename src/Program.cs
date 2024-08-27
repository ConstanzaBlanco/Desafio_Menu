namespace Ucu.Poo.Restaurant;
class Program
{
    static void Main(string[] args)
    {
        Dish ensalada = new Dish("Ensalada", 10, true);
        Dish strogonof = new Dish("Strogonof", 20, false);
        Dish pizza = new Dish("Pizza", 10, true);
        Dish hamburguesa = new Dish("Hamburguesa", 15, false);
        Dish ratatouille = new Dish("Ratatouille", 25, true);
        Dish pescado = new Dish("Pescado", 10, false);
        Dish milanesa = new Dish("Milanesa", 15, false);
        Dish asado = new Dish("Asado", 20, false);
        ensalada.Description();
        Menu Menu_del_dia = new Menu();
        Menu_del_dia.AddDish(milanesa);
        Menu_del_dia.AddDish(pizza);
        Menu_del_dia.AddDish(hamburguesa);
        Menu_del_dia.Print_Menu();
        Console.WriteLine(Menu_del_dia.GetDishByName("Hamburguesa"));
        Table PrimerMesa = new Table(1);
        Console.WriteLine(PrimerMesa.IsOccupied.ToString());
        Order OrdenPrimerMesa = new Order();
        OrdenPrimerMesa.AddToOrder(hamburguesa);
        OrdenPrimerMesa.AddToOrder(pizza);
        PrimerMesa.emparejar(OrdenPrimerMesa);
        PrimerMesa.HasOrders();
        Console.WriteLine(PrimerMesa.IsOccupied.ToString());
        Waiter Jose = new Waiter();
        Jose.AssignTable(PrimerMesa);
        Console.WriteLine(Jose.GetTotal(PrimerMesa).ToString());
    }
}
