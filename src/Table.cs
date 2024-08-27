using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;
    private Order context;
    private ArrayList Lista_platos = new ArrayList();
    public int Number
    {
        get { return this.number;}
        set { number = value; }
    }

    public void emparejar(Order order)
    {
        this.context = order;
    }
    private bool isoccupied;

    public bool IsOccupied
    {
        get { return this.isoccupied;}
        set { isoccupied = value; }
    }

    public bool Ocupy()
    {
        return this.isoccupied;
    }
    
    public void FreeTable()
    {
        this.context.Platos.Clear();
        this.isoccupied = false;
    }

    public Order Dar_emparejada()
    {
        return this.context;
    }
    public bool HasOrders()
    {
        this.isoccupied = true;
        return this.context.Platos.Count > 0;
    }

    public Table(int numero)
    {
        number = numero;
    }
    
}
