namespace StockControl {
    internal class Product {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string getProductInfo() {
            return $"Product: {Name}, Price: ${Price}, Quantity: {Quantity}";
        }

    }
}
