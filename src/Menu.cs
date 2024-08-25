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
        this.dishes.Add(platillo)
    }
    public string RemoveDish(object platillo)
    {
        this.dishes.Remove(platillo)
    }

    public bool GetDishByName(string platillo)
    {
        if (this.dishes.Contains(platillo) == true)
        {
            return this.Name
        }
        return null
    }
    public Menu()
    {
        this.dishes = new Arraylist 
    }
}