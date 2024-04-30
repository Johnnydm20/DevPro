namespace UITesting.Task2
{
    public class Inventory
    {
        Logger logger = new Logger();

        /// <summary>
        /// Method that sort a list Products
        /// </summary>
        /// <param name="products"> List of products </param>
        /// <param name="sortKey"> Sort key value </param>
        /// <param name="sortOrder"> Sort order value </param>
        /// <returns> A list of Products sorted by key and ascending/descending </returns>
        public List<Product> SortProducts(List<Product> products, string sortKey, bool sortOrder)
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

        /// <summary>
        /// Test method that setup the List products, sort the list and log the sorted list.
        /// </summary>
        [Test]
        public void SortedList()
        {
            //List of products
            List<Product> products = new List<Product>
            {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 }
            };

            //Sort parameters. E.g: sort_key = "price",  ascending = False
            List<Product> sortedProducts = SortProducts(products, "price", false);

            //Log products into inventory.log
            foreach (var product in sortedProducts)
            {
                logger.LogInventory(product.Name, product.Price.ToString(), product.Stock.ToString());
            }
        }
    }
}
