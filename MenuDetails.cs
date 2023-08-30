using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    //Interface IMenuDetails acting as a contract to specify what needs to be there in a menu mandatorily
    public interface IMenuDetails
    {
       
        public string ItemName { get; set; }
        public decimal Price { get; set; }
       
        

    }

    //Menu has 2 categories of Products: FoodItems and Beverages, which needs to be implemented accordingly

    //Class FoodItem implements IMenuDetails
    public class FoodItem: IMenuDetails
    {
       
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public  string Type { get; set; } // Tells if item is a starter or part of Main Course
        public bool IsVeg { get; set; } //Specifies if the item is part Veg Menu

        //constructor

        public FoodItem(string itemname, decimal price, string type, bool isVeg)
        {
            ItemName= itemname;
            Price= price;
            Type= type;
            IsVeg= isVeg;
        }
    }

    public class Beverage : IMenuDetails
    {
        public bool IsAlcoholic { get; set; } //Specifies if item is alcoholic
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        //constructor
        public Beverage(string itemname, decimal price, bool isalcoholic)
        {
            ItemName = itemname;
            Price = price;
            IsAlcoholic = isalcoholic;
        }
    }
}
