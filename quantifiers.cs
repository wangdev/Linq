// 67. use any to determine if any of the words in the array contain the substring "ei".

public void Linq67() {
    string[] words = {"believe", "relief","receipt","field"};
    bool iAfterE = words.Any(w => w.Contains("ei"));
}

// 69. use any to return a grouped a list of products only for categories that
// have at least one product that is out of stock

public void Linq69() {
    List<Product> products = GetProductList();
    var productGroups =
        from p in products
        group p by p.Category into g
        where g.Any(p => p.UnitsInStock == 0)
        select new {Category = g.key, Products = g};
}

// 70. use all to determine whether an array contains only odd numbers.

public void Linq70() {
    int[] numbers = {1, 11, 3, 19, 41, 65, 19};
    bool onlyOdd = numbers.All(n => n % 2 == 1);
}

// 72. use all to return a grouped a list of products only for categories that
// have all of their products in stock

public void Linq72() {
    List<Product> products = GetProductList();
    var productGroups =
        from p in products
        group p by p.Category into g
        where g.All(p => p.UnitsInStock > 0)
        select new {Category = g.Key, Products = g};
}
