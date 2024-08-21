using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private float price;
    public float Price
    {
        get { return price; }
        set { price = value; }
    }

    private bool isvegetarian;
    public bool IsVegetarian
    {
        get { return isvegetarian; }
        set { isvegetarian = value; }
    }

    public Dish(string name, float price, bool isvegetarian)
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = isvegetarian;
    }

    public void Description()
    {
        Console.WriteLine($"nombre: {this.Name} precio: {this.Price}$ Es Vegatariano: {this.IsVegetarian}");
    }
}

