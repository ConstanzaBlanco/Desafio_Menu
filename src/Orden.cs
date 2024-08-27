using System.Runtime.InteropServices.JavaScript;
namespace Ucu.Poo.Restaurant;
using System.Collections;

public class Order
{
    public ArrayList Platos { get; set; } = new ArrayList();

    public double GetTotal()
    {
        double total = 0;
        foreach (Dish plato in this.Platos)
        {
            total += plato.Price;
        }

        return total;
    }

    public void AddToOrder(Dish dish)
    {
        this.Platos.Add(dish);
    }
}
