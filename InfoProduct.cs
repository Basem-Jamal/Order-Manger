using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Order_Manager
{
    internal class InfoProduct
    {
        InfoProduct data;

        string pathFromInfoProduct = @"C:\Users\basem\source\repos\14 - C# - Level 1\Desktop app\Order Manager\Data Products\InfoAllProducts.json";

        public List<InfoProduct> Products { get; set; }
        public string Product_Name { get; set; }
        public string Product_Category { get; set; }
        public string Product_Image { get; set; }
        public string Product_Price { get; set; }
        public string Product_SKU { get; set; }
        public string unit { get; set; }

        public void StartInfoProducts()
        {
            string json = File.ReadAllText(pathFromInfoProduct);
            Products = JsonSerializer.Deserialize<List<InfoProduct>>(json);
        }

    }

}