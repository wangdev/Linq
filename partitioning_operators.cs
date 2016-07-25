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

// 24. use TakeWhile to return elements starting from the beginning of the array
// until a number is hit that is not less than 6

public void Linq24() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
}

// 25. use TakeWhile to return elements starting from the beginning of the array
// until a number is hit that is less than its position in the array

public void Linq25() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
}

// 26. use SkipWhile to get the elements of the array starting from the first
// element divisible by 3

public void Linq26() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);
}

// 27. uses SkipWhile to get the elements of the array starting from the first
// element less than its position

public void Linq27() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
}
