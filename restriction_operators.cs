// Utility class and method
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

public class Order
{
    public int OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
}

public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public Order[] Orders { get; set; }
}


// 1. use where to find all elements of an array less than 5

public void Linq1() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var lessThan5 =
        from n in numbers
        where n < 5
        select n;
}

// 2. use where to find all products that are out of stock
public void Linq2() {

    List<Product> products = new List<Product>();
    products = GetProducts();

    var soldOutProducts =
        from p in products
        where p.UnitsInStock == 0
        select p;
}

// 3. use where to find all products that are in stock and cost more than 3.00
// per unit
public void Linq3() {

    List<Product> products = new List<Product>();
    products = GetProducts();

    var expensiveProdcts =
        from p in products
        where p.UnitPrice > 3.00m && p.UnitsInStock != 0
        select p;
}

// 4. use where to find all customers in Washington and then uses the resulting
// sequence to drill down into their orders.
public void Linq4() {

    List<Customer> customers = new List<Customer>();
    customers = GetCustomers();

    var waCust =
        from c in customers
        where c.Region == "WA"
        select c;

    var waOrders = waCust.orders;
}

// 5. demonstrate an indexed where clause that returns digits whose name is
// shorter than their value.

public void Linq5() {

    string[] digits = { "zero", "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine" };

    var shortDigits = digits.where((digit, index) => digit.Length < index);
}
