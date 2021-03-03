using System;
using sales_system;

namespace sales_system_2
{
    public class Store
    {
        Seller[] Sellers = new Seller[10];
        int sellersCount = 0;

        Product[] Products = new Product[20];
        int productsCount = 0;

        Sale[] Sales = new Sale[10 * 20];
        int salesCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellersCount] = newSeller;
            sellersCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }
    }
}
