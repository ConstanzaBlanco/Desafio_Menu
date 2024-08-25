using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();
    private string name 
    {
        get { return this.name; }
        set { name = value; }
    }

    public void AssignTable(Table table)
    {
         assignedTables.Add(Table.Number) ;
    }

    public void TakeOrder(Table table, Dish dish)
    {
        (Table.Number).AddToOrder(dish);
        
    }
}