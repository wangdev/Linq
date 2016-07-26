// 6. use select to produce a sequence of ints one higher than those in an
// existing array of ints.

public void Linq6() {

    int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

    var numsPlusOne =
        from n in numbers
        select n + 1;
}

// 7. use select to return a sequence of just the names of a list of products

public void Linq7() {

    List<Product> products = GetProductList();

    var productNames =
        from p in products
        select p.ProductName;
}

// 8. use select to produce a sequence of strings representing the text version
// of a sequence of ints

public void Linq8() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    string[] numStrings = {"zero", "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine"};

    var textNums =
        from n in numbers
        select numStrings[n];

}

// 9. use select to produce a sequence of the uppercase and lowercase versions
// of each word in the original array.

public void Linq9() {

    string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

    var UpLoWords =
        from w in words
        select new {uppe =: w.ToUpper(), lower = w.ToLower()};

}

// 10. use select to produce a sequence containing text representations of digits
// and whether their length is even or odd.

public void Linq10() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    string[] numStrings = {"zero", "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine"};

    var evenOddPred =
        from n in numbers
        select new {text = numstrings[n], evenOrOdd = n % 2 == 0 ? "Even" : "Odd" };

}

// 11. use select to produce a sequence containing some properties of Products,
// including UnitPrice which is renamed to Price in the resulting type.

public void Linq11() {

    List<Product> products = GetProducts();

    var productInfo =
        from p in products
        select new {productName = p.ProductName, productUnitPrice = p.UnitPrice,
            unitsInStock = p.UnitsInStock};

}

// 12. use an indexed select clause to determine if the value of ints in an array
// match their position in the array.

public void Linq12() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var IsMatchNumbers = numbers.Select((val, index) => new {val,
            match = val == inde ? true : false});
}

// 13. use select and where to make a simple query that returns the text form of
// each digit less than 5

public void Linq13() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    string[] numStrings = {"zero", "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine"};

    var lessThan5 = numbers.Select(val => {
        if(numStrings[val].Length < 5) {
            return numStrings[val];
        }
    });
}

// 14. use a compound from clause to make a query that returns all pairs of
// numbers from both arrays such that the number from nubersA is less than the
// number from numbersB

public void Linq14() {

    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
    int[] numbersB = { 1, 3, 5, 7, 8 };

    var aLtB =
        from a in numbersA
        from b in numbersB
        where a < b
        select new {a, b};

}

// 15. use a compound from clause to select all orders where the order total is
// less than 500.00

public void  Linq15() {

    List<Customer> customers = GetCustomerList();

    var orders =
        from c in customers
        from o in c.orders
        where o.Total < 500.00M
        select new {c.CustomerID, o.OrderID, o.Total};
}

// 16.  use a compuond from clause to select all orders where the order was made
//  in 1998 or later.

public void Linq16() {

    List<Customer> customers = GetCustomerList();

    var orders =
        from c in customers
        from o in c.orders
        where o.OrderDate >= new DateTime(1998, 1, 1);
        select new { c.CustomerID, o.OrderID, o.OrderDate };
}

// 17. use a compound from clause to select all orders where the order total is
//  greater than 2000.00 and uses from assignment
// to avoid requesting the total twice.

public void Linq17() {

    List<Customer> customers = GetCustomerList();

    var orders =
        from c in customers
        from o in c.orders
        where o.Total >= 2000.0M
        select new { c.CustomerID, o.OrderID, o.Total};
}

// 18. use multiple from clauses so that filtering on customers can be done
// before selecting their orders.This makes the query more efficient by not
// selecting and then discarding orders from customers outside of Washington.

public void Linq18() {

    List<Customer> customers = GetCustomerList();

    DateTime cutoffDay = new DateTime(1997, 1, 1);

    var orders =
        from c in customers
        where c. Region == "WA"
        from o in c.Orders
        where o.OrderDate >= cutoffDay
        select new {c.CustomerID, o.OrderID};

}

// 19. use indexed selectmany clause to select all orders, while referring to
// customers by the order in which they are returned from the query

public void Linq19() {
    List<Customer> customers = GetCustomerList();

    var customerOrders =  customers.SelectMany(
        (cust, custIndex) => cust.Orders.Select(
            o => "Customer #" + (custIndex + 1) + " has an order with OrderID "
                + o.OrderID)
            );
    )
}
