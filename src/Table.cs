using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;

    public int Number
    {
        get { return this.number;}
        set { number = value; }
    }

    private bool isoccupied;

    public bool IsOcuppied
    {
        get { return this.isoccupied;}
        set { isoccupied = value; }
    }
    private ArrayList order = new ArrayList();

    public bool Occupy()
    {
        return this.isoccupied;
    }

    public void Free()
    {
        this.order.Clear();
        this.isoccupied = false;
    }
    
    public void AddToOrder(Dish dish)
    {
        this.order.Add(dish);
    }
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }

    public Table(int numero, bool OcupadaoNo)
    {
        number = numero;
        isoccupied = OcupadaoNo;
    }
}
