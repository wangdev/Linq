// 58. use first to return the first matching element as a Product, instread of
// as a seqnence containing a Product.

public void Linq58() {
    List<Product> products = GetProductList();
    (
        from p in products
        where p.ProductId = 12
        select p
    )
    .First();
}

// 59.use First to find the first element in the array that starts with 'o'

public void Linq59() {

    string[] strings = {"zero", "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine"};

    string startWithO = strings.First(s => s[0] == '0');
}

// 61. use firstordefault to try to return the first element of the sequence,
// unless there are no elements, in which case the default value for that type
// is returned.

public void Linq60() {
    int[] numbers = {};
    int firstNumOrDefault = numbers.firstOrDefault();
}

// 62. use FirstOrDefault to return the first product whose ProductID is 789 as
// a single Product object, unless there is no  match, in which case null is
// returned.

public void Linq62() {
    List<Product> products = GetProductList();
    var firstProductWithID789 = products.FirstOrDefault(p => p.ProductID == 789);
}

// 63. Use ElementAt to retrieve the second number greater than 5 from an array.

public void Linq63() {
    int[] numbers = {5,4,1,3,9,8,6,7,2,0};

    var firstGt5 =
    (
        from n in numbers
        where n > 5
        select n
    )
    .ElementAt(1);
}
