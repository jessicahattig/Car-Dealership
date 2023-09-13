using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Item
  {
    private string _description;
    public string Description { get; set; }
    public Item(string itemDescription)
    {
      _description = itemDescription
    }

    private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}