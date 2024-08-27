using System.ComponentModel;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private List<Dish> dishes = new List<Dish>();

    public List<Dish> Dishes
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
        foreach (Dish plato in dishes)
        {
            Console.WriteLine(plato.Name);
            if (plato.Name == platillo)
            {
                return plato;
            }
        }
        return null;
    }

    public void Print_Menu()
    {
        foreach (Dish platillo in Dishes)
        {
            platillo.Description();
        }
    }
}
