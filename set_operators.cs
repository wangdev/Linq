// 46. use distinct to remove duplicate elements in a sequence of factors of 300

public void Linq46() {

    int[] factorsOf300 = {2, 2, 3, 5, 5};

    var uniqueFactors = factorOf300.Distinct();
}

// 47. use distince to find the unique category names

public void Linq47() {

    List<Product> products = GetProductList();

    var categoryNames = (
        from p in products
        select p.Category
    ).Distinct();
}

// 48. use union to create one sequence that containes the unique values from
// both arrays.

public void Linq48() {

    int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
    int[] numbersB = {1, 3, 5, 7, 8};

    var uniqueNumbers = numbersA.Union(numbersB);
}

// 49. use union to create one sequence that contains the unique first letter
// from both product and customer names.

public void Linq49() {
    List<Product> products = GetProductList();
    List<Customer> customers = GetCustomerList();

    var productFirstChars =
        from p in products
        select p.ProductName[0];

    var customerFirstChars =
        from c in customers
        select c.CompanyName[0];

    var uniqueChars =
        productFirstChars.Union(customerFirstChars);
}

// 50. use intersect to create one sequence that contains the common values
// shared by both arrays

public Linq50() {
    int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
    int[] numbersB = {1, 3, 5, 7, 8};

    var commonNumbers = numbersA.Intersect(numbersB);
}

// 51. use intersect to create one sequence that contains the common first letter
// from both product and customer names

public void Linq51() {
    List<Product> products = GetProductList();
    List<Customer> customers = GetCustomerList();

    var productFirstChars =
        from p in products
        select p.ProductName[0];

    var customerFirstChars =
        from c in customers
        select c.CompanyName[0];

    var uniqueChars =
        productFirstChars.Intersect(customerFirstChars);
}

// 52. use except to create a sequence that contains the values from numbersA
// that are not in numbersB

public void Linq52() {
    int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
    int[] numbersB = {1, 3, 5, 7, 8};

    var aOnlyNumbers = numbersA.Except(numbersB);
}

// 53. use Except to create aone sequence that contains the first letters of
// product names that are not also first letters of customer names.

public void Linq53() {
    List<Product> products = GetProductList();
    List<Customer> customers = GetCustomerList();

    var productFirstChars =
        from p in products
        select p.ProductName[0];

    var customerFirstChars =
        from c in customers
        select c.CompanyName[0];

    var uniqueChars =
        productFirstChars.Except(customerFirstChars);
}
