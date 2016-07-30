// 102. join two sequences based on equality between key expressions over the two.

public void Linq102() {
    string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };

    List<Product> products = GetProductList();

    var q =
        from c in categories
        join p in products on c equals p.Category
        select new { Category = c, p.ProductName };
}

// 103. use a group join you can get all the products that match a given Category
// bundled as a sequence.

public void Linq103{
    string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };

    List<Product> products = GetProductList();

    var q =
        from c in categories
        join p in products on c equals p.Category into ps
        select new { Category = c, Products = ps };
}

// 104. The group join operator is more general than join, as this slightly
// more verbose version of the cross join sample shows.

public void Linq104() {
    string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };

    List<Product> products = GetProductList();



    var q =
        from c in categories
        join p in products on c equals p.Category into ps
        from p in ps
        select new { Category = c, p.ProductName };
}

// 105. A so-called outer join can be expressed with a group join. A left outer
// joinis like a cross join, except that all the left hand side elements get
// included at least once, even if they don't match any right hand side
// elements. Note how Vegetablesshows up in the output even though it has no
// matching products.

public void Linq105()  {
    string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };
    List<Product> products = GetProductList();
    var q =
        from c in categories
        join p in products on c equals p.Category into ps
        from p in ps.DefaultIfEmpty()
        select new {
            Category = c,
            ProductName = p == null ? "(No products)" : p.ProductName
        };

}
