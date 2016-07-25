// 20. use take to get only the first 3 elements of array

public void Linq20() {

    int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

    var first3Numbers = numbers.Take(3);
}

// 21. use take to get the first 3 orders from customers in Washington

public void Linq21() {

    List<Customer> customers = GetCustomerList();

    var first3WAOrders = (
        from c in customers
        from o in c.orders
        where c.Region == "WA"
        select new {c.CustomerID, o.OrderID, o.OrderDate})
        .Take(3);
}

// 22. use skip to get all but the first 4 elements of the array

public void Linq22() {

    int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

    var allButFirst4Numbers = numbers.Skip(4);
}

// 23. use take to get all but the first 2 orders from customers in Washington

public void Linq23() {

    List<Customer> customers = GetCustomerList();

    var allBut1st20Orders =
        (from c in customers
        from o in c.orders
        where c.Region = "WA"
        select new {c.CustomerID, o.OrderID, o.OrderDate}).Skip(20);
}
