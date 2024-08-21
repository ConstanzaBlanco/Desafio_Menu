using System.Diagnostics;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish 
{
    private string Name
    {
        get { return Name; }
        set { Name = value; }
    }

    private string Price
    {
        get { return Price; }
        set { Price = value; }
    }

    private string IsVegetarian
    {
        get { return IsVegetarian; }
        set { IsVegetarian = value; }
    }

    public Dish(string name, string price, string isvegetarian)
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = isvegetarian;
    }
}