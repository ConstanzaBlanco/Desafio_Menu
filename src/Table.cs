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
        return 
    }
    
    
    
    
    
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}