namespace UITesting.Task2
{
    public class Inventory
    {
        Logger logger = new Logger();

        public static List<Product> SortProducts(List<Product> products, string sortKey, bool sortOrder)
        {
            switch (sortKey.ToLower())
            {
                case "name":
                    if (sortOrder.Equals(true))
                        return products.OrderBy(p => p.Name).ToList();
                    else
                        return products.OrderByDescending(p => p.Name).ToList();
                case "price":
                    if (sortOrder.Equals(true))
                        return products.OrderBy(p => p.Price).ToList();
                    else
                        return products.OrderByDescending(p => p.Price).ToList();
                case "stock":
                    if (sortOrder.Equals(true))
                        return products.OrderBy(p => p.Stock).ToList();
                    else
                        return products.OrderByDescending(p => p.Stock).ToList();
                default:
                    throw new ArgumentException("Invalid sort key");
            }
        }
        [Test]
        public void prueba()
        {
            //List of products
            List<Product> products = new List<Product>
            {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 }
            };

            //Sort parameters
            List<Product> sortedProducts = SortProducts(products, "stock", true);

            // Log products into inventory.log
            foreach (var product in sortedProducts)
            {
                logger.LogInventory(product.Name, product.Price.ToString(), product.Stock.ToString());
            }
        }
    }
}
