namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    public ArrayList Dishes
    {
        get {return dishes;}
    }

    public void AddDish(Dish platillo)
    {
        dishes.Add(platillo);
    }

    public void RemoveDish(Dish platillo)
    {
        dishes.Remove(platillo);
    }

    public object GetDishByName(string platillo)
    {
        if (dishes.Contains(platillo))
        {
            return platillo;
        }

        return null;
    }

    public void Print_Menu()
    {
        foreach (Dish platillo in Dishes)
        {
            Console.WriteLine(platillo.Name);
        }
    }
}
