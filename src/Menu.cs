namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();
    public string AddDish(object platillo)
    {
        Dish.dishes.add(platillo)
    }
    public string RemoveDish(object platillo)
    {
        Dish.dishes.Remove(platillo)
    }

    public bool GetDishByName(string platillo)
    {
        Dish.dishes.Contains(platillo)
    }
    
}