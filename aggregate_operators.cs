// 73. use Count to get hte number of unique factors of 300.

public void Linq73() {
    int[] numbers = {2, 2, 3, 5, 5};
    var factors = numbers.Distinct().Count();
}

// 74. use Count to get hte number of odd ints in the array

public void Linq74() {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    var oddCount =
        (
            from n in numbers
            where n % 2 == 1
            select n
        ).Count();
}

// 75. use count to return a list of customers and how many orders each has.

public void Linq75() {
    List<Customer> customers = GetCustomerList();
    var orderCount =
        from c in customers
        select new {c.CustomerID, OrderCount = c.Orders.Count()};
}

// 77. use Count to return a list of categories and how many products each has.

public void Linq77() {
    List<Product> products = GetProductList();
    var categoryCounts =
        from p in products
        group p by p.Category into g
        select new {Category = g.Key, ProductCount = g.Count()};
}

// 78. use Sum to get the total of the numbers in an array.

public void Linq78() {
    int[] numbers = {5,4,1,3,2,6,5,7,8,9,10};
    var Sum = numbers.Sum();
}

// 79. use sum to get the total number of characters of all words in the array.

public void Linq79() {
    string[] words = { "cherry", "apple", "blueberry" };
    double totalChars = words.Sum(w => s.Length);
}

// 80. use Sum to get the total units in stock for each product category.

public void Linq80() {
    List<Product> products = GetProductList();
    var totalUnits =
        from p in products
        group p by p.Category into g
        select new {Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock)};
}

// 81. use Min to get the lowest number in an array

public void Linq81() {

    int[] numbers = {5,4,1,3,2,6,5,7,8,9,10};
    var lowestNum = numbers.Min();
}

// 82. use Min to get the length of the shortest word in an array.

public void Linq82() {

    string[] words = { "cherry", "apple", "blueberry" };
    var shortestWord = words.Min(w => w.Length);
}

// 83. use Min to get the cheapest price among each category's products.

public void Linq83() {

    List<Product> products = GetProductList();
    var cpstPrices =
        from p in products
        group p by p.Category into g
        select new {Category=g.key, cheapestPrice = g.Min(p => p.UnitPrice)};
}

// 84. use Min to get the products with the cheapest price in each category.

public void Linq84() {
    List<Product> products = GetProductList();
    var cpstProduct =
        from p in products
        group p by p.Category into g
        let minPrice = g.Min(p => p.UnitPrice)
        select new {Category = g.Key, CheapestProducts = g.Where(
            p => p.UnitPrice == minPrice)};
}

// 85. use Max to get the highest number in an array.

public void Linq85() {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    int maxNum = numbers.Max();

    Console.WriteLine("The maximum number is {0}.", maxNum);
}

// 86. use Max to get hte length of the longest word in an array.

public void Linq86() {
    string[] words = { "cherry", "apple", "blueberry" };

    int longestLength = words.Max(w => w.Length);

    Console.WriteLine("The longest word is {0} characters long.", longestLength);
}

// 87 use max to get the most expensive price among each category's products
public void Linq87() {
    var categories =
        from p in products
        group p by p.Category into g
        select new { Category = g.Key, MostExpensivePrice = g.Max(
            p => p.UnitPrice) };
}

// 88. use max to get hte products with the most expensive price in each category.

public void Linq88(){
    List<Product> products = GetProductList();
    var categories =
        from p in products
        group p by p.Category into g
        let maxPrice = g.Max(p => p.UnitPrice)
        select new {Category = p.Category, MostExpensiveProducts = g.Where(
            p => p.UnitPrice == maxPrice)};
}

// 89. use Average to get hte average of all numbers in an array.

public void Linq89() {
    string[] words = { "cherry", "apple", "blueberry" };
    double averageLength = words.Average(w => w.Length);
}

// 91. use Average to get the average price of each category's products.

public void Linq91() {
    List<Product> products = GetProductList();

    var categories =
        from p in products
        group p by p.Category into g
        select new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) };
}

// 92.use Aggregate to create a running product on the array that calculates the total product of all elements.

public void Linq92() {
    double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

    double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

    Console.WriteLine("Total product of all numbers: {0}", product);
}
