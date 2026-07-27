namespace StockControl {
    internal class Program {
        static void Main(string[] args) {

            List<Product> stockList = new List<Product>();
            bool wantContinue = true;

            while (wantContinue == true) {
                Console.WriteLine("What do you wanna do");
                Console.WriteLine("1 - Add a product");
                Console.WriteLine("2 - Remove a product");
                Console.WriteLine("3 - See all the products in stock");
                Console.WriteLine("4 - See the stock value");
                Console.WriteLine("5 - Close the program");

                char action = char.Parse(Console.ReadLine());

                if (action == '1') {
                    Console.WriteLine("Type the product name");
                    string choosedName = Console.ReadLine().ToLower();

                    Console.WriteLine("Type the product's price");
                    double choosedPrice = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the product's quantity");
                    int choosedQuantity = int.Parse(Console.ReadLine());

                    Product createdProduct = new Product(choosedName, choosedPrice, choosedQuantity);
                    stockList.Add(createdProduct);
                    Console.WriteLine("Product added to stock with success!");

                }

                else if (action == '2') {
                    Console.WriteLine("Type the name of the product that you wanna remove:");
                    string productToRemove = Console.ReadLine().ToLower();







                }

                else if (action == '3') {

                    if (stockList.Count == 0) {
                        Console.WriteLine("There isn't any product on the stock yet");
                    }

                    else {
                        foreach (Product currentProduct in stockList) {
                            Console.WriteLine(currentProduct.getProductInfo());
                        }
                    }


                }

                else if (action == '4') {
                    double totalCost = 0;

                    foreach (Product currentProduct in stockList) {
                        totalCost += currentProduct.Price * currentProduct.Quantity;
                    }

                    Console.WriteLine($"The total cost of the stock is actually: ${totalCost}");

                }
                else {
                    wantContinue = false;
                    Console.WriteLine("The program was ended, see you again!");
                }
            }


        }
    }
}
