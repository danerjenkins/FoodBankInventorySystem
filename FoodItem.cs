using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBankInventorySystem;

public class FoodItem
{
    public string Name;
    public string Category;
    public string Quantity;
    public string ExpirationDate;

    public FoodItem(string n, string c, string q, string eD)
    {
        this.Name = n;
        this.Category = c;
        this.Quantity = q;
        this.ExpirationDate = eD;
    }
}
